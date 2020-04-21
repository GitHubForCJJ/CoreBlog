using Blog.EntityFramework.Extensions;
using Blog.EntityFramework.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntityFramework
{
    public class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity :class, IEntity<TKey>,ICreateTime, new()
              where TKey : IEquatable<TKey>
    {
        private readonly DbSet<TEntity> _dbSet;
        private readonly DbContext _dbContext;
        /// <summary>
        /// 获取 当前单元操作对象
        /// </summary>
        public IUnitOfWork UnitOfWork { get; }

        public BaseRepository(IServiceProvider serviceProvider)
        {
            UnitOfWork = serviceProvider.GetUnitOfWork<TEntity, TKey>();
            _dbContext = (DbContext)UnitOfWork.GetDbContext<TEntity, TKey>();
            _dbSet = ((DbContext)_dbContext).Set<TEntity>();
        }

        #region 同步方法
        /// <summary>
        /// 插入实体
        /// </summary>
        /// <param name="entities">实体对象集合</param>
        /// <returns>操作影响的行数</returns>
        public virtual int Insert(params TEntity[] entities)
        {
            entities = CheckInsert(entities);
            _dbSet.AddRange(entities);
            return _dbContext.SaveChanges();
        }
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entities">实体对象集合</param>
        /// <returns>操作影响的行数</returns>
        public virtual int Delete(params TEntity[] entities)
        {

            DeleteInternal(entities);
            return _dbContext.SaveChanges();
        }
        /// <summary>
        /// 删除指定编号的实体
        /// </summary>
        /// <param name="key">实体主键</param>
        /// <returns>操作影响的行数</returns>
        public virtual int Delete(TKey key)
        {
            //CheckEntityKey(key, nameof(key));

            TEntity entity = _dbSet.Find(key);
            return Delete(entity);
        }

        /// <summary>
        /// 删除所有符合特定条件的实体
        /// </summary>
        /// <param name="predicate">查询条件谓语表达式</param>
        /// <returns>操作影响的行数</returns>
        public virtual int DeleteBatch(Expression<Func<TEntity, bool>> predicate)
        {
            //Check.NotNull(predicate, nameof(predicate));
            // todo: 检测删除的数据权限

            //((DbContextBase)_dbContext).BeginOrUseTransaction();
            if (typeof(IDeleted).IsAssignableFrom(typeof(TEntity)))
            {
                // 逻辑删除
                TEntity[] entities = _dbSet.Where(predicate).ToArray();
                DeleteInternal(entities);
                return _dbContext.SaveChanges();
            }
            else
            {
                //物理删除
                //return _dbSet.Where(predicate).Delete();
                return 1;
            }

        }

        /// <summary>
        /// 更新实体对象
        /// </summary>
        /// <param name="entities">更新后的实体对象</param>
        /// <returns>操作影响的行数</returns>
        public virtual int Update(params TEntity[] entities)
        {
            Check.NotNull(entities, nameof(entities));
            // entities = CheckUpdate(entities);
            ((DbContext)_dbContext).Update<TEntity, TKey>(entities);
            return _dbContext.SaveChanges();
        }
        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="predicate">查询条件谓语表达式</param>
        /// <param name="id">编辑的实体标识</param>
        /// <returns>是否存在</returns>
        public virtual bool CheckExists(Expression<Func<TEntity, bool>> predicate, TKey id = default(TKey))
        {
            Check.NotNull(predicate, nameof(predicate));

            TKey defaultId = default(TKey);
            var entity = _dbSet.Where(predicate).Select(m => new { m.KID }).FirstOrDefault();
            bool exists = !typeof(TKey).IsValueType && ReferenceEquals(id, null) || id.Equals(defaultId)
                ? entity != null
                : entity != null && !EntityBase<TKey>.IsKeyEqual(entity.KID, id);
            return exists;
        }

        /// <summary>
        /// 查找指定主键的实体
        /// </summary>
        /// <param name="key">实体主键</param>
        /// <returns>符合主键的实体，不存在时返回null</returns>
        public virtual TEntity Get(TKey key)
        {
            CheckEntityKey(key, nameof(key));

            return _dbSet.Find(key);
        }

        /// <summary>
        /// 查找第一个符合条件的数据
        /// </summary>
        /// <param name="predicate">数据查询谓语表达式</param>
        /// <returns>符合条件的实体，不存在时返回null</returns>
        public virtual TEntity GetFirst(Expression<Func<TEntity, bool>> predicate)
        {
            predicate.CheckNotNull("predicate");
            return GetFirst(predicate, true);
        }
        /// <summary>
        /// 查找第一个符合条件的数据
        /// </summary>
        /// <param name="predicate">数据查询谓语表达式</param>
        /// <param name="filterByDataAuth">是否使用数据权限过滤，数据权限一般用于存在用户实例的查询，系统查询不启用数据权限过滤</param>
        /// <returns>符合条件的实体，不存在时返回null</returns>
        public virtual TEntity GetFirst(Expression<Func<TEntity, bool>> predicate, bool filterByDataAuth)
        {
            Check.NotNull(predicate, nameof(predicate));
            return Query(predicate, filterByDataAuth).FirstOrDefault();
        }
        /// <summary>
        /// 获取<typeparamref name="TEntity"/>跟踪数据更改（Tracking）的查询数据源
        /// </summary>
        /// <param name="predicate">数据过滤表达式</param>
        /// <returns>符合条件的数据集</returns>
        public virtual IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate)
        {
            return Query(predicate, false);
        }

        /// <summary>
        /// 获取<typeparamref name="TEntity"/>跟踪数据更改（Tracking）的查询数据源，并可附加过滤条件及是否启用数据权限过滤
        /// </summary>
        /// <param name="predicate">数据过滤表达式</param>
        /// <param name="filterByDataAuth">(我改暂不用 )是否使用数据权限过滤，数据权限一般用于存在用户实例的查询，系统查询不启用数据权限过滤</param>
        /// <returns>符合条件的数据集</returns>
        public virtual IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate, bool filterByDataAuth = false)
        {
            IQueryable<TEntity> query = _dbSet.AsQueryable();
            //if (filterByDataAuth)
            //{
            //    Expression<Func<TEntity, bool>> dataAuthExp = GetDataFilter(DataAuthOperation.Read);
            //    query = query.Where(dataAuthExp);
            //}
            if (predicate == null)
            {
                return query;
            }
            return query.Where(predicate);
        }
        /// <summary>
        /// 获取<typeparamref name="TEntity"/>跟踪数据更改（Tracking）的查询数据源，并可附加过滤条件及是否启用数据权限过滤
        /// </summary>
        /// <param name="predicate">数据过滤表达式</param>
        /// <param name="QueryBase">(</param>
        /// <returns>符合条件的数据集</returns>
        public virtual IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate, QueryBase<TEntity> queryBase = null)
        {
            IQueryable<TEntity> query = _dbSet.AsQueryable();
            if (queryBase != null)
            {
                query = queryBase.GetQuery(query);
            }

            if (predicate == null)
            {
                return query;
            }
            return query.Where(predicate);
        }
        /// <summary>
        /// 获取<typeparamref name="TEntity"/>跟踪数据更改（Tracking）的查询数据源，并可Include导航属性
        /// </summary>
        /// <param name="includePropertySelectors">要Include操作的属性表达式</param>
        /// <returns>符合条件的数据集</returns>
        public virtual IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includePropertySelectors)
        {
            IQueryable<TEntity> query = _dbSet.AsQueryable();
            if (includePropertySelectors == null || includePropertySelectors.Length == 0)
            {
                return query;
            }

            foreach (Expression<Func<TEntity, object>> selector in includePropertySelectors)
            {
                query = query.Include(selector);
            }
            return query;
        }


        #endregion

        #region 异步方法

        /// <summary>
        /// 异步插入实体
        /// </summary>
        /// <param name="entities">实体对象集合</param>
        /// <returns>操作影响的行数</returns>
        public virtual async Task<int> InsertAsync(params TEntity[] entities)
        {
            Check.NotNull(entities, nameof(entities));

            entities = CheckInsert(entities);
            await _dbSet.AddRangeAsync(entities);
            return await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// 异步删除实体
        /// </summary>
        /// <param name="entities">实体对象集合</param>
        /// <returns>操作影响的行数</returns>
        public virtual async Task<int> DeleteAsync(params TEntity[] entities)
        {
            Check.NotNull(entities, nameof(entities));

            DeleteInternal(entities);
            return await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// 异步删除指定编号的实体
        /// </summary>
        /// <param name="key">实体编号</param>
        /// <returns>操作影响的行数</returns>
        public virtual async Task<int> DeleteAsync(TKey key)
        {
            CheckEntityKey(key, nameof(key));

            TEntity entity = await _dbSet.FindAsync(key);
            return await DeleteAsync(entity);
        }

        /// <summary>
        /// 异步删除所有符合特定条件的实体
        /// </summary>
        /// <param name="predicate">查询条件谓语表达式</param>
        /// <returns>操作影响的行数</returns>
        public virtual async Task<int> DeleteBatchAsync(Expression<Func<TEntity, bool>> predicate)
        {
            Check.NotNull(predicate, nameof(predicate));
            // todo: 检测删除的数据权限

            //await ((DbContextBase)_dbContext).BeginOrUseTransactionAsync();
            if (typeof(IDeleted).IsAssignableFrom(typeof(TEntity)))
            {
                // 逻辑删除
                TEntity[] entities = _dbSet.Where(predicate).ToArray();
                DeleteInternal(entities);
                return await _dbContext.SaveChangesAsync();
            }
            else
            {
                // 物理删除
                //return await _dbSet.Where(predicate).DeleteAsync(_cancellationTokenProvider.Token);
                return 1;
            }


        }
        /// <summary>
        /// 异步更新实体对象
        /// </summary>
        /// <param name="entities">更新后的实体对象</param>
        /// <returns>操作影响的行数</returns>
        public virtual async Task<int> UpdateAsync(params TEntity[] entities)
        {
            Check.NotNull(entities, nameof(entities));

            entities = CheckUpdate(entities);
            ((DbContext)_dbContext).Update<TEntity, TKey>(entities);
            return await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// 异步更新所有符合特定条件的实体
        /// </summary>
        /// <param name="predicate">查询条件谓语表达式</param>
        /// <param name="updateExpression">实体更新表达式</param>
        /// <returns>操作影响的行数</returns>
        //public virtual async Task<int> UpdateBatchAsync(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TEntity>> updateExpression)
        //{
        //    Check.NotNull(predicate, nameof(predicate));
        //    Check.NotNull(updateExpression, nameof(updateExpression));

        //    await ((DbContextBase)_dbContext).BeginOrUseTransactionAsync();
        //    return await _dbSet.Where(predicate).UpdateAsync(updateExpression);
        //}

        /// <summary>
        /// 异步检查实体是否存在
        /// </summary>
        /// <param name="predicate">查询条件谓语表达式</param>
        /// <param name="id">编辑的实体标识</param>
        /// <returns>是否存在</returns>
        public virtual async Task<bool> CheckExistsAsync(Expression<Func<TEntity, bool>> predicate, TKey id = default(TKey))
        {
            predicate.CheckNotNull(nameof(predicate));

            TKey defaultId = default(TKey);
            var entity = await _dbSet.Where(predicate).Select(m => new { m.KID }).FirstOrDefaultAsync();
            bool exists = !typeof(TKey).IsValueType && ReferenceEquals(id, null) || id.Equals(defaultId)
                ? entity != null
                : entity != null && !EntityBase<TKey>.IsKeyEqual(entity.KID, id);
            return exists;
        }

        /// <summary>
        /// 异步查找指定主键的实体
        /// </summary>
        /// <param name="key">实体主键</param>
        /// <returns>符合主键的实体，不存在时返回null</returns>
        public virtual async Task<TEntity> GetAsync(TKey key)
        {
            CheckEntityKey(key, nameof(key));

            return await _dbSet.FindAsync(key);
        }


        #endregion

        #region 私有方法
        /// <summary>
        /// 添加时候检查createtime 后期可以加其它处理
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        private TEntity[] CheckInsert(params TEntity[] entities)
        {
            for (int i = 0; i < entities.Length; i++)
            {
                TEntity entity = entities[i];
                entities[i] = entity.CheckICreatedTime<TEntity, TKey>();

                //我   增加对createuserid等的处理
                //string userIdTypeName = _principal?.Identity.GetClaimValueFirstOrDefault("userIdTypeName");
                //if (userIdTypeName == null)
                //{
                //    continue;
                //}
                //entity = entities[i];
                //if (userIdTypeName == typeof(int).FullName)
                //{
                //    entities[i] = entity.CheckICreationAudited<TEntity, TKey, int>(_principal);
                //}
                //else if (userIdTypeName == typeof(Guid).FullName)
                //{
                //    entities[i] = entity.CheckICreationAudited<TEntity, TKey, Guid>(_principal);
                //}
                //else
                //{
                //    entities[i] = entity.CheckICreationAudited<TEntity, TKey, long>(_principal);
                //}
            }

            return entities;
        }

        /// <summary>
        /// 删除前的处理,如果实体实现了IDeleted接口就执行逻辑删除
        /// </summary>
        /// <param name="entities"></param>
        private void DeleteInternal(params TEntity[] entities)
        {
            //CheckDataAuth(DataAuthOperation.Delete, entities);
            if (typeof(IDeleted).IsAssignableFrom(typeof(TEntity)))
            {
                // 逻辑删除
                foreach (TEntity entity in entities)
                {
                    IDeleted softDeletableEntity = (IDeleted)entity;
                    softDeletableEntity.IsDeleted = 1;
                }
            }
            else
            {
                // 物理删除
                //_dbSet.RemoveRange(entities);
            }
        }

        /// <summary>
        /// 添加实体前的检查，可以在里面处理updatetime等数据
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        private TEntity[] CheckUpdate(params TEntity[] entities)
        {
            //处理当前账户是否有对该数据的更新权限
            //CheckDataAuth(DataAuthOperation.Update, entities);

            //for (var i = 0; i < entities.Length; i++)
            //{
            //    TEntity entity = entities[i];
            //    if (userIdTypeName == typeof(int).FullName)
            //    {
            //        entities[i] = entity.CheckIUpdateAudited<TEntity, TKey, int>(_principal);
            //    }
            //    else if (userIdTypeName == typeof(Guid).FullName)
            //    {
            //        entities[i] = entity.CheckIUpdateAudited<TEntity, TKey, Guid>(_principal);
            //    }
            //    else
            //    {
            //        entities[i] = entity.CheckIUpdateAudited<TEntity, TKey, long>(_principal);
            //    }
            //}

            return entities;
        }

        private static void CheckEntityKey(object key, string keyName)
        {
            key.CheckNotNull("key");
            keyName.CheckNotNull("keyName");

            Type type = key.GetType();
            if (type == typeof(int))
            {
                Check.GreaterThan((int)key, keyName, 0);
            }
            else if (type == typeof(string))
            {
                Check.NotNullOrEmpty((string)key, keyName);
            }
            else if (type == typeof(Guid))
            {
                ((Guid)key).CheckNotEmpty(keyName);
            }
        }

        #endregion
    }
}

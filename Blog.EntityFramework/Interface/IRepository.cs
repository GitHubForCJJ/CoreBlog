using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Blog.EntityFramework
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        #region 同步
        /// <summary>
        /// 插入实体
        /// </summary>
        /// <param name="entities">实体对象集合</param>
        /// <returns>操作影响的行数</returns>
        int Insert(params TEntity[] entities);
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entities">实体对象集合</param>
        /// <returns>操作影响的行数</returns>
        int Delete(params TEntity[] entities);
        /// <summary>
        /// 删除指定编号的实体
        /// </summary>
        /// <param name="key">实体主键</param>
        /// <returns>操作影响的行数</returns>
        int Delete(TKey key);
        /// <summary>
        /// 删除所有符合特定条件的实体
        /// </summary>
        /// <param name="predicate">查询条件谓语表达式</param>
        /// <returns>操作影响的行数</returns>
        int DeleteBatch(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// 更新实体对象
        /// </summary>
        /// <param name="entities">更新后的实体对象</param>
        /// <returns>操作影响的行数</returns>
        int Update(params TEntity[] entities);
        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="predicate">查询条件谓语表达式</param>
        /// <param name="id">编辑的实体标识</param>
        /// <returns>是否存在</returns>
        bool CheckExists(Expression<Func<TEntity, bool>> predicate, TKey id = default(TKey));
        /// <summary>
        /// 查找指定主键的实体
        /// </summary>
        /// <param name="key">实体主键</param>
        /// <returns>符合主键的实体，不存在时返回null</returns>
        TEntity Get(TKey key);
        /// <summary>
        /// 查找第一个符合条件的数据
        /// </summary>
        /// <param name="predicate">数据查询谓语表达式</param>
        /// <returns>符合条件的实体，不存在时返回null</returns>
        TEntity GetFirst(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// 查找第一个符合条件的数据
        /// </summary>
        /// <param name="predicate">数据查询谓语表达式</param>
        /// <param name="filterByDataAuth">是否使用数据权限过滤，数据权限一般用于存在用户实例的查询，系统查询不启用数据权限过滤</param>
        /// <returns>符合条件的实体，不存在时返回null</returns>

        TEntity GetFirst(Expression<Func<TEntity, bool>> predicate, bool filterByDataAuth);
        /// <summary>
        /// 获取<typeparamref name="TEntity"/>跟踪数据更改（Tracking）的查询数据源
        /// </summary>
        /// <param name="predicate">数据过滤表达式</param>
        /// <returns>符合条件的数据集</returns>
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// 获取<typeparamref name="TEntity"/>跟踪数据更改（Tracking）的查询数据源，并可附加过滤条件及是否启用数据权限过滤
        /// </summary>
        /// <param name="predicate">数据过滤表达式</param>
        /// <param name="filterByDataAuth">(我改暂不用 )是否使用数据权限过滤，数据权限一般用于存在用户实例的查询，系统查询不启用数据权限过滤</param>
        /// <returns>符合条件的数据集</returns>
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate, bool filterByDataAuth = false);
        /// <summary>
        /// 获取<typeparamref name="TEntity"/>跟踪数据更改（Tracking）的查询数据源，并可Include导航属性
        /// </summary>
        /// <param name="includePropertySelectors">要Include操作的属性表达式</param>
        /// <returns>符合条件的数据集</returns>
        IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includePropertySelectors);
        #endregion
    }
}

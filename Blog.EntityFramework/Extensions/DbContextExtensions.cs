using Blog.EntityFramework.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.EntityFramework.Extensions
{
    public static class DbContextExtensions
    {
        /// <summary>
        /// 更新上下文中指定实体的状态
        /// </summary>
        /// <typeparam name="TEntity">实体类型</typeparam>
        /// <typeparam name="TKey">主键类型</typeparam>
        /// <param name="context">上下文对象</param>
        /// <param name="entities">要更新的实体类型</param>
        public static void Update<TEntity, TKey>(this DbContext context, params TEntity[] entities)
            where TEntity : class, IEntity<TKey>
        {
            Check.NotNull(entities, nameof(entities));

            DbSet<TEntity> set = context.Set<TEntity>();
            foreach (TEntity entity in entities)
            {
                try
                {
                    EntityEntry<TEntity> entry = context.Entry(entity);
                    if (entry.State == EntityState.Detached)
                    {
                        set.Attach(entity);
                        entry.State = EntityState.Modified;
                    }
                }
                catch (InvalidOperationException)
                {
                    TEntity oldEntity = set.Find(entity.KID);
                    context.Entry(oldEntity).CurrentValues.SetValues(entity);
                }
            }
        }

        /// <summary>
        /// 检测关系型数据库是否存在
        /// </summary>
        public static bool ExistsRelationalDatabase(this DbContext context)
        {
            RelationalDatabaseCreator creator = context.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
            return creator != null && creator.Exists();
        }
        /// <summary>
        /// 当前上下文是否是关系型数据库
        /// </summary>
        public static bool IsRelationalTransaction(this DbContext context)
        {
            return context.Database.GetService<IDbContextTransactionManager>() is IRelationalTransactionManager;
        }
    }
}

using Blog.EntityFramework.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.EntityFramework.Extensions
{
    public static class EntityExtensions
    {
        /// <summary>
        /// 检测并执行<see cref="ICreatedTime"/>接口的逻辑
        /// </summary>
        public static TEntity CheckICreatedTime<TEntity, TKey>(this TEntity entity)
             where TEntity : IEntity<TKey>

        {
            if (!(entity is ICreateTime))
            {
                return entity;
            }
            ICreateTime entity1 = (ICreateTime)entity;
            if (entity1.CreateTime == default(DateTime))
            {
                entity1.CreateTime = DateTime.Now;
            }

            return (TEntity)entity1;
        }
    }
}

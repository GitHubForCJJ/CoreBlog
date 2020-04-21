using Blog.EntityFramework.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.EntityFramework.Extensions
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// 获取指定实体类的上下文所在工作单元
        /// </summary>
        public static IUnitOfWork GetUnitOfWork<TEntity, TKey>(this IServiceProvider provider) where TEntity : IEntity<TKey>
        {
            //IUnitOfWorkManager unitOfWorkManager = provider.GetService<IUnitOfWorkManager>();
            //return unitOfWorkManager.GetUnitOfWork<TEntity, TKey>();
            IUnitOfWork unitOfWork = ActivatorUtilities.CreateInstance<UnitOfWork>(provider);
            return unitOfWork;
        }

        /// <summary>
        /// 获取指定类型的日志对象
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="type">指定类型</param>
        /// <returns>日志对象</returns>
        public static ILogger GetLogger(this IServiceProvider provider, Type type)
        {
            ILoggerFactory factory = provider.GetService<ILoggerFactory>();
            return factory.CreateLogger(type);
        }
    }
}

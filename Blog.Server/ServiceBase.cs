using Blog.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Linq.Expressions;

namespace Blog.Services
{
    public class ServiceBase<TEntity, TKey> where TEntity : class
    {
        private readonly IServiceProvider serviceProvider;

        public ServiceBase(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        /// <summary>
        /// 泛型对应的仓储
        /// </summary>
        protected IRepository<TEntity, TKey> Repositoy => serviceProvider.GetService<IRepository<TEntity, TKey>>();

        //public void GetJsonListPage(int page = 1, int limit = 10, string orderby = "", params Expression<Func<TEntity, bool>>[] predicates)
        //{
        //    Repositoy.Query()
        //}
    }
}

using Blog.Abstractions.Entitys;
using Blog.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Services
{
    public class BlogService : IBlogServices
    {
        private readonly IServiceProvider provider;

        public IRepository<Category, int> cat { get; }

        public BlogService(IServiceProvider provider, IRepository<Category, int> cat)
        {
            this.provider = provider;
            this.cat = cat;
        }

        #region 属性

        public IRepository<Bloginfo, int> BloginfoRep => provider.GetService<IRepository<Bloginfo, int>>();
        public IRepository<Blogcontent, int> BlogcontentRep => provider.GetService<IRepository<Blogcontent, int>>();
        public IRepository<Category, int> CategoryRep { get { return provider.GetService<IRepository<Category, int>>(); } }
        #endregion

        #region 业务方法



        #endregion
    }
}

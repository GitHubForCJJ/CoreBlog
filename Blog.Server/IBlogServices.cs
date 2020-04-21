using Blog.Abstractions.Entitys;
using Blog.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Services
{
    public interface IBlogServices
    {
        IRepository<Bloginfo, int> BloginfoRep { get; }
        IRepository<Blogcontent, int> BlogcontentRep { get; }
        IRepository<Category, int> CategoryRep { get; }
    }
}

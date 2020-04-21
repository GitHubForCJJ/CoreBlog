using Blog.Abstractions.Entitys;
using Blog.EntityFramework;
using Blog.EntityFramework.Extensions;
using Blog.EntityFramework.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Blog.Abstractions.Config;
using System.Text;

namespace Blog.Abstractions
{
    public class BlogDbContext : DbContextBase
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options, IServiceProvider serviceProvider) : base(options, serviceProvider, Assembly.GetExecutingAssembly())
        {

        }
        public DbSet<ArticlePraise> ArticlePraises { get; set; }
        public DbSet<Bloginfo> Bloginfos { get; set; }
        public DbSet<Blogcontent> Blogcontents { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Categorypic> Categorypics { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HotNew> HotNews { get; set; }
        public DbSet<Logintoken> Logintokens { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Sysmenu> Sysmenus { get; set; }
        public DbSet<Sysrole> Sysroles { get; set; }
        public DbSet<Sysuserrole> Sysuserroles { get; set; }
        public DbSet<WxUser> WxUsers { get; set; }
        public DbSet<Operationlog> Operationlogs { get; set; }

    }
}

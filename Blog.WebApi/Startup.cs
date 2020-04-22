using Blog.Abstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Cors;
using Blog.EntityFramework;
using Blog.Services;
using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Blog.WebApi.Models;
using Blog.Abstractions.Entitys;

namespace Blog.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public static IContainer AutofacContainer;

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {

            //services.AddBlogDbService();
            //services.AddBlogService();

            services.AddDbContext<BlogDbContext>(options => options.UseMySql(Configuration.GetConnectionString("BlogDbConnection")));


            services.AddCors(options =>
            {
                options.AddPolicy("any", builder =>
                {
                    builder.AllowAnyOrigin() //允许任何来源的主机访问
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();//指定处理cookie
                });
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            ContainerBuilder cbuilder = new ContainerBuilder();
            //将services中的服务填充到Autofac中.
            cbuilder.Populate(services);
            //新模块组件注册
            cbuilder.RegisterModule<DefaultModuleRegister>();
            //创建容器.
            AutofacContainer = cbuilder.Build();
            //使用容器创建 AutofacServiceProvider 
            //return new AutofacServiceProvider(AutofacContainer);

            var a = AutofacContainer.Resolve<IServiceProvider>();
            var b= a.GetService<IBlogServices>();
            var c = b.BloginfoRep;
            return a;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApplicationLifetime appLifetime)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions developrExceptionPageOptions = new DeveloperExceptionPageOptions();
                developrExceptionPageOptions.SourceCodeLineCount = 20;
                app.UseDeveloperExceptionPage(developrExceptionPageOptions);
            }
            app.UseStaticFiles();

            

            app.UseMvc(router =>
            {
                //router.MapRoute("areaRoute", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                router.MapRoute("default", "api/{controller}/{action}/{id?}");
            });

            //程序停止调用函数
            appLifetime.ApplicationStopped.Register(() => { AutofacContainer.Dispose(); });

        }
    }
}

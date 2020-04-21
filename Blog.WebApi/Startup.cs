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

namespace Blog.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BlogDbContext>(options => options.UseMySql(Configuration.GetConnectionString("BlogDbConnection")));
            services.AddBlogDbService();
            services.AddBlogService();


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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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

        }
    }
}

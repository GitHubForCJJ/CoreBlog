using Autofac;
using Blog.EntityFramework;
using Blog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace Blog.WebApi.Models
{
    /// <summary>
    /// 上面代码调用了builder的RegisterModule函数,这个函数需要传入一个TModule的泛型，称之为autofac的模块
    /// 模块的功能就是把所有相关的注册配置都放在一个类中，使代码更易于维护和配置，下面展示了DefaultModuleRegister中的代码
    /// </summary>
    public class DefaultModuleRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //注册当前程序集中以“Ser”结尾的类,暴漏类实现的所有接口，生命周期为PerLifetimeScope
            //builder.RegisterAssemblyTypes(System.Reflection.Assembly.GetExecutingAssembly()).Where(t => t.Name.EndsWith("Ser")).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(System.Reflection.Assembly.GetExecutingAssembly()).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            //注册所有"MyApp.Repository"程序集中的类
            //builder.RegisterAssemblyTypes(GetAssembly("MyApp.Repository")).AsImplementedInterfaces();
            builder.RegisterGeneric(typeof(BaseRepository<,>)).As(typeof(IRepository<,>)).InstancePerDependency();//注册仓储泛型
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<BlogService>().As<IBlogServices>().InstancePerLifetimeScope();
        }

        public static System.Reflection.Assembly GetAssembly(string assemblyName)
        {
            var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(AppContext.BaseDirectory + $"{assemblyName}.dll");
            return assembly;
        }
    }
}

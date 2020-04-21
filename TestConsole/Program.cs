using Blog.EntityFramework.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;
using Blog.EntityFramework.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过实体配置信息将实体注册到当前上下文
            //Type contextType = GetType();
            //修改osharp的注册方式
            //var assembly = Assembly.GetEntryAssembly();
            //IEnumerable<Type> registers = assembly.GetMappingTypes(typeof(IEntityRegister));
            //foreach (var register in registers.Select(Activator.CreateInstance).Cast<IEntityRegister>())
            //{

            //}
            //foreach (var register in registers.Select(Activator.CreateInstance).Cast<IEntityRegister>())
            //{
            //    register.RegisterTo(modelBuilder);
            //    _logger?.LogDebug($"将实体类“{register.EntityType}”注册到上下文“{contextType}”中");
            //}
            var a = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IEntityRegister))))
                        .ToArray();
           
            foreach (var item in a)
            {
                IEntityRegister regis =(IEntityRegister)Activator.CreateInstance(item);
                var b = regis.DbContextType;
                //regis.RegisterTo(new ModelBuilder());
            }
            Console.Read();
        }

    }
}

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.EntityFramework
{
    public static class DbServiceExtension
    {

        public static IServiceCollection AddBlogDbService(this IServiceCollection collection)
        {
           
            collection.AddScoped(typeof(IRepository<,>), typeof(BaseRepository<,>));
            //collection.RegisterGeneric(typeof(BaseRepository<,>)).As(typeof(IRepository<,>)).InstancePerDependency();
            collection.AddScoped<IUnitOfWork, UnitOfWork>();
            return collection;
        }
    }
}

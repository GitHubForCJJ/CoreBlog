using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Services
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddBlogService(this IServiceCollection collection)
        {
            collection.AddScoped<IBlogServices, BlogService>();//单次请求
            return collection;
        }
    }
}

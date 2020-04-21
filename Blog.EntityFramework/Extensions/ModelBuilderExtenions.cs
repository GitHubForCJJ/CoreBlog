using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;

namespace Blog.EntityFramework.Extensions
{
    public static class ModelBuilderExtenions
    {
        public static IEnumerable<Type> GetMappingTypes(this Assembly assembly, Type mappingInterface)
        {
            //return assembly.GetTypes().Where(x => !x.GetTypeInfo().IsAbstract
            //&& x.GetInterfaces().Any(y => y.GetTypeInfo().IsGenericType
            //&& y.GetGenericTypeDefinition() == mappingInterface));

            return assembly.GetTypes().Where(y => y.GetInterfaces().Contains(mappingInterface));
        }
    }
}

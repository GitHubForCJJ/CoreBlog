using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.EntityFramework.Extensions
{
    public static class PageInfoExtensiong
    {
        public static IQueryable<T> SetPaging<T>(this PageInfo pageInfo, IQueryable<T> query)
        {
            pageInfo.Total = query.Count();
            query = query.Skip((pageInfo.PageIndex - 1) * pageInfo.PageSize).Take(pageInfo.PageSize);
            return query;
        }
    }
}

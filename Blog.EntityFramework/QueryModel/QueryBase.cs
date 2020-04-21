
using Blog.EntityFramework.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Blog.EntityFramework
{
    public abstract class QueryBase<T> where T : class, ICreateTime
    {
        //public Expression<Func<T, dynamic>>[] Paths
        //{
        //    get;
        //    set;
        //}

        public string[] IncludePaths
        {
            get;
            set;
        }

        public DateTime? FromAddTime
        {
            get;
            set;
        }

        public DateTime? ToAddTime
        {
            get;
            set;
        }

        public OrderBy OrderBy
        {
            get;
            set;
        }

        public PageInfo PageInfo
        {
            get;
            set;
        }

        protected abstract void SetQuery(ref IQueryable<T> query);

        protected abstract void SetOrderBy(ref IQueryable<T> query);


        public virtual IQueryable<T> GetQuery(IQueryable<T> query)
        {
            //if (Paths != null)
            //{
            //	Expression<Func<T, object>>[] paths = Paths;
            //	foreach (Expression<Func<T, object>> expression in paths)
            //	{
            //		query = query.Inclde()
            //	}
            //}
            if (IncludePaths != null)
            {
                string[] includePaths = IncludePaths;
                foreach (string text in includePaths)
                {
                    query = query.Include<T>(text);//efcore暂时没用对上面的支持  看源码方法
                }
            }
            if (FromAddTime.HasValue)
            {
                query = query.Where((T x) => x.CreateTime >= FromAddTime.Value);
            }
            if (ToAddTime.HasValue)
            {
                query = query.Where((T x) => x.CreateTime < ToAddTime.Value);
            }
            SetQuery(ref query);
            SetOrderBy(ref query);
            if (PageInfo != null)
            {
                if (OrderBy == null)
                {
                    query = query.OrderByDescending((T x) => x.CreateTime);
                }
                query = PageInfo.SetPaging(query);
            }
            else
            {
                PageInfo = new PageInfo
                {
                    Total = query.Count()
                };
            }
            return query;
        }
    }
}

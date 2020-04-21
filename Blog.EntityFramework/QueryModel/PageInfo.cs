using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.EntityFramework
{
	public class PageInfo
	{
		public int PageIndex
		{
			get;
			set;
		}

		public int PageSize
		{
			get;
			set;
		}

		public int Total
		{
			get;
			set;
		}
	}
}

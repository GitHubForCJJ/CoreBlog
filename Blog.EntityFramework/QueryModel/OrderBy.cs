using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.EntityFramework
{
    public class OrderBy
    {
		public string Sort
		{
			get;
			set;
		}

		public SqlOrder Order
		{
			get;
			set;
		}
	}
}

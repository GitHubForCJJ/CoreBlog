using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.EntityFramework.Interface
{
    public interface IDeleted
    {
        int IsDeleted { get; set; }
    }
}

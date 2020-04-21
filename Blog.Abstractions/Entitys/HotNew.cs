using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Blog.EntityFramework;
using Blog.EntityFramework.Interface;

namespace Blog.Abstractions.Entitys
{
    public class HotNew : CommonEntity<int>, IDeleted, ICreateTime
    {

    
        /// <summary>
        /// url地址
        /// </summary>
        
        public string Url { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        
        public string Title { get; set; }
    }
}

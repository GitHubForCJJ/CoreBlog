using Blog.EntityFramework;
using Blog.EntityFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Abstractions.Entitys
{
    /// <summary>
    /// 文章点赞
    /// </summary>
    public class ArticlePraise : CommonEntity<int>, IDeleted, ICreateTime
    {

    
        /// <summary>
        /// 会员id
        /// </summary>

        public string MemberId { get; set; }
        /// <summary>
        /// 文章编号
        /// </summary>

        public string BlogNum { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>

        public string IpAddress { get; set; }

    }
}

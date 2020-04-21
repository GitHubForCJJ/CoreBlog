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
    /// <summary>
    /// 会员
    /// </summary>
    
    public class Member : CommonEntity<int>, IDeleted, ICreateTime
    {

        /// <summary>
        /// 扩展6,
        /// </summary>
        
        public string UserName { get; set; }
        /// <summary>
        /// email地址  后期加其它登陆
        /// </summary>
        
        public string UserAccount { get; set; }

        /// <summary>
        /// 密码MD5 大写
        /// </summary>
        
        public string UserPassword { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        
        public string UserIcon { get; set; }
    }
}

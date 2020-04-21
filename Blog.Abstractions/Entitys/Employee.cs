//-----------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Go Enterprises">
// * copyright: (C) 2018 东走西走科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : chenjianjun
// * fileName : Employee.cs
// * history  : created by chenjianjun 2019-06-14 15:52:46
// </copyright>
//-----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Blog.EntityFramework;
using Blog.EntityFramework.Interface;

namespace Blog.Abstractions.Entitys
{
    /// <summary>
    /// Employee
    /// </summary>

    public class Employee : CommonEntity<int>, IDeleted, ICreateTime
    {

        /// <summary>
        /// 姓名
        /// </summary>

        public string UserName { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>

        public string UserAcount { get; set; }

        /// <summary>
        /// 密码MD5
        /// </summary>

        public string UserPassword { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>

        public string UserNikeName { get; set; }

        /// <summary>
        /// 是否为管理员0否，1是
        /// </summary>

        public int IsAdmin { get; set; }

        /// <summary>
        /// 上次重置时间
        /// </summary>

        public DateTime LastUpTime { get; set; }
        public virtual ICollection<Sysuserrole> Sysuserroles { get; set; }


        /*BC47A26EB9A59406057DDDD62D0898F4*/
    }
}

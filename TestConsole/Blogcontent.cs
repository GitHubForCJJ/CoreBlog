//-----------------------------------------------------------------------------------
// <copyright file="Blogcontent.cs" company="Go Enterprises">
// * copyright: (C) 2018 东走西走科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : chenjianjun
// * fileName : Blogcontent.cs
// * history  : created by chenjianjun 2019-06-27 15:21:32
// </copyright>
//-----------------------------------------------------------------------------------

using Blog.EntityFramework;
using Blog.EntityFramework.Interface;
using System;
using System.Runtime.Serialization;


namespace TestConsole
{
    /// <summary>
    /// Blogcontent
    /// </summary>
    public class Blogcontent : EntityBase<int>, IDeleted, ICreateTime
    {

        /// <summary>
        /// 状态,0正常数据 1已禁用
        /// </summary>

        public int States { get; set; }

        /// <summary>
        /// 删除,0未删除 1已删除
        /// </summary>

        public int IsDeleted { get; set; }

        /// <summary>
        /// 添加用户
        /// </summary>

        public string CreateUserId { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>

        public string CreateUserName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>

        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改用户Id
        /// </summary>

        public string UpdateUserId { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>

        public string UpdateUserName { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>

        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 扩展1,
        /// </summary>

        public int? Extend1 { get; set; }

        /// <summary>
        /// 扩展2,
        /// </summary>

        public int? Extend2 { get; set; }

        /// <summary>
        /// 扩展3,
        /// </summary>

        public int? Extend3 { get; set; }

        /// <summary>
        /// 扩展4,
        /// </summary>

        public string Extend4 { get; set; }

        /// <summary>
        /// 扩展5,
        /// </summary>

        public string Extend5 { get; set; }

        /// <summary>
        /// 扩展6,
        /// </summary>

        public string Extend6 { get; set; }

        /// <summary>
        /// 基本信息编号
        /// </summary>

        public string BloginfoNum { get; set; }

        /// <summary>
        /// 博客内容  url编码处理
        /// </summary>

        public string Content { get; set; }
        //public virtual Bloginfo Bloginfo { get; set; }


        /*BC47A26EB9A59406057DDDD62D0898F4*/
    }
}

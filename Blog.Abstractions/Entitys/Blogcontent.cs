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


namespace Blog.Abstractions.Entitys
{
    /// <summary>
    /// Blogcontent
    /// </summary>
    public class Blogcontent : CommonEntity<int>, IDeleted, ICreateTime
    {
        /// <summary>
        /// 基本信息编号
        /// </summary>

        public string BloginfoNum { get; set; }

        /// <summary>
        /// 博客内容  url编码处理
        /// </summary>

        public string Content { get; set; }


        /*BC47A26EB9A59406057DDDD62D0898F4*/
    }
}

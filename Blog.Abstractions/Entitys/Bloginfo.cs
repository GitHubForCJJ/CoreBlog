//-----------------------------------------------------------------------------------
// <copyright file="Bloginfo.cs" company="Go Enterprises">
// * copyright: (C) 2018 东走西走科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : chenjianjun
// * fileName : Bloginfo.cs
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
    /// Bloginfo
    /// </summary>

    public class Bloginfo : CommonEntity<int>, IDeleted, ICreateTime
    {

        /// <summary>
        /// 博客编号
        /// </summary>

        public string BlogNum { get; set; }


        /// <summary>
        /// 标题
        /// </summary>

        public string Title { get; set; }

        /// <summary>
        /// 类型
        /// </summary>

        public int Type { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>

        public int IsTop { get; set; }

        /// <summary>
        /// 是否私密不显示
        /// </summary>

        public int IsPrivate { get; set; }

        /// <summary>
        /// 是否原创
        /// </summary>

        public int IsOriginal { get; set; }

        /// <summary>
        /// 版本号，乐观锁
        /// </summary>

        public string Vesion { get; set; }

        /// <summary>
        /// blog图片
        /// </summary>

        public string Blogimg { get; set; }
        /// <summary>
        /// 序号
        /// </summary>

        public int Sorc { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>

        public int Start { get; set; }

        /// <summary>
        /// 浏览次数
        /// </summary>

        public int Views { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>

        public int Comments { get; set; }
        /// <summary>
        /// 所属分类
        /// </summary>
        public virtual Category Category { get; set; }


        /*BC47A26EB9A59406057DDDD62D0898F4*/
    }
}

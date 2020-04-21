//-----------------------------------------------------------------------------------
// <copyright file="Category.cs" company="Go Enterprises">
// * copyright: (C) 2018 东走西走科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : chenjianjun
// * fileName : Category.cs
// * history  : created by chenjianjun 2019-06-14 15:52:46
// </copyright>
//-----------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;
using Blog.EntityFramework;
using Blog.EntityFramework.Interface;

namespace Blog.Abstractions.Entitys
{
    /// <summary>
    /// Category
    /// </summary>

    public class Category : CommonEntity<int>, IDeleted, ICreateTime
    {

        /// <summary>
        /// 父id
        /// </summary>

        public int FatherId { get; set; }

        /// <summary>
        /// 类别
        /// </summary>

        public string Name { get; set; }

        /// <summary>
        /// 是否私密不显示
        /// </summary>

        public int Description { get; set; }


        /*BC47A26EB9A59406057DDDD62D0898F4*/
    }
}

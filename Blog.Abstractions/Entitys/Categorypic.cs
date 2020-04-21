//-----------------------------------------------------------------------------------
// <copyright file="Categorypic.cs" company="Go Enterprises">
// * copyright: (C) 2018 东走西走科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : chenjianjun
// * fileName : Categorypic.cs
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
    /// Categorypic
    /// </summary>
    public class Categorypic : CommonEntity<int>, IDeleted, ICreateTime
	{


		/// <summary>
		/// 功能id
		/// </summary>
		
		public int CategoryId { get; set;}

		/// <summary>
		/// 地址
		/// </summary>
		
		public string Url { get; set;}


        /*BC47A26EB9A59406057DDDD62D0898F4*/
    }
}

//-----------------------------------------------------------------------------------
// <copyright file="Media.cs" company="Go Enterprises">
// * copyright: (C) 2018 东走西走科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : chenjianjun
// * fileName : Media.cs
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
    /// Media
    /// </summary>
    
    public class Media : CommonEntity<int>, IDeleted, ICreateTime
	{
		/// <summary>
		/// 地址
		/// </summary>
		
		public string Url { get; set;}

		/// <summary>
		/// 类型,0图片，1视频
		/// </summary>
		
		public int Type { get; set;}


        /*BC47A26EB9A59406057DDDD62D0898F4*/
    }
}

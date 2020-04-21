//-----------------------------------------------------------------------------------
// <copyright file="Sysmenu.cs" company="Go Enterprises">
// * copyright: (C) 2018 东走西走科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : chenjianjun
// * fileName : Sysmenu.cs
// * history  : created by chenjianjun 2019-07-25 17:28:39
// </copyright>
//-----------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;
using Blog.EntityFramework;
using Blog.EntityFramework.Interface;

namespace Blog.Abstractions.Entitys
{
    /// <summary>
    /// Sysmenu
    /// </summary>
    
    public class Sysmenu : CommonEntity<int>, IDeleted, ICreateTime
	{       

		/// <summary>
		/// 菜单名称
		/// </summary>
		
		public string Menuname { get; set;}

		/// <summary>
		/// 菜单备注
		/// </summary>
		
		public string Menuremark { get; set;}

		/// <summary>
		/// 菜单连接
		/// </summary>
		
		public string MenuUrl { get; set;}

		/// <summary>
		/// 菜单icon
		/// </summary>
		
		public string Menuicon { get; set;}

		/// <summary>
		/// 菜单显示顺序
		/// </summary>
		
		public int Menusort { get; set;}

		/// <summary>
		/// 上级id
		/// </summary>
		
		public int Fatherid { get; set;}


        /*BC47A26EB9A59406057DDDD62D0898F4*/
    }
}

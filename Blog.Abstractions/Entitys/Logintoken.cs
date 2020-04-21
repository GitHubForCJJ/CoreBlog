//-----------------------------------------------------------------------------------
// <copyright file="Logintoken.cs" company="Go Enterprises">
// * copyright: (C) 2018 东走西走科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : chenjianjun
// * fileName : Logintoken.cs
// * history  : created by chenjianjun 2019-06-27 15:21:32
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
    /// Logintoken
    /// </summary>
    
    public class Logintoken : CommonEntity<int>, IDeleted, ICreateTime
	{
       

		/// <summary>
		/// token
		/// </summary>
		
		public string Token { get; set;}

		/// <summary>
		/// Token有效期到期时间
		/// </summary>
		
		public string TokenExpiration { get; set;}

		/// <summary>
		/// 登录者id
		/// </summary>
		
		public string LoginUserId { get; set;}

		/// <summary>
		/// 登录人的账号
		/// </summary>
		
		public string LoginUserAccount { get; set;}

		/// <summary>
		/// 登录账户类型
		/// </summary>
		
		public int LoginUserType { get; set;}

		/// <summary>
		/// 登录设备ip
		/// </summary>
		
		public string IpAddr { get; set;}

		/// <summary>
		/// 登录平台
		/// </summary>
		
		public int PlatForm { get; set;}

		/// <summary>
		/// 是否退出登录0未退，1退出
		/// </summary>
		
		public int IsLogOut { get; set;}

		/// <summary>
		/// 登录结果
		/// </summary>
		
		public string LoginResult { get; set;}




        /*BC47A26EB9A59406057DDDD62D0898F4*/
    }
}

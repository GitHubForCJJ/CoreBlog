//-----------------------------------------------------------------------------------
// <copyright file="Sysuserrole.cs" company="Go Enterprises">
// * copyright: (C) 2018 东走西走科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : chenjianjun
// * fileName : Sysuserrole.cs
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
    /// Sysuserrole
    /// </summary>
    
    public class Sysuserrole : CommonEntity<int>, IDeleted, ICreateTime
	{       
		/// <summary>
		/// 用户id
		/// </summary>
		
		public int Userid { get; set;}

		/// <summary>
		/// 角色id
		/// </summary>
		
		public int Roleid { get; set;}

		/// <summary>
		/// 0员工，1是会员
		/// </summary>
		
		public int UserType { get; set;}
		/// <summary>
		/// 员工
		/// </summary>
		public virtual Employee Employee { get; set; }
		public virtual Sysrole Sysrole { get; set; }


		/*BC47A26EB9A59406057DDDD62D0898F4*/
	}
}

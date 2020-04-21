//-----------------------------------------------------------------------------------
// <copyright file="Sysrole.cs" company="Go Enterprises">
// * copyright: (C) 2018 东走西走科技有限公司 版权所有。
// * version  : 1.0.0.0
// * author   : chenjianjun
// * fileName : Sysrole.cs
// * history  : created by chenjianjun 2019-07-25 17:28:39
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
    /// Sysrole
    /// </summary>
    
    public class Sysrole : CommonEntity<int>, IDeleted, ICreateTime
	{
        
		/// <summary>
		/// 角色名称
		/// </summary>
		
		public string Rolename { get; set;}

		/// <summary>
		/// 角色备注
		/// </summary>
		
		public string Roleremark { get; set;}

		/// <summary>
		/// 菜单ID，逗号分隔
		/// </summary>
		
		public string MenuList { get; set;}

		public virtual ICollection<Sysuserrole> Sysuserroles { get; set; }

		/*BC47A26EB9A59406057DDDD62D0898F4*/
	}
}

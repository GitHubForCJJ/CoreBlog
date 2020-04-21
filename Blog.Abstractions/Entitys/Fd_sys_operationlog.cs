//-----------------------------------------------------------------------------------
// <copyright file="Fd_sys_operationlog.cs" company="Go Enterprises">
// * copyright: (C) 2018 www.codemain.cn
// * version  : 1.0.0.0
// * author   : meteor
// * fileName : Fd_sys_operationlog.cs
// * history  : created by meteor 2018-10-19 16:52:42
// </copyright>
//-----------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;
using Blog.EntityFramework;
using Blog.EntityFramework.Interface;

namespace Blog.Abstractions.Entitys
{
    /// <summary>
    /// Fd_sys_operationlog
    /// </summary>

    public class Operationlog : CommonEntity<int>, ICreateTime
    {

        /// <summary>
        /// 数据对象,可以存储表名
        /// </summary>

        public string TableName { get; set; }

        /// <summary>
        /// 对象主键,操作对象的主键字段名称 默认KID
        /// </summary>

        public string TablePriKeyField { get; set; }

        /// <summary>
        /// 主键值,操作对象数据的值
        /// </summary>

        public string TablePriKeyValue { get; set; }

        /// <summary>
        /// 操作者IP地址
        /// </summary>

        public string IpAddr { get; set; }

        /// <summary>
        /// 请求数据,方便查看对象 可以为Json对象
        /// </summary>

        public string ReqData { get; set; }


        /// <summary>
        /// 操作前数据内容,Json对象
        /// </summary>

        public string ResOldData { get; set; }

        /// <summary>
        /// 操作后数据结果,Json对象,操作前后 数据记录
        /// </summary>

        public string ResResult { get; set; }

        /// <summary>
        /// 日志类型,1添加 2编辑 3修改 4常规日志
        /// </summary>

        public int OperType { get; set; }

        /// <summary>
        /// 操作结果,0成功 1失败 
        /// </summary>

        public int OperResult { get; set; }

        /// <summary>
        /// 日志内容
        /// </summary>

        public string LogContent { get; set; }


        /*BC47A26EB9A59406057DDDD62D0898F4*/
    }
}

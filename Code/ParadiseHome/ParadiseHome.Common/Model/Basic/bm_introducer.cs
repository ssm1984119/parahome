﻿/******************************************
* 模块名称：实体 居士或者介绍人
* 当前版本：1.0
* 开发人员：Administrator
* 生成时间：2012-4-17
* 版本历史：此代码由 VB/C#.Net实体代码生成工具(EntitysCodeGenerate 4.4) 自动生成。
* 
******************************************/
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ParadiseHome.Common.Model.Basic
{
	/// <summary>
	/// 实体 居士或者介绍人
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public partial class bm_introducer
	{
        #region 构造函数
        /// <summary>
        /// 实体 居士或者介绍人
        /// </summary>
        public bm_introducer(){}
        #endregion

        #region 私有变量
        private long _id = long.MinValue;
        private long _basicinfoid = long.MinValue;
        private DateTime _registertime = DateTime.MinValue;
        private string _comment = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 ID(NOT NULL)
        /// </summary>
        public long ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 个人基本信息ID(NOT NULL)
        /// </summary>
        public long BasicInfoID
        {
            set{ _basicinfoid=value;}
            get{return _basicinfoid;}
        }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime
        {
            set{ _registertime=value;}
            get{return _registertime;}
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Comment
        {
            set{ _comment=value;}
            get{return _comment;}
        }
        #endregion

        #region 公共静态只读属性
        /// <summary>
        /// 表名 表原信息描述: 居士或者介绍人
        /// </summary>
        public static readonly string s_TableName =  "bm_introducer";
        /// <summary>
        /// 信息描述: ID(NOT NULL)
        /// </summary>
        public static readonly string s_ID =  "bm_introducer┋ID┋System.Int64";
        /// <summary>
        /// 信息描述: 个人基本信息ID(NOT NULL)
        /// </summary>
        public static readonly string s_BasicInfoID =  "bm_introducer┋BasicInfoID┋System.Int64";
        /// <summary>
        /// 信息描述: 注册时间
        /// </summary>
        public static readonly string s_RegisterTime =  "bm_introducer┋RegisterTime┋System.DateTime";
        /// <summary>
        /// 信息描述: 备注
        /// </summary>
        public static readonly string s_Comment =  "bm_introducer┋Comment┋System.String";
        #endregion
	}

    /// <summary>
    /// 居士或者介绍人实体集
    /// </summary>
    [Serializable]
    public class bm_introducerS : CollectionBase
    {
        #region 构造函数
        /// <summary>
        /// 居士或者介绍人实体集
        /// </summary>
        public bm_introducerS(){}
        #endregion

        #region 属性方法
        /// <summary>
        /// 居士或者介绍人集合 增加方法
        /// </summary>
        public void Add(bm_introducer entity)
        {
            this.List.Add(entity);
        }
        /// <summary>
        /// 居士或者介绍人集合 索引
        /// </summary>
        public bm_introducer this[int index]
        {
            get { return (bm_introducer)this.List[index]; }
            set { this.List[index] = value; }
        }
        #endregion
    }
}

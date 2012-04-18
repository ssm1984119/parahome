﻿/******************************************
* 模块名称：实体 福位或者住所
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
	/// 实体 福位或者住所
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public partial class bm_cell
	{
        #region 构造函数
        /// <summary>
        /// 实体 福位或者住所
        /// </summary>
        public bm_cell(){}
        #endregion

        #region 私有变量
        private long _id = long.MinValue;
        private long _locationid = long.MinValue;
        private string _celltag = null;
        private float _currentprice = float.MinValue;
        private string _state = null;
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
        /// 位置ID(NOT NULL)
        /// </summary>
        public long LocationID
        {
            set{ _locationid=value;}
            get{return _locationid;}
        }
        /// <summary>
        /// 福位标识符
        /// </summary>
        public string CellTag
        {
            set{ _celltag=value;}
            get{return _celltag;}
        }
        /// <summary>
        /// 当前价格
        /// </summary>
        public float CurrentPrice
        {
            set{ _currentprice=value;}
            get{return _currentprice;}
        }
        /// <summary>
        /// 福位所处的状态
        /// </summary>
        public string State
        {
            set{ _state=value;}
            get{return _state;}
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
        /// 表名 表原信息描述: 福位或者住所
        /// </summary>
        public static readonly string s_TableName =  "bm_cell";
        /// <summary>
        /// 信息描述: ID(NOT NULL)
        /// </summary>
        public static readonly string s_ID =  "bm_cell┋ID┋System.Int64";
        /// <summary>
        /// 信息描述: 位置ID(NOT NULL)
        /// </summary>
        public static readonly string s_LocationID =  "bm_cell┋LocationID┋System.Int64";
        /// <summary>
        /// 信息描述: 福位标识符
        /// </summary>
        public static readonly string s_CellTag =  "bm_cell┋CellTag┋System.String";
        /// <summary>
        /// 信息描述: 当前价格
        /// </summary>
        public static readonly string s_CurrentPrice =  "bm_cell┋CurrentPrice┋System.Single";
        /// <summary>
        /// 信息描述: 福位所处的状态
        /// </summary>
        public static readonly string s_State =  "bm_cell┋State┋System.String";
        /// <summary>
        /// 信息描述: 备注
        /// </summary>
        public static readonly string s_Comment =  "bm_cell┋Comment┋System.String";
        #endregion
	}

    /// <summary>
    /// 福位或者住所实体集
    /// </summary>
    [Serializable]
    public class bm_cellS : CollectionBase
    {
        #region 构造函数
        /// <summary>
        /// 福位或者住所实体集
        /// </summary>
        public bm_cellS(){}
        #endregion

        #region 属性方法
        /// <summary>
        /// 福位或者住所集合 增加方法
        /// </summary>
        public void Add(bm_cell entity)
        {
            this.List.Add(entity);
        }
        /// <summary>
        /// 福位或者住所集合 索引
        /// </summary>
        public bm_cell this[int index]
        {
            get { return (bm_cell)this.List[index]; }
            set { this.List[index] = value; }
        }
        #endregion
    }
}

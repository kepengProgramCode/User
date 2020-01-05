/*
*作者：
*创建时间：2020/1/5 1:59:13 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace fff
{
    [Table("TaskMaterialInfo")]
    [Column(new string[]{"TaskNo"},"TrayCode","MaterialCode","MaterialName","MaterialModel","MaterialAmount","LocationRow","LocationColumn")]
    /// <summary>
    /// 
    /// </summary>
    public class TaskMaterialInfo:EntityBase
    {
       public const string TASKNO = "TaskNo";
       public const string TRAYCODE = "TrayCode";
       public const string MATERIALCODE = "MaterialCode";
       public const string MATERIALNAME = "MaterialName";
       public const string MATERIALMODEL = "MaterialModel";
       public const string MATERIALAMOUNT = "MaterialAmount";
       public const string LOCATIONROW = "LocationRow";
       public const string LOCATIONCOLUMN = "LocationColumn";

       private string taskNo;
       /// <summary>
       /// 
       /// </summary>
       public string TaskNo
       {
         get { return taskNo; }
         set { taskNo = value; }
       }

       private string trayCode;
       /// <summary>
       /// 
       /// </summary>
       public string TrayCode
       {
         get { return trayCode; }
         set { trayCode = value; }
       }

       private string materialCode;
       /// <summary>
       /// 
       /// </summary>
       public string MaterialCode
       {
         get { return materialCode; }
         set { materialCode = value; }
       }

       private string materialName;
       /// <summary>
       /// 
       /// </summary>
       public string MaterialName
       {
         get { return materialName; }
         set { materialName = value; }
       }

       private string materialModel;
       /// <summary>
       /// 
       /// </summary>
       public string MaterialModel
       {
         get { return materialModel; }
         set { materialModel = value; }
       }

       private int materialAmount;
       /// <summary>
       /// 
       /// </summary>
       public int MaterialAmount
       {
         get { return materialAmount; }
         set { materialAmount = value; }
       }

       private int locationRow;
       /// <summary>
       /// 
       /// </summary>
       public int LocationRow
       {
         get { return locationRow; }
         set { locationRow = value; }
       }

       private int locationColumn;
       /// <summary>
       /// 
       /// </summary>
       public int LocationColumn
       {
         get { return locationColumn; }
         set { locationColumn = value; }
       }

    }
}

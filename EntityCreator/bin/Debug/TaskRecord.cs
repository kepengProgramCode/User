/*
*作者：
*创建时间：2020/1/5 1:59:13 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace fff
{
    [Table("TaskRecord")]
    [Column(new string[]{"Id"},"TaskNo","AgvNo","StartCode","StartRow","StartColumn","StartLayer","EndCode","EndRow","EndColumn","EndLayer","TrayCode","Creator")]
    /// <summary>
    /// 
    /// </summary>
    public class TaskRecord:EntityBase
    {
       public const string ID = "Id";
       public const string TASKNO = "TaskNo";
       public const string AGVNO = "AgvNo";
       public const string STARTCODE = "StartCode";
       public const string STARTROW = "StartRow";
       public const string STARTCOLUMN = "StartColumn";
       public const string STARTLAYER = "StartLayer";
       public const string ENDCODE = "EndCode";
       public const string ENDROW = "EndRow";
       public const string ENDCOLUMN = "EndColumn";
       public const string ENDLAYER = "EndLayer";
       public const string TRAYCODE = "TrayCode";
       public const string CREATOR = "Creator";

       private int id;
       /// <summary>
       /// 
       /// </summary>
       public int Id
       {
         get { return id; }
         set { id = value; }
       }

       private string taskNo;
       /// <summary>
       /// 
       /// </summary>
       public string TaskNo
       {
         get { return taskNo; }
         set { taskNo = value; }
       }

       private string agvNo;
       /// <summary>
       /// 
       /// </summary>
       public string AgvNo
       {
         get { return agvNo; }
         set { agvNo = value; }
       }

       private string startCode;
       /// <summary>
       /// 
       /// </summary>
       public string StartCode
       {
         get { return startCode; }
         set { startCode = value; }
       }

       private string startRow;
       /// <summary>
       /// 
       /// </summary>
       public string StartRow
       {
         get { return startRow; }
         set { startRow = value; }
       }

       private string startColumn;
       /// <summary>
       /// 
       /// </summary>
       public string StartColumn
       {
         get { return startColumn; }
         set { startColumn = value; }
       }

       private string startLayer;
       /// <summary>
       /// 
       /// </summary>
       public string StartLayer
       {
         get { return startLayer; }
         set { startLayer = value; }
       }

       private string endCode;
       /// <summary>
       /// 
       /// </summary>
       public string EndCode
       {
         get { return endCode; }
         set { endCode = value; }
       }

       private string endRow;
       /// <summary>
       /// 
       /// </summary>
       public string EndRow
       {
         get { return endRow; }
         set { endRow = value; }
       }

       private string endColumn;
       /// <summary>
       /// 
       /// </summary>
       public string EndColumn
       {
         get { return endColumn; }
         set { endColumn = value; }
       }

       private string endLayer;
       /// <summary>
       /// 
       /// </summary>
       public string EndLayer
       {
         get { return endLayer; }
         set { endLayer = value; }
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

       private string creator;
       /// <summary>
       /// 
       /// </summary>
       public string Creator
       {
         get { return creator; }
         set { creator = value; }
       }

    }
}

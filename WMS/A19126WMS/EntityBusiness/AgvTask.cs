/*
*作者：
*创建时间：2020/1/6 9:37:25 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace A19126WMS.EntityBusiness
{
    [Table("AgvTask")]
    [Column(new string[]{"Id"},"TaskType","StartCode","StartWorkName","EndCode","EndWorkName","TrayCode","Updator","UpdateTime","Creator","CreateTime","AGVState")]
    /// <summary>
    /// 
    /// </summary>
    public class AgvTask:EntityBase
    {
       public const string ID = "Id";
       public const string TASKTYPE = "TaskType";
       public const string STARTCODE = "StartCode";
       public const string STARTWORKNAME = "StartWorkName";
       public const string ENDCODE = "EndCode";
       public const string ENDWORKNAME = "EndWorkName";
       public const string TRAYCODE = "TrayCode";
       public const string UPDATOR = "Updator";
       public const string UPDATETIME = "UpdateTime";
       public const string CREATOR = "Creator";
       public const string CREATETIME = "CreateTime";
       public const string AGVSTATE = "AGVState";

       private int id;
       /// <summary>
       /// 
       /// </summary>
       public int Id
       {
         get { return id; }
         set { id = value; }
       }

       private int taskType;
       /// <summary>
       /// 
       /// </summary>
       public int TaskType
       {
         get { return taskType; }
         set { taskType = value; }
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

       private string startWorkName;
       /// <summary>
       /// 
       /// </summary>
       public string StartWorkName
       {
         get { return startWorkName; }
         set { startWorkName = value; }
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

       private string endWorkName;
       /// <summary>
       /// 
       /// </summary>
       public string EndWorkName
       {
         get { return endWorkName; }
         set { endWorkName = value; }
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

       private string updator;
       /// <summary>
       /// 
       /// </summary>
       public string Updator
       {
         get { return updator; }
         set { updator = value; }
       }

       private DateTime updateTime;
       /// <summary>
       /// 
       /// </summary>
       public DateTime UpdateTime
       {
         get { return updateTime; }
         set { updateTime = value; }
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

       private DateTime createTime;
       /// <summary>
       /// 
       /// </summary>
       public DateTime CreateTime
       {
         get { return createTime; }
         set { createTime = value; }
       }

       private int aGVState;
       /// <summary>
       /// 
       /// </summary>
       public int AGVState
       {
         get { return aGVState; }
         set { aGVState = value; }
       }

    }
}

/*
*作者：
*创建时间：2020/1/5 1:59:13 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace fff
{
    [Table("AGVAlarmInfo")]
    [Column(new string[]{"Id"},"AlarmType","AlarmContent","AlarmContent","CreateTime","UpdateTime","Remarks")]
    /// <summary>
    /// 
    /// </summary>
    public class AGVAlarmInfo:EntityBase
    {
       public const string ID = "Id";
       public const string ALARMTYPE = "AlarmType";
       public const string ALARMCONTENT = "AlarmContent";
       public const string ALARMCONTENT = "AlarmContent";
       public const string CREATETIME = "CreateTime";
       public const string UPDATETIME = "UpdateTime";
       public const string REMARKS = "Remarks";

       private int id;
       /// <summary>
       /// 
       /// </summary>
       public int Id
       {
         get { return id; }
         set { id = value; }
       }

       private int alarmType;
       /// <summary>
       /// 
       /// </summary>
       public int AlarmType
       {
         get { return alarmType; }
         set { alarmType = value; }
       }

       private string alarmContent;
       /// <summary>
       /// 
       /// </summary>
       public string AlarmContent
       {
         get { return alarmContent; }
         set { alarmContent = value; }
       }

       private string alarmContent;
       /// <summary>
       /// 
       /// </summary>
       public string AlarmContent
       {
         get { return alarmContent; }
         set { alarmContent = value; }
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

       private DateTime updateTime;
       /// <summary>
       /// 
       /// </summary>
       public DateTime UpdateTime
       {
         get { return updateTime; }
         set { updateTime = value; }
       }

       private string remarks;
       /// <summary>
       /// 
       /// </summary>
       public string Remarks
       {
         get { return remarks; }
         set { remarks = value; }
       }

    }
}

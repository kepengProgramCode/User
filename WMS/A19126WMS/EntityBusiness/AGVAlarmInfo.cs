/*
*作者：
*创建时间：2020/1/6 9:37:25 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace A19126WMS.EntityBusiness
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
       /// 报警类别
       /// </summary>
       public int AlarmType
       {
         get { return alarmType; }
         set { alarmType = value; }
       }

       private string alarmContent;
       /// <summary>
       /// 报警内容
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
       /// 说明
       /// </summary>
       public string Remarks
       {
         get { return remarks; }
         set { remarks = value; }
       }

    }
}

/*
*作者：
*创建时间：2020/1/6 9:37:25 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace A19126WMS.EntityBusiness
{
    [Table("WorkLocationInfo")]
    [Column(new string[]{"ID"})]
    /// <summary>
    /// 
    /// </summary>
    public class WorkLocationInfo:EntityBase
    {
       public const string ID = "Id";

       private int iD;
       /// <summary>
       /// 
       /// </summary>
       public int Id
       {
         get { return iD; }
         set { iD = value; }
       }

    }
}

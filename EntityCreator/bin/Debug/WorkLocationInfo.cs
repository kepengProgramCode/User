/*
*作者：
*创建时间：2020/1/5 1:59:13 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace fff
{
    [Table("WorkLocationInfo")]
    [Column(new string[]{"ID"})]
    /// <summary>
    /// 
    /// </summary>
    public class WorkLocationInfo:EntityBase
    {
       public const string ID = "ID";

       private int iD;
       /// <summary>
       /// 
       /// </summary>
       public int ID
       {
         get { return iD; }
         set { iD = value; }
       }

    }
}

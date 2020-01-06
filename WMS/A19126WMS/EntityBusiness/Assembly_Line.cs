/*
*作者：
*创建时间：2020/1/6 9:37:25 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace A19126WMS.EntityBusiness
{
    [Table("Assembly_Line")]
    [Column(new string[]{"ID"},"Line_name","Line_name")]
    /// <summary>
    /// 
    /// </summary>
    public class Assembly_Line:EntityBase
    {
       public const string ID = "Id";
       public const string LINE_NAME = "Line_name";

       private int iD;
       /// <summary>
       /// 
       /// </summary>
       public int Id
       {
         get { return iD; }
         set { iD = value; }
       }


       private string line_name;
       /// <summary>
       /// 
       /// </summary>
       public string Line_name
       {
         get { return line_name; }
         set { line_name = value; }
       }

    }
}

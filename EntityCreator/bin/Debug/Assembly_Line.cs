/*
*作者：
*创建时间：2020/1/5 1:59:13 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace fff
{
    [Table("Assembly_Line")]
    [Column(new string[]{"ID"},"Line_name","Line_name")]
    /// <summary>
    /// 
    /// </summary>
    public class Assembly_Line:EntityBase
    {
       public const string ID = "ID";
       public const string LINE_NAME = "Line_name";
       public const string LINE_NAME = "Line_name";

       private int iD;
       /// <summary>
       /// 
       /// </summary>
       public int ID
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

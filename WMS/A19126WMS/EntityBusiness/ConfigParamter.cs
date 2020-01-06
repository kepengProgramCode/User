/*
*作者：
*创建时间：2020/1/6 9:37:25 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace A19126WMS.EntityBusiness
{
    [Table("ConfigParamter")]
    [Column(new string[]{"Id"},"Name")]
    /// <summary>
    /// 
    /// </summary>
    public class ConfigParamter:EntityBase
    {
       public const string ID = "Id";
       public const string NAME = "Name";

       private int id;
       /// <summary>
       /// 
       /// </summary>
       public int Id
       {
         get { return id; }
         set { id = value; }
       }

       private string name;
       /// <summary>
       /// 名称
       /// </summary>
       public string Name
       {
         get { return name; }
         set { name = value; }
       }

    }
}

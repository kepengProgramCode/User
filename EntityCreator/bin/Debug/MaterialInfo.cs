/*
*作者：
*创建时间：2020/1/5 1:59:13 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace fff
{
    [Table("MaterialInfo")]
    [Column(new string[]{"Id"},"MaterialCode","MaterialName","MaterialModel","Specification","TypeId","BatchNo","Unit","CreateTime")]
    /// <summary>
    /// 
    /// </summary>
    public class MaterialInfo:EntityBase
    {
       public const string ID = "Id";
       public const string MATERIALCODE = "MaterialCode";
       public const string MATERIALNAME = "MaterialName";
       public const string MATERIALMODEL = "MaterialModel";
       public const string SPECIFICATION = "Specification";
       public const string TYPEID = "TypeId";
       public const string BATCHNO = "BatchNo";
       public const string UNIT = "Unit";
       public const string CREATETIME = "CreateTime";

       private int id;
       /// <summary>
       /// 
       /// </summary>
       public int Id
       {
         get { return id; }
         set { id = value; }
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

       private string specification;
       /// <summary>
       /// 
       /// </summary>
       public string Specification
       {
         get { return specification; }
         set { specification = value; }
       }

       private int typeId;
       /// <summary>
       /// 
       /// </summary>
       public int TypeId
       {
         get { return typeId; }
         set { typeId = value; }
       }

       private int batchNo;
       /// <summary>
       /// 
       /// </summary>
       public int BatchNo
       {
         get { return batchNo; }
         set { batchNo = value; }
       }

       private string unit;
       /// <summary>
       /// 
       /// </summary>
       public string Unit
       {
         get { return unit; }
         set { unit = value; }
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

    }
}

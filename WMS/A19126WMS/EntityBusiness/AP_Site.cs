/*
*作者：
*创建时间：2020/1/6 9:37:25 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace A19126WMS.EntityBusiness
{
    [Table("AP_Site")]
    [Column(new string[]{"ID"},"Type","Type","IPAddress","IPAddress","信道","信道","SSID","SSID","位置","位置","Status","Remark")]
    /// <summary>
    /// 
    /// </summary>
    public class AP_Site:EntityBase
    {
       public const string ID = "Id";
       public const string TYPE = "Type";
       public const string IPADDRESS = "IPAddress";
       public const string 信道 = "信道S";
       public const string SSID = "SSId";
       public const string 位置 = "位置S";
       public const string STATUS = "Status";
       public const string REMARK = "Remark";

       private int iD;
       /// <summary>
       /// 
       /// </summary>
       public int Id
       {
         get { return iD; }
         set { iD = value; }
       }


       private string type;
       /// <summary>
       /// 
       /// </summary>
       public string Type
       {
         get { return type; }
         set { type = value; }
       }


       private string iPAddress;
       /// <summary>
       /// 
       /// </summary>
       public string IPAddress
       {
         get { return iPAddress; }
         set { iPAddress = value; }
       }

       private string 信道s;
       /// <summary>
       /// 
       /// </summary>
       public string 信道S
       {
         get { return 信道s; }
         set { 信道s = value; }
       }


       private string sSID;
       /// <summary>
       /// 
       /// </summary>
       public string SSId
       {
         get { return sSID; }
         set { sSID = value; }
       }

       private string 位置s;
       /// <summary>
       /// 
       /// </summary>
       public string 位置S
        {
         get { return 位置s; }
         set { 位置s = value; }
       }

       private string status;
       /// <summary>
       /// 
       /// </summary>
       public string Status
       {
         get { return status; }
         set { status = value; }
       }

       private string remark;
       /// <summary>
       /// 
       /// </summary>
       public string Remark
       {
         get { return remark; }
         set { remark = value; }
       }

    }
}

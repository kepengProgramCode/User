/*
*作者：
*创建时间：2020/1/5 1:59:13 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace fff
{
    [Table("AP_Site")]
    [Column(new string[]{"ID"},"Type","Type","IPAddress","IPAddress","信道","信道","SSID","SSID","位置","位置","Status","Remark")]
    /// <summary>
    /// 
    /// </summary>
    public class AP_Site:EntityBase
    {
       public const string ID = "ID";
       public const string TYPE = "Type";
       public const string TYPE = "Type";
       public const string IPADDRESS = "IPAddress";
       public const string IPADDRESS = "IPAddress";
       public const string 信道 = "信道";
       public const string 信道 = "信道";
       public const string SSID = "SSID";
       public const string SSID = "SSID";
       public const string 位置 = "位置";
       public const string 位置 = "位置";
       public const string STATUS = "Status";
       public const string REMARK = "Remark";

       private int iD;
       /// <summary>
       /// 
       /// </summary>
       public int ID
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

       private string iPAddress;
       /// <summary>
       /// 
       /// </summary>
       public string IPAddress
       {
         get { return iPAddress; }
         set { iPAddress = value; }
       }

       private string 信道;
       /// <summary>
       /// 
       /// </summary>
       public string 信道
       {
         get { return 信道; }
         set { 信道 = value; }
       }

       private string 信道;
       /// <summary>
       /// 
       /// </summary>
       public string 信道
       {
         get { return 信道; }
         set { 信道 = value; }
       }

       private string sSID;
       /// <summary>
       /// 
       /// </summary>
       public string SSID
       {
         get { return sSID; }
         set { sSID = value; }
       }

       private string sSID;
       /// <summary>
       /// 
       /// </summary>
       public string SSID
       {
         get { return sSID; }
         set { sSID = value; }
       }

       private string 位置;
       /// <summary>
       /// 
       /// </summary>
       public string 位置
       {
         get { return 位置; }
         set { 位置 = value; }
       }

       private string 位置;
       /// <summary>
       /// 
       /// </summary>
       public string 位置
       {
         get { return 位置; }
         set { 位置 = value; }
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

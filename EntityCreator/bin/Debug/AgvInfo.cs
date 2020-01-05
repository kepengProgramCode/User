/*
*作者：
*创建时间：2020/1/5 11:36:00 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace fff
{
    [Table("AgvInfo")]
    [Column(new string[]{"ID"},"IPAddress","IPAddress","SwitchIP","SwitchIP","Port","Status","Internal_ID","Assembly_Line","Type","Type","Loc_ID","Warn_ID","Mileage")]
    /// <summary>
    /// 
    /// </summary>
    public class AgvInfo:EntityBase
    {
       public const string ID = "ID";
       public const string IPADDRESS = "IPAddress";
       public const string IPADDRESS = "IPAddress";
       public const string SWITCHIP = "SwitchIP";
       public const string SWITCHIP = "SwitchIP";
       public const string PORT = "Port";
       public const string STATUS = "Status";
       public const string INTERNAL_ID = "Internal_ID";
       public const string ASSEMBLY_LINE = "Assembly_Line";
       public const string TYPE = "Type";
       public const string TYPE = "Type";
       public const string LOC_ID = "Loc_ID";
       public const string WARN_ID = "Warn_ID";
       public const string MILEAGE = "Mileage";

       private int iD;
       /// <summary>
       /// 
       /// </summary>
       public int ID
       {
         get { return iD; }
         set { iD = value; }
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

       private string switchIP;
       /// <summary>
       /// 
       /// </summary>
       public string SwitchIP
       {
         get { return switchIP; }
         set { switchIP = value; }
       }

       private string switchIP;
       /// <summary>
       /// 
       /// </summary>
       public string SwitchIP
       {
         get { return switchIP; }
         set { switchIP = value; }
       }

       private int port;
       /// <summary>
       /// 
       /// </summary>
       public int Port
       {
         get { return port; }
         set { port = value; }
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

       private int internal_ID;
       /// <summary>
       /// 
       /// </summary>
       public int Internal_ID
       {
         get { return internal_ID; }
         set { internal_ID = value; }
       }

       private int assembly_Line;
       /// <summary>
       /// 
       /// </summary>
       public int Assembly_Line
       {
         get { return assembly_Line; }
         set { assembly_Line = value; }
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

       private int loc_ID;
       /// <summary>
       /// 
       /// </summary>
       public int Loc_ID
       {
         get { return loc_ID; }
         set { loc_ID = value; }
       }

       private int warn_ID;
       /// <summary>
       /// 
       /// </summary>
       public int Warn_ID
       {
         get { return warn_ID; }
         set { warn_ID = value; }
       }

       private string mileage;
       /// <summary>
       /// 
       /// </summary>
       public string Mileage
       {
         get { return mileage; }
         set { mileage = value; }
       }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JJE_Business.Access;
using System.Data;
using JJE_WMS_Entity;

namespace JJE_Business.Business
{
    public class MaterialOutBusiness
    {
        public DataTable GetOutStoreMessage()
        {
            List<InStoreDetails> list = new List<InStoreDetails>();
            DataTable table = null;
            using (BaseAccess access = new BaseAccess())
            {
                string strSQL = "select distinct c.invcode 子件编码, a.mocode 订单号,d.cinvname 子件名称,d.cinvstd 子件规格, d.cInvDefine4 as 批次,e.ccomunitname 计量单位,sum(c.baseqtyN)as 基本用量,sum(c.qty)as 应领数量,d.cInvDefine4 as 库位,d.cInvDefine4 as 缺料量 from mom_order a,mom_orderdetail b, mom_moallocate c,INVENTORY d,computationunit e where a.moid=b.moid and b.modid=c.modid and c.invcode=d.cinvcode and d.ccomunitcode=e.ccomunitcode and a.MoCode ='A0000022373' group by c.invcode,a.mocode,d.cinvname,d.cinvstd,e.ccomunitname,d.iDrawBatch,d.cInvDefine4";
                table = access.ExcuteTable(strSQL);
            }
            using (StoreAccess access = new StoreAccess())
            {
                foreach (DataRow item in table.Rows)
                {
                    string strSQL = string.Format("SELECT * FROM [Table_InStoreDetails] WHERE [MaterialCode]= '{0}' ORDER BY Time ASC ", item["子件编码"]);
                    list = access.Select<InStoreDetails>(strSQL).Where(o => o.Count >= (decimal)item["应领数量"]).ToList<InStoreDetails>();
                    if (list.Count >= 1)
                    {
                        item["库位"] = list[0].VirifyCode;
                        item["批次"] = list[0].Batch;
                        item["缺料量"] = 0;
                    }
                    else
                    {
                        list = access.Select<InStoreDetails>(strSQL);
                        if (list.Count == 1)
                        {
                            item["库位"] = list[0].VirifyCode;
                            item["批次"] = list[0].Batch;
                            item["缺料量"] = (decimal)item["应领数量"] - list[0].Count;
                        }
                        else
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i].Count++ <= (decimal)item["应领数量"])
                                {
                                    item["库位"] += string.Concat(list[i].VirifyCode, ",");
                                    item["批次"] += string.Concat(list[i].Batch, ",");
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return table;
        }
    }
}

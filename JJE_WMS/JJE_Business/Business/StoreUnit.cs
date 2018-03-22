using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JJE_Business.Access;
using JJE_WMS_Entity;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace JJE_Business.Business
{
    public class StoreUnit
    {
        /// <summary>
        /// 创建仓库
        /// </summary>
        /// <param name="starStoreUnit">起始位置</param>
        /// <param name="endStoreUnit">终止位置</param>
        /// <param name="type">仓库类型</param>
        /// <returns>创建成功与否</returns>
        public bool CreatStroe(string starStoreUnit, string endStoreUnit, int type)
        {
            bool result = false;
            string[] unitStar = starStoreUnit.Split('-');
            string[] unitEnd = endStoreUnit.Split('-');

            int rowStar = Convert.ToInt16(unitStar[0]);
            int columnStar = (int)Convert.ToChar(unitStar[1]) - 64;
            int layerStar = Convert.ToInt16(unitStar[2]);

            int rowEnd = Convert.ToInt16(unitEnd[0]);
            int columnEnd = (int)Convert.ToChar(unitEnd[1]) - 64;
            int layerEnd = Convert.ToInt16(unitEnd[2]);
            if (rowStar > rowEnd || columnStar > columnEnd || layerStar > layerEnd)
            {
                MessageBox.Show("所填写的信息不正确，请重新填写");
                return false;
            }
            string[] store = new string[(rowEnd - rowStar + 1) * (columnEnd - columnStar + 1) * (layerEnd - layerStar + 1)];
            //if (rowStar == 1 && columnStar == 1 && layerStar == 1)
            //{
            //    for (int i = 0; i < rowEnd; i++)
            //    {
            //        for (int j = 0; j < columnEnd; j++)
            //        {
            //            for (int k = 0; k < layerEnd; k++)
            //            {
            //                store[i * columnEnd * layerEnd + j * layerEnd + k] = string.Format("{0}-{1}-{2}", i + 1, Convert.ToChar(j + 65), k + 1);
            //            }
            //        }
            //    }
            //}
            //else
            for (int i = 0; i < rowEnd - rowStar + 1; i++)
            {
                for (int j = 0; j < columnEnd - columnStar + 1; j++)
                {
                    for (int k = 0; k < layerEnd - layerStar + 1; k++)
                    {
                        store[i * (columnEnd - columnStar + 1) * layerEnd + j * (layerEnd - layerStar + 1) + k] = string.Format("{0}-{1}-{2}", rowStar + i, Convert.ToChar(columnStar + j + 64), layerStar + k);
                    }
                }
            }

            using (StoreAccess access = new StoreAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    for (int i = 0; i < store.Length; i++)
                    {
                        string[] storeParameter = store[i].Split('-');
                        string sql = access.CommandFormate("INSERT INTO [dbo].[Table_Warehouse]([Row],[Column],[Layer],[StoreStaus],[MaxCount],[Status],[Type]) VALUES({0}Row,{0}Column,{0}Layer,{0}StoreStaus,{0}MaxCount,{0}Status,{0}Type)");
                        access.Insert(sql, (parameter) =>
                        {
                            parameter.Add(parameter.CreateParameter("Row", storeParameter[0]));
                            parameter.Add(parameter.CreateParameter("Column", storeParameter[1]));
                            parameter.Add(parameter.CreateParameter("Layer", storeParameter[2]));
                            parameter.Add(parameter.CreateParameter("StoreStaus", 0));
                            parameter.Add(parameter.CreateParameter("MaxCount", 20000));
                            parameter.Add(parameter.CreateParameter("Status", 0));
                            parameter.Add(parameter.CreateParameter("Type", type));
                        });
                    }
                    access.Commit();
                    result = true;
                }
                catch (DbException ex)
                {
                    LogBusiness.RecordLog("管理员", ex.Message, "创建仓库结构数据操作异常");
                    access.RollBack();
                    access.Close();
                }
            }
            return result;
        }


        /// <summary>
        /// 查询仓库结构
        /// </summary>
        /// <returns></returns>
        public DataTable GetStoreStructure()
        {
            using (StoreAccess access = new StoreAccess())
            {
                string strSQL = "SELECT [Row],[Column],[Layer],[StoreStaus],[MaxCount],[Status],[Type] FROM [WMS_Manager].[dbo].[Table_Warehouse]";
                return access.ExcuteTable(strSQL);
            }
        }

        /// <summary>
        /// 仓库结构修改
        /// </summary>
        public int StoreStructUpdate(params string[] store)
        {
            int count = 0;
            using (StoreAccess access = new StoreAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    string strSQL = access.CommandFormate("UPDATE [dbo].[Table_Warehouse] SET [StoreStaus] = {0}StoreStaus,[Type]={0}Type WHERE [Row]={0}Row AND [Column]={0}Column AND [Layer]={0}Layer");
                    count = access.Update(strSQL, (parmarter) =>
                    {
                        parmarter.Add(parmarter.CreateParameter("StoreStaus", store[0]));
                        parmarter.Add(parmarter.CreateParameter("Type", store[1]));
                        parmarter.Add(parmarter.CreateParameter("Row", store[2]));
                        parmarter.Add(parmarter.CreateParameter("Column", store[3]));
                        parmarter.Add(parmarter.CreateParameter("Layer", store[4]));
                    });
                    access.Commit();
                }
                catch (DbException ex)
                {
                    LogBusiness.RecordLog("管理员", ex.Message, "修改仓库结构数据操作异常");
                    access.RollBack();
                    access.Close();
                }
            }
            return count;
        }

        /// <summary>
        /// 删除选中的项目
        /// </summary>
        /// <param name="select"></param>
        public void DeleteStoreStruct(params string[] select)
        {
            using (StoreAccess access = new StoreAccess(true))
            {
                string strSQL = string.Empty;
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    if (select[0] == "全部删除")
                    {
                        strSQL = access.CommandFormate("DELETE FROM [dbo].[Table_Warehouse]");
                        access.Delete(strSQL);
                    }
                    else
                    {
                        strSQL = access.CommandFormate("DELETE FROM [dbo].[Table_Warehouse] WHERE [Row] = {0}Row AND [Column] = {0}Column AND [Layer] = {0}Layer");
                        access.Delete(strSQL, parmater =>
                        {
                            parmater.Add(parmater.CreateParameter("Row", select[1]));
                            parmater.Add(parmater.CreateParameter("Column", select[2]));
                            parmater.Add(parmater.CreateParameter("Layer", select[3]));
                        });
                    }
                    access.Commit();
                }
                catch (DbException dbe)
                {
                    LogBusiness.RecordLog("管理员", dbe.Message, "删除仓库结构数据操作异常");
                }
            }
        }
    }
}

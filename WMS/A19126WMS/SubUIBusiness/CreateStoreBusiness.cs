using A19126WMS.BaseBusiness;
using A19126WMS.EntityBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace A19126WMS.SubUIBusiness
{
    class CreateStoreBusiness
    {
        /// <summary>
        /// 创建新的仓库
        /// </summary>
        /// <param name="type">库位类型</param>
        /// <param name="row">排</param>
        /// <param name="column">列</param>
        /// <param name="cacpcity">容量</param>
        /// <param name="layer">层</param>
        public void CreateStore(int type, int row, int column, int cacpcity, int layer = 1)
        {
            using (WMSAccess access = new WMSAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    for (int i = 1; i <= row; i++)
                    {
                        for (int j = 1; j <= column; j++)
                        {
                            StorageLocation storageLocation = new StorageLocation();
                            storageLocation.Row = i;
                            storageLocation.Column = j;
                            storageLocation.Layer = layer;
                            storageLocation.Cacpcity = cacpcity;
                            storageLocation.State = 0;
                            storageLocation.LockingState = 0;
                            storageLocation.StoreType = type;
                            storageLocation.CreateTime = DateTime.Now;
                            storageLocation.EnterTime = DateTime.Now;
                            storageLocation.SilenceTimeOut = DateTime.Now;
                            storageLocation.OverTimeOut = DateTime.Now;
                            storageLocation.StorageLocationTypeName = (type == 0) && (i <= row / 2) ? "A" : "B";
                            access.Insert(storageLocation);
                        }
                    }
                    access.Commit();
                    MessageBox.Show("创建库位成功", "消息", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    access.Rollback();
                    LogBusiness.WriteLog(this, $"生成{type}类型库位{row}-{column}-{layer}");
                    LogBusiness.WriteLog(this, "错误", ex);
                    MessageBox.Show(ex.Message, "消息", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }
    }
}

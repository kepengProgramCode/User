using A19126WMS.BaseBusiness;
using A19126WMS.EntityBusiness;
using Snt.Framework.SqlCondition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19126WMS.DBBusiness
{
    class MainUI_DB_Business
    {
        public List<LocationMaterialInfo> GetStoreDetilyByStore(AreaType areaType, out int storeCout)
        {
            List<LocationMaterialInfo> info;
            //List<LocationMaterialInfo> temp;
            //List<List<LocationMaterialInfo>> tempst = new List<List<LocationMaterialInfo>>();
            using (WMSAccess access = new WMSAccess())
            {
                storeCout = (int)access.ExecuteScalar($"SELECT COUNT(*) FROM [StorageLocation] WHERE [StoreType] ={(int)areaType}");
                //temp = access.ExecuteSelect<LocationMaterialInfo>($"SELECT [LocationRow],[LocationColumn],[LocationLayer] FROM LocationMaterialInfo WHERE [StoreType] ={(int)areaType} GROUP BY [LocationRow], [LocationColumn], [LocationLayer] HAVING COUNT ( * ) >= 1");
                info = access.Select<LocationMaterialInfo>($"SELECT * FROM LocationMaterialInfo WHERE StoreType = {(int)areaType}");
            }
            //for (int i = 0; i < info.Count; i++)
            //{
            //    List<LocationMaterialInfo> temps = info.Where(o => o.LocationRow.Equals(temp[i].LocationRow) && o.LocationColumn.Equals(temp[i].LocationColumn)).ToList();
            //    tempst.Add(temps);
            //}
            return info;
        }
    }
}

using A19126WMS.BaseBusiness;
using A19126WMS.EntityBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19126WMS.SubUIBusiness
{
    class IO_TaskBusiness
    {
        /// <summary>
        /// 查询入库任务
        /// </summary>
        public void QuereryIntoTask()
        {
            using (WMSAccess access = new WMSAccess())
            {
                try
                {
                    List<WMSTask> wMSTasks = access.Select<WMSTask>();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}

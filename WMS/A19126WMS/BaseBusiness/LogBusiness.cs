using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19126WMS.BaseBusiness
{
    class LogBusiness
    {
        /// <summary>
        ///  添加info信息
        /// </summary>
        /// <param name="info">自定义日志内容说明</param>
        public static void WriteLog(object instance, string info)
        {
            ILog Loginfo = LogManager.GetLogger(instance.GetType().Name);
            try
            {
                if (Loginfo.IsInfoEnabled)
                {
                    Loginfo.Info(info);
                }
            }
            catch { }
        }


        /// <summary>
        /// 添加异常信息
        /// </summary>
        /// <param name="info">自定义日志内容说明</param>
        /// <param name="ex">异常信息</param>
        public static void WriteLog(object instance, string info, Exception ex)
        {
            ILog Logerror = LogManager.GetLogger(instance.GetType().Name);
            try
            {
                if (Logerror.IsErrorEnabled)
                {
                    Logerror.Error(info, ex);
                }
            }
            catch { }
        }
    }
}

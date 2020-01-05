using Hnt.Entity;
using System.Collections.Generic;

namespace Hnt.Business.DataControl
{
    public abstract class BusinessControl
    {
        /// <summary>
        /// 获取托盘中电芯批次
        /// </summary>
        /// <param name="trayCode"></param>
        /// <returns></returns>
        public abstract string GetTrayBatch(string trayCode);
        /// <summary>
        /// 检查立体库中托盘条码是否重复
        /// </summary>
        /// <param name="trayCode"></param>
        /// <returns></returns>
        public abstract bool CheckStoreRepeat(string trayCode);

        /// <summary>
        /// 检查托盘条码是否正确
        /// </summary>
        /// <param name="trayCode"></param>
        /// <returns></returns>
        public abstract bool CheckTrayCode(string trayCode);
    }
}

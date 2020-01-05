using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hnt.Business
{

    public class CommandValue
    {
        /// <summary>
        /// 最大叠盘数量:"2"
        /// </summary>
        public const string MAX_STACK_COUNT = "2";
        /// <summary>
        /// 最小叠盘数量:"1"
        /// </summary>
        public const string MIN_STACK_COUNT = "1";
        /// <summary>
        /// 扫码异常:"4"
        /// </summary>
        public const string SCAN_ERROR = "4";
        /// <summary>
        /// 扫码成功，不混批:"3"
        /// </summary>
        public const string SCAN_SUCCESS_NO_MIXTURE = "3";
        /// <summary>
        /// 扫码成功，混批:"2"
        /// </summary>
        public const string SCAN_SUCCESS_MIXTURE = "2";
        /// <summary>
        /// 扫码失败:"2"
        /// </summary>
        public const string SCAN_CODE_FAILED = "2";
        /// <summary>
        /// 查不到批次信息:"5"
        /// </summary>
        public const string GET_BATCH_FAILED = "5";
        /// <summary>
        /// 与叠盘机内缓存托盘码重复:"3"
        /// </summary>
        public const string REPEAT_SCAN_CODE = "3";
        /// <summary>
        /// 与对应立体库内既有托盘码重复;"4"
        /// </summary>
        public const string REPEAT_STORE_CODE = "4";
        /// <summary>
        /// 初始状态:"1"
        /// </summary>
        public const string INITIAL_STATE = "1";
        /// <summary>
        /// 叠盘机编号:2
        /// </summary>
        public const int FLAG = 2;
        /// <summary>
        /// 清除数据成功:"4"
        /// </summary>
        public const string CLEAR_DATA_COMPLETE = "4";
        /// <summary>
        /// 托盘数量匹配异常:"3"
        /// </summary>
        public const string TRAY_COUNT_ERROR = "3";

        /// <summary>
        /// 托盘数据绑定完成:"2"
        /// </summary>
        public const string BIND_COMPLETE = "2";
    }
    public class MySQLBase
    {
        public const string MYSQL_CONNECTION1 = "MySQLConnection1";
        public const string MYSQL_CONNECTION2 = "MySQLConnection2";
    }
}

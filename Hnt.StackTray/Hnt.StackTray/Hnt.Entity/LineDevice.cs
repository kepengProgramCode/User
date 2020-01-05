using Hnt.PlcListener;

namespace Hnt.Entity
{
    /// <summary>
    /// 线体
    /// </summary>
    public class LineDevice
    {
        /// <summary>
        /// 表前缀
        /// </summary>
        public string PrefixTable;
        /// <summary>
        /// 扫码枪IP
        /// </summary>
        public string QRCodeReaderIP;
        /// <summary>
        /// 扫码枪IP
        /// </summary>
        public string QRCodeReaderModel;
        /// <summary>
        /// 扫码地址
        /// </summary>
        public PLCAddress trayArrivedAddr;
        /// <summary>
        /// 扫码反馈地址
        /// </summary>
        public PLCAddress scanCodeFeedbackAddr;
        /// <summary>
        /// 异常信息地址
        /// </summary>
        public PLCAddress scanErrorCodeAddr;
        /// <summary>
        /// 请求数据绑定地址
        /// </summary>
        public PLCAddress requestBindDataAddr;
        /// <summary>
        /// 托盘数量地址
        /// </summary>
        public PLCAddress trayCountAddr;
        /// <summary>
        /// 托盘数据处理结果
        /// </summary>
        public PLCAddress bindDataResultAddr;
    }
}

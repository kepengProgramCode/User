using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hnt.Business.Common
{
    public class ConfigSetting
    {
        /// <summary>
        /// 设置config
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SetAppSetting(string key, string value)
        {
            var _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (!_config.HasFile)
            {
                throw new ArgumentException("程序配置文件缺失！");
            }
            KeyValueConfigurationElement _key = _config.AppSettings.Settings[key];
            if (_key == null)
                _config.AppSettings.Settings.Add(key, value);
            else
                _config.AppSettings.Settings[key].Value = value;
            _config.Save(ConfigurationSaveMode.Modified);
            return true;
        }
    }
}

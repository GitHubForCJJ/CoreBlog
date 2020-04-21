using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Basedata
{
    public static class ConfigHelper
    {
        public static string GetConfToString(this IConfiguration config string key)
        {
            try
            {
                return ConfigurationManager.AppSettings[key]?.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }
        public static int GetConfToInt(string key)
        {
            try
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings[key].ToString());
            }
            catch
            {
                return 0;
            }
        }
        public static bool GetConfToBool(string key)
        {
            try
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings[key].ToString());
            }
            catch
            {
                return false;
            }
        }
    }
}

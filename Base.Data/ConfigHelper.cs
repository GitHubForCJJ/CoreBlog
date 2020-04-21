using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Basedata
{
    public static class ConfigHelper
    {
        public static string GetConfToString(this IConfiguration config, string key)
        {
            try
            {
                return config.GetConfToString(key);
            }
            catch
            {
                return string.Empty;
            }
        }
        public static int GetConfToInt(this IConfiguration config,string key)
        {
            try
            {
                return Convert.ToInt32(config.GetConfToString(key));
            }
            catch
            {
                return 0;
            }
        }
        public static bool GetConfToBool(this IConfiguration config,string key)
        {
            try
            {
                return Convert.ToBoolean(config.GetConfToString(key));
            }
            catch
            {
                return false;
            }
        }
    }
}

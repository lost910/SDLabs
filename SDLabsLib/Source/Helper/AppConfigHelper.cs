using System;
using System.Configuration;

namespace SDLabsLib.Source.Helper
{
    public class AppConfigHelper
    {
        public string AppSettings(string name)
        {
            return ConfigurationManager.AppSettings[name] != null ?
                ConfigurationManager.AppSettings[name].ToString() : String.Empty;
        }
    }
}

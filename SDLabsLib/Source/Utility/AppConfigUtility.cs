using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SDLabsLib.Source.Utility
{
    public class AppConfigUtility
    {
        public string AppSettings(string name)
        {
            return ConfigurationManager.AppSettings[name] != null ?
                ConfigurationManager.AppSettings[name].ToString() : String.Empty;
        }
    }
}

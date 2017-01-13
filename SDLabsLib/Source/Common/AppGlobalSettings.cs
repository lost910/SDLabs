using SDLabsLib.Source.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SDLabsLib
{
    public static class AppGlobalSettings
    {
        public static string LogPath { get; private set; }
        public static string DataFileName { get; private set; }
        public static bool TestMode { get; private set; }

        public static void Init()
        {
            AppConfigUtility conf = new AppConfigUtility();
            LogPath = conf.AppSettings("logPath");
            TestMode = Boolean.Parse(conf.AppSettings("TestMode"));
            DataFileName = Application.StartupPath.ToString() + '\\' + conf.AppSettings("dataFileName");
        }
    }
}

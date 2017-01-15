using SDLabsLib.Source.Helper;
using System;
using System.Windows.Forms;


namespace SDLabsLib.Source.Common
{
    public static class AppGlobalSettings
    {
        public static string LogPath { get; private set; }
        public static string DataFileName { get; private set; }
        public static bool TestMode { get; private set; }

        public static void Init()
        {
            AppConfigHelper conf = new AppConfigHelper();
            LogPath = conf.AppSettings("logPath");
            TestMode = Boolean.Parse(conf.AppSettings("TestMode"));
            DataFileName = Application.StartupPath.ToString() + '\\' + conf.AppSettings("dataFileName");
        }
    }
}

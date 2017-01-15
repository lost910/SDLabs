using SDLabsLib.Source.Common;
using System;
using System.IO;

namespace SDLabsLib.Source.Helper
{
    public static class LogHelper
    {
        public static void ErrorLog(string message)
        {
            File.AppendAllText(
                AppGlobalSettings.LogPath, 
                $"{DateTime.Now} : {message} {Environment.NewLine}"
                );
        }
    }
}

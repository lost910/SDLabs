﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SDLabsMain
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SDLabsLib.Source.Common.AppGlobalSettings.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}

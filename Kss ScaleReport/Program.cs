﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kss_ScaleReport
{
    static class Program
    {
        internal static object ScaleReport_Config;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}

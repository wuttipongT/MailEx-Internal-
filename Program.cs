using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //AutoUpdater.ShowSkipButton = false;
            //AutoUpdater.Synchronous = true;
            //AutoUpdater.Mandatory = true;
            //AutoUpdater.UpdateMode = Mode.Forced;
           // AutoUpdater.Start("ftp://ITMAINTAIN:123456@172.20.10.105/AutoupdateService.xml");

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

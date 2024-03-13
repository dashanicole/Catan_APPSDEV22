using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking_System_Application.controller;
using Parking_System_Application.view;

namespace Parking_System_Application
{
    internal static class driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PSDashboard());
            new PSDashboardCntlr();
        }
    }
}

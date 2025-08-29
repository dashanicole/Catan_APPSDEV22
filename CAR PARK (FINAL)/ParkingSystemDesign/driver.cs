using System.Net.Http.Headers;
using ParkingSystemDesign.view;
using ParkingSystemDesign.controller;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace ParkingSystemDesign
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            DatabaseManager.initDB("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkSys;Integrated Security=True;");
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }
    }
}
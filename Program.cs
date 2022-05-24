using IT_ORG_SQLite_RGR_2022.Database;
using IT_ORG_SQLite_RGR_2022.Database.Base;
using IT_ORG_SQLite_RGR_2022.Database.Models;
using IT_ORG_SQLite_RGR_2022.Services;
using IT_ORG_SQLite_RGR_2022.Services.Interfaces;
using IT_ORG_SQLite_RGR_2022.Controllers;

using IT_ORG_SQLite_RGR_2022.Views;

namespace IT_ORG_SQLite_RGR_2022
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SettingsDatabase settingsDb = new SettingsDatabase();

            using (_ContextDb db = new _ContextDb(settingsDb.GetDbContextOptions()))
            {
                DBInit dBIni = new DBInit(db);
                dBIni.DefaultGeneration();
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm());
        }
    }
}
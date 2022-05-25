using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite;
using IT_ORG_SQLite_RGR_2022.Services;
using IT_ORG_SQLite_RGR_2022.Database;
using IT_ORG_SQLite_RGR_2022.Database.Models;
using IT_ORG_SQLite_RGR_2022.Controllers;
using IT_ORG_SQLite_RGR_2022.Views;
using IT_ORG_SQLite_RGR_2022.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using IT_ORG_SQLite_RGR_2022.Services;

namespace IT_ORG_SQLite_RGR_2022.Services
{
    public class SettingsDatabase : ISettingsDatabase
    {
        CustomExceptions ex = new CustomExceptions();

        public void Dispose()
        {
        }

        // Объект настройки БД
        public DbContextOptions<_ContextDb> GetDbContextOptions()
        {            
            try
            {
                var builder = new ConfigurationBuilder();
                // установка пути к текущему каталогу
                builder.SetBasePath(Directory.GetCurrentDirectory());
                // получаем конфигурацию из файла appsettings.json
                builder.AddJsonFile("Config\\appsettings.json");
                // создаем конфигурацию
                var config = builder.Build();
                // получаем строку подключения
                string connectionString = config.GetConnectionString("DefaultConnection");

                var optionsBuilder = new DbContextOptionsBuilder<_ContextDb>();
                var options = optionsBuilder.UseSqlite(connectionString).Options;
                return options;

            }
            catch(Exception e)
            {
                ex.ThrowNewException("BD SETTINGS ERROR","The path in config file is unreachible or config file is not exist...");
            }
            return null;
        }



        public bool BackupSQLiteDbToDesktop()
        {
            bool result = false;

            try
            {
                string pathToFileDb = this.GetDbPathTofile().ToString().Split('=')[1];

                string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string guidCode = Guid.NewGuid().ToString();
                string shortDate = DateTime.Now.ToShortDateString();

                StringBuilder folderPath = new StringBuilder();
                folderPath.Append(pathDesktop + "\\" + "sqlite_window_world" + "_" + shortDate.Replace('.', '-') + "_" + guidCode);

                if (!Directory.Exists(folderPath.ToString()))
                {
                    Directory.CreateDirectory(folderPath.ToString());
                    // Пути
                    string oldPathFiles = pathToFileDb;
                    string newPathFile = folderPath.ToString();

                    FileInfo fileInfo = new FileInfo(oldPathFiles);
                    if (fileInfo.Exists)
                    {
                        fileInfo.CopyTo(newPathFile + "\\" + "sqlite_window_world.db");
                    }

                    result = true;
                }
            }
            catch(Exception e)
            {
                ex.ThrowNewException("BACKUP ERROR","There is a kind of error on backup...");
                return false;
            }

            return result;
        }

        public string GetDbPathTofile()
        {
            try
            {
                var builder = new ConfigurationBuilder();
                // установка пути к текущему каталогу
                builder.SetBasePath(Directory.GetCurrentDirectory());
                // получаем конфигурацию из файла appsettings.json
                builder.AddJsonFile("Config\\appsettings.json");
                // создаем конфигурацию
                var config = builder.Build();
                // получаем строку подключения
                string connectionString = config.GetConnectionString("DefaultConnection");
                //MessageBox.Show(connectionString);
                return connectionString;
            }
            catch(Exception e)
            {
                ex.ThrowNewException("DB PATH ERROR","Path of database is unreachible or database is not exist...");
            }
            return null;
        }
    }
}
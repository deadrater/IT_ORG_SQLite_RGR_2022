using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using IT_ORG_SQLite_RGR_2022.Database;

namespace IT_ORG_SQLite_RGR_2022.Services.Interfaces
{
    internal interface ISettingsDatabase : IDisposable
    {
        bool BackupSQLiteDbToDesktop();
        DbContextOptions<_ContextDb> GetDbContextOptions();
        string GetDbPathTofile();
    }
}
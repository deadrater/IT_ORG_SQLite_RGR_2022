using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_ORG_SQLite_RGR_2022.Database;
using IT_ORG_SQLite_RGR_2022.Database.Models;
using IT_ORG_SQLite_RGR_2022.Services;
using Microsoft.EntityFrameworkCore;

namespace IT_ORG_SQLite_RGR_2022.Controllers
{
    /// <summary>
    /// Контроллер авторизации
    /// </summary>
    public class AuthController
    {
        private SettingsDatabase settingsDatabase = new SettingsDatabase();

        public User AuthToApp(string _username, string _password)
        {
            User user = null;

            try
            {
                //Проверка связки логин-пароль
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    var res = db.Users.FirstOrDefault(x => x.UserName == _username && x.Password == _password);
                    if (res != null) user = res;
                }
            }
            catch
            {
                return null;
            }

            return user;
        }

        public bool UpdateUserPassword(User obj, string _newPass)
        {
            bool result = false;
            try
            {
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if (db.Users.Any(u => u.Id == obj.Id))
                    {
                        obj.Password = _newPass;
                        db.Users.Update(obj);
                        db.SaveChanges();
                        result = true;
                    }
                }
            }
            catch
            {
                return false;
            }

            return result;
        }
    }
}
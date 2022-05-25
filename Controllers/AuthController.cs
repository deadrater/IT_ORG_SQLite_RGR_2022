using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public bool UpdateUserImage(User obj, string _imgUrl)
        {
            bool result = false;
            try
            {
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if(db.Users.Any(u => u.Id == obj.Id))
                    {
                        if(obj.UserName == "admin" || obj.UserName == "user1" || obj.UserName == "user2")
                        {
                            obj.Password = ComputeSha256Hash(obj.Password);
                            obj.ImgUrl = _imgUrl;
                            db.Users.Update(obj);
                            db.SaveChanges();
                            result = true;
                        }
                        else
                        {
                            obj.ImgUrl = _imgUrl;
                            db.Users.Update(obj);
                            db.SaveChanges();
                            result = true;
                        }  
                    }
                }
            }
            catch
            {
                return false;
            }
            return result;
        }

        public bool DeleteUserImage(User obj)
        {
            bool result = false;
            try
            {
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if (db.Users.Any(u => u.Id == obj.Id))
                    {
                        if (obj.UserName == "admin" || obj.UserName == "user1" || obj.UserName == "user2")
                        {
                            obj.Password = ComputeSha256Hash(obj.Password);
                            obj.ImgUrl = String.Empty;
                            db.Users.Update(obj);
                            db.SaveChanges();
                            result = true;
                        }
                        else
                        {
                            obj.ImgUrl = String.Empty;
                            db.Users.Update(obj);
                            db.SaveChanges();
                            result = true;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return result;
        }

        public string ComputeSha256Hash(string s)
        {
            try
            {
                // Create a SHA256   
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    // ComputeHash - returns byte array  
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(s));

                    // Convert byte array to a string   
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (Exception e)
            {
                //ex.ThrowNewException(e);
                return null;
            }
        }
    }
}
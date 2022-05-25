using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT_ORG_SQLite_RGR_2022.Services;
using IT_ORG_SQLite_RGR_2022.Database;
using IT_ORG_SQLite_RGR_2022.Database.Models;
using IT_ORG_SQLite_RGR_2022.Controllers;
using IT_ORG_SQLite_RGR_2022.Views;
using System.Security.Cryptography;

namespace IT_ORG_SQLite_RGR_2022.Views
{
    public partial class NewPassForm : Form
    {
        User mUser = null;
        AuthController authCTRL = null;
        CustomExceptions ex = new CustomExceptions();
        public string local = "EN";

        public NewPassForm(User _user, string _local)
        {
            mUser = _user;
            authCTRL = new AuthController();
            local = _local;
            InitializeComponent();
        }

        private void NewPassForm_Load(object sender, EventArgs e)
        {
            switch (local)
            {
                case "EN":
                    LocalEng();
                    break;
                case "RU":
                    LocalRus();
                    break;
            }
        }

        public void LocalEng()
        {
            changingPassTitleBox.Text = "CHANGING PASSWORD";
            oldPassLbl.Text = "Old password:";
            newPassLbl.Text = "New password:";
            changePassBtn.Text = "CHANGE PASSWORD";
            local = "EN";
        }

        public void LocalRus()
        {
            changingPassTitleBox.Text = "СМЕНА ПАРОЛЯ";
            oldPassLbl.Text = "Старый пароль:";
            newPassLbl.Text = "Новый пароль:";
            changePassBtn.Text = "СМЕНИТЬ ПАРОЛЬ";
            local = "RU";
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

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (oldPassBox.Text != String.Empty)
                {
                    if (NewPassBox.Text != String.Empty)
                    {
                        if (mUser.Password == oldPassBox.Text)
                        {
                            if (authCTRL.UpdateUserPassword(mUser, ComputeSha256Hash(NewPassBox.Text)))
                            {
                                ex.ThrowNewException("SUCCESS", $"User \"{mUser.UserName}\" password was updated successfully...");
                                oldPassBox.Text = String.Empty;
                                NewPassBox.Text = String.Empty;
                                oldPassBox.Select();
                                this.Close();
                            }
                            else
                                ex.ThrowNewException("DB WRITE ERROR", $"User \"{mUser.UserName}\" password was not updated!");
                        }
                        else
                            ex.ThrowNewException("AUTH ERROR", "Passwords are not match!");
                    }
                    else
                        ex.ThrowNewException("INPUT ERROR", "The password can not be empty!");
                }
                else
                    ex.ThrowNewException("INPUT ERROR", "The password can not be empty!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

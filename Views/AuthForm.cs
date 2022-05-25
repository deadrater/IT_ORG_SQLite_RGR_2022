using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT_ORG_SQLite_RGR_2022.Controllers;
using IT_ORG_SQLite_RGR_2022.Services;
using IT_ORG_SQLite_RGR_2022.Database;
using IT_ORG_SQLite_RGR_2022.Database.Base;
using IT_ORG_SQLite_RGR_2022.Database.Models;
using System.Security.Cryptography;

namespace IT_ORG_SQLite_RGR_2022.Views
{
    public partial class AuthForm : Form
    {
        AuthController authController;
        readonly EncryptionService crySer;
        CustomExceptions ex = new CustomExceptions();

        public AuthForm(bool _result = true)
        {
            authController = new AuthController();
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userBox.Text != String.Empty)
                {
                    if (passBox.Text != String.Empty)
                    {
                        User myUser = authController.AuthToApp(ComputeSha256Hash(userBox.Text), ComputeSha256Hash(passBox.Text));
                        if (myUser != null)
                        {
                            myUser.Password = passBox.Text;
                            this.Hide();
                            MainWindow mainWindow = new MainWindow(myUser, this);
                            mainWindow.Show();
                            userBox.Text = String.Empty;
                            passBox.Text = String.Empty;
                            userBox.Select();
                        }
                        else
                        {
                            ex.ThrowNewException("LOGIN ERROR","Username/Password incorrect!");
                        }
                    }
                    else
                    {
                        ex.ThrowNewException("INPUT ERROR","The password can not be empty!");
                    }
                }
                else
                {
                    ex.ThrowNewException("INPUT ERROR", "The username can not be empty!");
                }
            }
            catch(Exception _e)
            {
                throw _e;
            }
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
            catch(Exception e)
            {
                //ex.ThrowNewException(e);
                return null;
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

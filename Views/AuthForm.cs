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

        public AuthForm()
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
                        User myUser = authController.AuthToApp(userBox.Text, ComputeSha256Hash(passBox.Text));
                        if (myUser != null)
                        {
                            myUser.Password = crySer.ComputeSha256Hash(passBox.Text);
                            this.Hide();
                            MainWindow mainWindow = new MainWindow(myUser, this);
                            mainWindow.Show();
                        }
                        else { MessageBox.Show("Username/Password incorrect!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            userBox.Text = ComputeSha256Hash(userBox.Text);
                            passBox.Text = ComputeSha256Hash(passBox.Text);
                        }
                    }
                    else MessageBox.Show("Password is empty!","Input Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Username is empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ComputeSha256Hash(string s)
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

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
    }
}

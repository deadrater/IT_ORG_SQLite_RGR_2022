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
    public partial class ChangeImageForm : Form
    {
        User mUser = null;
        AuthController authCTRL = null;
        CustomExceptions ex = new CustomExceptions();
        public string local = "EN";

        public ChangeImageForm(User _user, string _local)
        {
            mUser = _user;
            authCTRL = new AuthController();
            local = _local;
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeImgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgUrlBox.Text != String.Empty)
                {
                    if (authCTRL.UpdateUserImage(mUser, imgUrlBox.Text))
                    {
                        ex.ThrowNewException("SUCCESS", $"User \"{mUser.UserName}\" image was updated successfully...");
                        imgUrlBox.Text = String.Empty;
                        this.Close();
                    }
                    else
                        ex.ThrowNewException("DB WRITE ERROR", $"User \"{mUser.UserName}\" image was not updated!");
                }
                else
                    ex.ThrowNewException("INPUT ERROR", "The image url can not be empty!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeImageForm_Load(object sender, EventArgs e)
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

        public void LocalRus()
        {
            changeAvatarTitleBox.Text = "IT ORG СМЕНА ИЗОБРАЖЕНИЯ ПРОФИЛЯ";
            imgUrlLbl.Text = "URL изображения:";
            changeImgBtn.Text = "ИЗМЕНИТЬ ИЗОБРАЖЕНИЕ";
        }

        public void LocalEng()
        {
            changeAvatarTitleBox.Text = "IT ORG ";
            imgUrlLbl.Text = "Image URL:";
            changeImgBtn.Text = "CHANGE AVATAR IMAGE";
        }
    }
}

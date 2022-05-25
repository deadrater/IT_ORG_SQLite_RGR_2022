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
/*using IT_ORG_SQLite_RGR_2022.Views.Profile;
using IT_ORG_SQLite_RGR_2022.Views.PetrolStationTypeView;
using IT_ORG_SQLite_RGR_2022.Views.PetrolStationView;
using IT_ORG_SQLite_RGR_2022.Views.EmployeesView;
using IT_ORG_SQLite_RGR_2022.Views.EquipmentView;
using IT_ORG_SQLite_RGR_2022.Views.MaterialLiabilityView;
using IT_ORG_SQLite_RGR_2022.Views.StructureView;
using IT_ORG_SQLite_RGR_2022.Views.ExportToWordView;*/

namespace IT_ORG_SQLite_RGR_2022
{
    public partial class MainWindow : Form
    {
        User mUser = null;
        AuthForm aForm = null;
        AuthController authCTRL = null;
        CustomExceptions ex = new CustomExceptions();
        public string local = "EN";


        public MainWindow(User _user, AuthForm _form)
        {
            mUser = _user;
            authCTRL = new AuthController();
            aForm = _form;
            InitializeComponent();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            aForm.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (mUser.Role != "admin")
            {
                removeImgBtn.Enabled = false;
                backupBtn.Enabled = false;
                LocalRus();
            }
            try
            {
                avatarBox.Load(mUser.ImgUrl);
            }
            catch
            {
                avatarBox.Load("https://avatars.mds.yandex.net/i?id=9ad356afdd27291e58a9e909bc2cb0d3-5877629-images-thumbs&ref=rim&n=33&w=188&h=188");
            }
            userBox.Text = mUser.UserName;
            passBox.Text = mUser.Password;
            roleBox.Text = mUser.Role;
            timer1.Start();
        }

        public void LocalRus()
        {
            Font font = new Font("Segoe UI", 10, FontStyle.Bold);
            localImg.Load("https://i.ibb.co/9hLvdr7/russia.png");
            menuGroupBox.Text = "ÃÂÌ˛";
            profileGroupBox.Text = "œÓÙËÎ¸";
            userLbl.Text = "œÓÎ¸ÁÓ‚‡ÚÂÎ¸:";
            passLbl.Text = "œ‡ÓÎ¸:";
            roleLbl.Text = "–ÓÎ¸";
            logOutBtn.Text = "¬€’Œƒ";
            changeImgBtn.Text = "—Ã≈Õ»“‹  ¿–“»Õ ”";
            changeImgBtn.Font = font;
            removeImgBtn.Text = "”ƒ¿À»“‹  ¿–“»Õ ”";
            removeImgBtn.Font = font;
            backupBtn.Text = "¡› ¿œ";
            changePassBtn.Text = "—Ã≈Õ»“‹ œ¿–ŒÀ‹";
            changePassBtn.Font = font;
            local = "RU";
        }

        public void LocalEng()
        {
            Font font = new Font("Segoe UI", 14, FontStyle.Bold);
            localImg.Load("https://i.ibb.co/5LKbj7m/united-states.png");
            menuGroupBox.Text = "Menu";
            profileGroupBox.Text = "Profile";
            userLbl.Text = "Username:";
            passLbl.Text = "Password:";
            roleLbl.Text = "Role";
            logOutBtn.Text = "LOG-OUT";
            changeImgBtn.Text = "CHANGE IMG";
            changeImgBtn.Font = font;
            removeImgBtn.Text = "REMOVE IMG";
            removeImgBtn.Font = font;
            backupBtn.Text = "BACKUP";
            changePassBtn.Text = "CHANGE PASS";
            changePassBtn.Font = font;
            local = "EN";
        }

        private void localBtn_Click(object sender, EventArgs e)
        {
            switch (localImg.ImageLocation)
            {
                case "RU":
                    LocalEng();
                    break;
                case "EN":
                    LocalRus();
                    break;
            }
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            NewPassForm newPassForm = new NewPassForm(mUser, local);
            newPassForm.Show();
        }

        private void changeImgBtn_Click(object sender, EventArgs e)
        {
            ChangeImageForm changeImageForm = new ChangeImageForm(mUser, local);
            changeImageForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                avatarBox.Load(mUser.ImgUrl);
            }
            catch
            {
                avatarBox.Load("https://avatars.mds.yandex.net/i?id=9ad356afdd27291e58a9e909bc2cb0d3-5877629-images-thumbs&ref=rim&n=33&w=188&h=188");
            }
            userBox.Text = mUser.UserName;
            passBox.Text = mUser.Password;
            roleBox.Text = mUser.Role;
        }

        private void removeImgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                    if (authCTRL.DeleteUserImage(mUser)) 
                        ex.ThrowNewException("SUCCESS", $"User \"{mUser.UserName}\" image was deleted successfully...");                    
                    else
                        ex.ThrowNewException("DB WRITE ERROR", $"User \"{mUser.UserName}\" image was not deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsDatabase settingsDatabase = new SettingsDatabase();
                settingsDatabase.BackupSQLiteDbToDesktop();
                ex.ThrowNewException("SUCCESS","DataBase backup created succsessfully...");
            }
            catch
            {
                ex.ThrowNewException("BACKUP ERROR","DataBase backup is not created!");
            }
        }
    }
}
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
        CustomExceptions ex = new CustomExceptions();
        public string local = "EN";


        public MainWindow(User _user, AuthForm _form)
        {
            mUser = _user;
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
                addUserBtn.Enabled = false;
                deleteUserBtn.Enabled = false;
                backupBtn.Enabled = false;
                LocalRus();
            }
            avatarBox.Load(mUser.ImgUrl);
        }

        public void LocalRus()
        {
            Font font = new Font("Segoe UI", 10, FontStyle.Bold);
            localBtn.Text = "EN";
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
            addUserBtn.Text = "ƒŒ¡¿¬»“‹ œŒÀ‹«Œ¬¿“≈Àﬂ";
            addUserBtn.Font = font;
            deleteUserBtn.Text = "”ƒ¿À»“‹ œŒÀ‹«Œ¬¿“≈Àﬂ";
            deleteUserBtn.Font = font;
            backupBtn.Text = "¡› ¿œ";
            changePassBtn.Text = "—Ã≈Õ»“‹ œ¿–ŒÀ‹";
            changePassBtn.Font = font;
            local = "RU";
        }

        public void LocalEng()
        {
            Font font = new Font("Segoe UI", 14, FontStyle.Bold);
            localBtn.Text = "RU";
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
            addUserBtn.Text = "ADD USER";
            addUserBtn.Font = font;
            deleteUserBtn.Text = "DELETE USER";
            deleteUserBtn.Font = font;
            backupBtn.Text = "BACKUP";
            changePassBtn.Text = "CHANGE PASS";
            changePassBtn.Font = font;
            local = "EN";
        }

        private void localBtn_Click(object sender, EventArgs e)
        {
            switch (local)
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
    }
}
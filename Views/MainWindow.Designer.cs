namespace IT_ORG_SQLite_RGR_2022
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainWindowTitleBox = new System.Windows.Forms.TextBox();
            this.minimizeBtn = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.profileGroupBox = new System.Windows.Forms.GroupBox();
            this.localImg = new System.Windows.Forms.PictureBox();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.backupBtn = new System.Windows.Forms.Button();
            this.changeImgBtn = new System.Windows.Forms.Button();
            this.removeImgBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.roleLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.profileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.groupBox1.Controls.Add(this.mainWindowTitleBox);
            this.groupBox1.Controls.Add(this.minimizeBtn);
            this.groupBox1.Controls.Add(this.closeBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(-10, -41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1424, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // mainWindowTitleBox
            // 
            this.mainWindowTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.mainWindowTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainWindowTitleBox.Enabled = false;
            this.mainWindowTitleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.mainWindowTitleBox.HideSelection = false;
            this.mainWindowTitleBox.Location = new System.Drawing.Point(22, 45);
            this.mainWindowTitleBox.Name = "mainWindowTitleBox";
            this.mainWindowTitleBox.ReadOnly = true;
            this.mainWindowTitleBox.Size = new System.Drawing.Size(1329, 31);
            this.mainWindowTitleBox.TabIndex = 8;
            this.mainWindowTitleBox.TabStop = false;
            this.mainWindowTitleBox.Text = "IT ORG";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.AutoSize = true;
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.minimizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.minimizeBtn.Location = new System.Drawing.Point(1352, 50);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(26, 31);
            this.minimizeBtn.TabIndex = 6;
            this.minimizeBtn.Text = "–";
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.closeBtn.Location = new System.Drawing.Point(1372, 45);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 31);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.menuGroupBox.Location = new System.Drawing.Point(12, 63);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(738, 623);
            this.menuGroupBox.TabIndex = 7;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Menu";
            // 
            // profileGroupBox
            // 
            this.profileGroupBox.Controls.Add(this.localImg);
            this.profileGroupBox.Controls.Add(this.roleBox);
            this.profileGroupBox.Controls.Add(this.passBox);
            this.profileGroupBox.Controls.Add(this.userBox);
            this.profileGroupBox.Controls.Add(this.changePassBtn);
            this.profileGroupBox.Controls.Add(this.backupBtn);
            this.profileGroupBox.Controls.Add(this.changeImgBtn);
            this.profileGroupBox.Controls.Add(this.removeImgBtn);
            this.profileGroupBox.Controls.Add(this.logOutBtn);
            this.profileGroupBox.Controls.Add(this.roleLbl);
            this.profileGroupBox.Controls.Add(this.passLbl);
            this.profileGroupBox.Controls.Add(this.userLbl);
            this.profileGroupBox.Controls.Add(this.avatarBox);
            this.profileGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.profileGroupBox.Location = new System.Drawing.Point(756, 63);
            this.profileGroupBox.Name = "profileGroupBox";
            this.profileGroupBox.Size = new System.Drawing.Size(635, 623);
            this.profileGroupBox.TabIndex = 8;
            this.profileGroupBox.TabStop = false;
            this.profileGroupBox.Text = "Profile";
            // 
            // localImg
            // 
            this.localImg.ImageLocation = "https://i.ibb.co/9hLvdr7/russia.png";
            this.localImg.Location = new System.Drawing.Point(581, 20);
            this.localImg.Name = "localImg";
            this.localImg.Size = new System.Drawing.Size(31, 32);
            this.localImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.localImg.TabIndex = 14;
            this.localImg.TabStop = false;
            this.localImg.Click += new System.EventHandler(this.localBtn_Click);
            // 
            // roleBox
            // 
            this.roleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.roleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roleBox.Enabled = false;
            this.roleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.roleBox.Location = new System.Drawing.Point(198, 564);
            this.roleBox.Name = "roleBox";
            this.roleBox.ReadOnly = true;
            this.roleBox.Size = new System.Drawing.Size(414, 31);
            this.roleBox.TabIndex = 13;
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Enabled = false;
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.passBox.Location = new System.Drawing.Point(198, 516);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(414, 31);
            this.passBox.TabIndex = 12;
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userBox.Enabled = false;
            this.userBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.userBox.Location = new System.Drawing.Point(198, 470);
            this.userBox.Name = "userBox";
            this.userBox.ReadOnly = true;
            this.userBox.Size = new System.Drawing.Size(414, 31);
            this.userBox.TabIndex = 11;
            // 
            // changePassBtn
            // 
            this.changePassBtn.Location = new System.Drawing.Point(381, 348);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(231, 63);
            this.changePassBtn.TabIndex = 10;
            this.changePassBtn.Text = "CHANGE PASS";
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(381, 281);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(231, 63);
            this.backupBtn.TabIndex = 9;
            this.backupBtn.Text = "BACKUP";
            this.backupBtn.UseVisualStyleBackColor = true;
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // changeImgBtn
            // 
            this.changeImgBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeImgBtn.Location = new System.Drawing.Point(381, 143);
            this.changeImgBtn.Name = "changeImgBtn";
            this.changeImgBtn.Size = new System.Drawing.Size(231, 63);
            this.changeImgBtn.TabIndex = 6;
            this.changeImgBtn.Text = "CHANGE IMG";
            this.changeImgBtn.UseVisualStyleBackColor = true;
            this.changeImgBtn.Click += new System.EventHandler(this.changeImgBtn_Click);
            // 
            // removeImgBtn
            // 
            this.removeImgBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeImgBtn.Location = new System.Drawing.Point(381, 212);
            this.removeImgBtn.Name = "removeImgBtn";
            this.removeImgBtn.Size = new System.Drawing.Size(231, 63);
            this.removeImgBtn.TabIndex = 5;
            this.removeImgBtn.Text = "REMOVE IMG";
            this.removeImgBtn.UseVisualStyleBackColor = true;
            this.removeImgBtn.Click += new System.EventHandler(this.removeImgBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutBtn.Location = new System.Drawing.Point(381, 74);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(231, 63);
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.Text = "LOG-OUT";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Location = new System.Drawing.Point(21, 567);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(67, 31);
            this.roleLbl.TabIndex = 3;
            this.roleLbl.Text = "Role:";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(21, 519);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(120, 31);
            this.passLbl.TabIndex = 2;
            this.passLbl.Text = "Password:";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(21, 473);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(127, 31);
            this.userLbl.TabIndex = 1;
            this.userLbl.Text = "Username:";
            // 
            // avatarBox
            // 
            this.avatarBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarBox.ImageLocation = "https://sun1.userapi.com/sun1-54/s/v1/ig2/Am3vQrLyOwlyKQMdkRVLzo5_SC3U67W1i7yqhlB" +
    "WLFdjGeqFIbW-9Wtz5Tti08Bm_-2JL0g7EAMkXSnJ-IxdAPFC.jpg?size=200x200&quality=95&cr" +
    "op=187,170,953,953&ava=1";
            this.avatarBox.Location = new System.Drawing.Point(21, 74);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(336, 337);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 0;
            this.avatarBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1400, 698);
            this.Controls.Add(this.profileGroupBox);
            this.Controls.Add(this.menuGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.profileGroupBox.ResumeLayout(false);
            this.profileGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label minimizeBtn;
        private Label closeBtn;
        private TextBox mainWindowTitleBox;
        private GroupBox menuGroupBox;
        private GroupBox profileGroupBox;
        private TextBox roleBox;
        private TextBox passBox;
        private TextBox userBox;
        private Button changePassBtn;
        private Button backupBtn;
        private Button changeImgBtn;
        private Button logOutBtn;
        private Label roleLbl;
        private Label passLbl;
        private Label userLbl;
        private PictureBox avatarBox;
        private System.Windows.Forms.Timer timer1;
        private Button removeImgBtn;
        private PictureBox localImg;
    }
}
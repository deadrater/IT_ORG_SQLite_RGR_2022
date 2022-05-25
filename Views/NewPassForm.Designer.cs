namespace IT_ORG_SQLite_RGR_2022.Views
{
    partial class NewPassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.changePassBtn = new System.Windows.Forms.Button();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changingPassTitleBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.oldPassBox = new System.Windows.Forms.TextBox();
            this.oldPassLbl = new System.Windows.Forms.Label();
            this.newPassLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // changePassBtn
            // 
            this.changePassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.changePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changePassBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.changePassBtn.Location = new System.Drawing.Point(98, 156);
            this.changePassBtn.Margin = new System.Windows.Forms.Padding(5);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(308, 50);
            this.changePassBtn.TabIndex = 8;
            this.changePassBtn.Text = "CHANGE PASSWORD";
            this.changePassBtn.UseVisualStyleBackColor = false;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // NewPassBox
            // 
            this.NewPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.NewPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPassBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.NewPassBox.Location = new System.Drawing.Point(219, 112);
            this.NewPassBox.Margin = new System.Windows.Forms.Padding(5);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(288, 31);
            this.NewPassBox.TabIndex = 7;
            this.NewPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewPassBox.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.groupBox1.Controls.Add(this.changingPassTitleBox);
            this.groupBox1.Controls.Add(this.closeBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(-23, -35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 86);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // changingPassTitleBox
            // 
            this.changingPassTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.changingPassTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changingPassTitleBox.Enabled = false;
            this.changingPassTitleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.changingPassTitleBox.HideSelection = false;
            this.changingPassTitleBox.Location = new System.Drawing.Point(30, 49);
            this.changingPassTitleBox.Name = "changingPassTitleBox";
            this.changingPassTitleBox.ReadOnly = true;
            this.changingPassTitleBox.Size = new System.Drawing.Size(371, 31);
            this.changingPassTitleBox.TabIndex = 9;
            this.changingPassTitleBox.TabStop = false;
            this.changingPassTitleBox.Text = "CHANGING PASSWORD";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.closeBtn.Location = new System.Drawing.Point(501, 44);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 31);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // oldPassBox
            // 
            this.oldPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.oldPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldPassBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.oldPassBox.Location = new System.Drawing.Point(219, 71);
            this.oldPassBox.Margin = new System.Windows.Forms.Padding(5);
            this.oldPassBox.Name = "oldPassBox";
            this.oldPassBox.Size = new System.Drawing.Size(288, 31);
            this.oldPassBox.TabIndex = 6;
            this.oldPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldPassBox.UseSystemPasswordChar = true;
            // 
            // oldPassLbl
            // 
            this.oldPassLbl.AutoSize = true;
            this.oldPassLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.oldPassLbl.Location = new System.Drawing.Point(12, 71);
            this.oldPassLbl.Name = "oldPassLbl";
            this.oldPassLbl.Size = new System.Drawing.Size(164, 31);
            this.oldPassLbl.TabIndex = 12;
            this.oldPassLbl.Text = "Old Password:";
            // 
            // newPassLbl
            // 
            this.newPassLbl.AutoSize = true;
            this.newPassLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.newPassLbl.Location = new System.Drawing.Point(12, 112);
            this.newPassLbl.Name = "newPassLbl";
            this.newPassLbl.Size = new System.Drawing.Size(174, 31);
            this.newPassLbl.TabIndex = 13;
            this.newPassLbl.Text = "New Password:";
            // 
            // NewPassForm
            // 
            this.AcceptButton = this.changePassBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(525, 220);
            this.Controls.Add(this.newPassLbl);
            this.Controls.Add(this.oldPassLbl);
            this.Controls.Add(this.changePassBtn);
            this.Controls.Add(this.NewPassBox);
            this.Controls.Add(this.oldPassBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPassForm";
            this.Load += new System.EventHandler(this.NewPassForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button changePassBtn;
        private TextBox NewPassBox;
        private GroupBox groupBox1;
        private TextBox changingPassTitleBox;
        private Label closeBtn;
        private TextBox oldPassBox;
        private Label oldPassLbl;
        private Label newPassLbl;
    }
}
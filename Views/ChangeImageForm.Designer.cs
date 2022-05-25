namespace IT_ORG_SQLite_RGR_2022.Views
{
    partial class ChangeImageForm
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
            this.changeImgBtn = new System.Windows.Forms.Button();
            this.imgUrlBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changeAvatarTitleBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.imgUrlLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeImgBtn
            // 
            this.changeImgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.changeImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeImgBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeImgBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.changeImgBtn.Location = new System.Drawing.Point(34, 163);
            this.changeImgBtn.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.changeImgBtn.Name = "changeImgBtn";
            this.changeImgBtn.Size = new System.Drawing.Size(926, 78);
            this.changeImgBtn.TabIndex = 8;
            this.changeImgBtn.Text = "CHANGE IMAGE";
            this.changeImgBtn.UseVisualStyleBackColor = false;
            this.changeImgBtn.Click += new System.EventHandler(this.changeImgBtn_Click);
            // 
            // imgUrlBox
            // 
            this.imgUrlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.imgUrlBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imgUrlBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.imgUrlBox.Location = new System.Drawing.Point(208, 116);
            this.imgUrlBox.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.imgUrlBox.Name = "imgUrlBox";
            this.imgUrlBox.Size = new System.Drawing.Size(754, 31);
            this.imgUrlBox.TabIndex = 7;
            this.imgUrlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.groupBox1.Controls.Add(this.changeAvatarTitleBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(-28, -56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1048, 126);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // changeAvatarTitleBox
            // 
            this.changeAvatarTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.changeAvatarTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changeAvatarTitleBox.Enabled = false;
            this.changeAvatarTitleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.changeAvatarTitleBox.HideSelection = false;
            this.changeAvatarTitleBox.Location = new System.Drawing.Point(52, 76);
            this.changeAvatarTitleBox.Margin = new System.Windows.Forms.Padding(5);
            this.changeAvatarTitleBox.Name = "changeAvatarTitleBox";
            this.changeAvatarTitleBox.ReadOnly = true;
            this.changeAvatarTitleBox.Size = new System.Drawing.Size(649, 31);
            this.changeAvatarTitleBox.TabIndex = 9;
            this.changeAvatarTitleBox.TabStop = false;
            this.changeAvatarTitleBox.Text = "IT ORG CHANGE AVATAR IMAGE";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.closeBtn.Location = new System.Drawing.Point(931, 16);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 31);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // imgUrlLbl
            // 
            this.imgUrlLbl.AutoSize = true;
            this.imgUrlLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.imgUrlLbl.Location = new System.Drawing.Point(34, 116);
            this.imgUrlLbl.Name = "imgUrlLbl";
            this.imgUrlLbl.Size = new System.Drawing.Size(136, 31);
            this.imgUrlLbl.TabIndex = 12;
            this.imgUrlLbl.Text = "Image URL:";
            // 
            // ChangeImageForm
            // 
            this.AcceptButton = this.changeImgBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(986, 265);
            this.Controls.Add(this.imgUrlLbl);
            this.Controls.Add(this.changeImgBtn);
            this.Controls.Add(this.imgUrlBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChangeImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeImageForm";
            this.Load += new System.EventHandler(this.ChangeImageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button changeImgBtn;
        private TextBox imgUrlBox;
        private GroupBox groupBox1;
        private TextBox changeAvatarTitleBox;
        private Label closeBtn;
        private Label imgUrlLbl;
    }
}
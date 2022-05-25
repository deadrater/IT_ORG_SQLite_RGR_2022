namespace IT_ORG_SQLite_RGR_2022.Views
{
    partial class AddProductForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.typeAddBox = new System.Windows.Forms.TextBox();
            this.nameAddBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exceptionTitleBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.priceAddBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imgUrlBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.loginBtn.Location = new System.Drawing.Point(267, 238);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(529, 50);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "LOG-IN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // typeAddBox
            // 
            this.typeAddBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.typeAddBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeAddBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.typeAddBox.Location = new System.Drawing.Point(267, 104);
            this.typeAddBox.Margin = new System.Windows.Forms.Padding(5);
            this.typeAddBox.Name = "typeAddBox";
            this.typeAddBox.Size = new System.Drawing.Size(526, 31);
            this.typeAddBox.TabIndex = 7;
            this.typeAddBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameAddBox
            // 
            this.nameAddBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.nameAddBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameAddBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.nameAddBox.Location = new System.Drawing.Point(267, 63);
            this.nameAddBox.Margin = new System.Windows.Forms.Padding(5);
            this.nameAddBox.Name = "nameAddBox";
            this.nameAddBox.Size = new System.Drawing.Size(526, 31);
            this.nameAddBox.TabIndex = 6;
            this.nameAddBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.groupBox1.Controls.Add(this.exceptionTitleBox);
            this.groupBox1.Controls.Add(this.closeBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(-14, -35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // exceptionTitleBox
            // 
            this.exceptionTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.exceptionTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exceptionTitleBox.Enabled = false;
            this.exceptionTitleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.exceptionTitleBox.HideSelection = false;
            this.exceptionTitleBox.Location = new System.Drawing.Point(26, 47);
            this.exceptionTitleBox.Name = "exceptionTitleBox";
            this.exceptionTitleBox.ReadOnly = true;
            this.exceptionTitleBox.Size = new System.Drawing.Size(371, 31);
            this.exceptionTitleBox.TabIndex = 9;
            this.exceptionTitleBox.TabStop = false;
            this.exceptionTitleBox.Text = "IT ORG ДОБАВИТЬ ЗАПИСЬ";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.closeBtn.Location = new System.Drawing.Point(816, 44);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 31);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // priceAddBox
            // 
            this.priceAddBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.priceAddBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceAddBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.priceAddBox.Location = new System.Drawing.Point(267, 145);
            this.priceAddBox.Margin = new System.Windows.Forms.Padding(5);
            this.priceAddBox.Name = "priceAddBox";
            this.priceAddBox.Size = new System.Drawing.Size(526, 31);
            this.priceAddBox.TabIndex = 12;
            this.priceAddBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Тип продукта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "URL картинки:";
            // 
            // imgUrlBox
            // 
            this.imgUrlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.imgUrlBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imgUrlBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.imgUrlBox.Location = new System.Drawing.Point(267, 186);
            this.imgUrlBox.Margin = new System.Windows.Forms.Padding(5);
            this.imgUrlBox.Name = "imgUrlBox";
            this.imgUrlBox.Size = new System.Drawing.Size(526, 31);
            this.imgUrlBox.TabIndex = 16;
            this.imgUrlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(834, 329);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imgUrlBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceAddBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.typeAddBox);
            this.Controls.Add(this.nameAddBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginBtn;
        private TextBox typeAddBox;
        private TextBox nameAddBox;
        private GroupBox groupBox1;
        private TextBox exceptionTitleBox;
        private Label closeBtn;
        private TextBox priceAddBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox imgUrlBox;
    }
}
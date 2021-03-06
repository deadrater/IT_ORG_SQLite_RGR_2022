namespace IT_ORG_SQLite_RGR_2022.Views
{
    partial class ProductsWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.exceptionTitleBox = new System.Windows.Forms.TextBox();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.commonRadioBtn = new System.Windows.Forms.RadioButton();
            this.nameRadioBtn = new System.Windows.Forms.RadioButton();
            this.priceRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.imgUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.groupBox1.Controls.Add(this.closeBtn);
            this.groupBox1.Controls.Add(this.exceptionTitleBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(-6, -40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1414, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.closeBtn.Location = new System.Drawing.Point(1365, 49);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 31);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // exceptionTitleBox
            // 
            this.exceptionTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.exceptionTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exceptionTitleBox.Enabled = false;
            this.exceptionTitleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.exceptionTitleBox.HideSelection = false;
            this.exceptionTitleBox.Location = new System.Drawing.Point(18, 49);
            this.exceptionTitleBox.Name = "exceptionTitleBox";
            this.exceptionTitleBox.ReadOnly = true;
            this.exceptionTitleBox.Size = new System.Drawing.Size(371, 31);
            this.exceptionTitleBox.TabIndex = 9;
            this.exceptionTitleBox.TabStop = false;
            this.exceptionTitleBox.Text = "IT ORG УСЛУГИ";
            this.exceptionTitleBox.TextChanged += new System.EventHandler(this.exceptionTitleBox_TextChanged);
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.AllowUserToAddRows = false;
            this.productsDataGrid.AllowUserToDeleteRows = false;
            this.productsDataGrid.AllowUserToResizeColumns = false;
            this.productsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.productsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.nameCol,
            this.typeCol,
            this.priceCol,
            this.saveCol,
            this.deleteCol,
            this.imgUrl});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.productsDataGrid.Location = new System.Drawing.Point(28, 75);
            this.productsDataGrid.Name = "productsDataGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productsDataGrid.RowHeadersWidth = 55;
            this.productsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsDataGrid.RowTemplate.Height = 29;
            this.productsDataGrid.Size = new System.Drawing.Size(1116, 543);
            this.productsDataGrid.TabIndex = 12;
            this.productsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGrid_CellContentClick);
            // 
            // imgBox
            // 
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Code.org_logo.svg/1200p" +
    "x-Code.org_logo.svg.png";
            this.imgBox.Location = new System.Drawing.Point(1159, 75);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(229, 217);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 13;
            this.imgBox.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Location = new System.Drawing.Point(28, 639);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1116, 31);
            this.searchBox.TabIndex = 14;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // commonRadioBtn
            // 
            this.commonRadioBtn.AutoSize = true;
            this.commonRadioBtn.Checked = true;
            this.commonRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.commonRadioBtn.Location = new System.Drawing.Point(42, 83);
            this.commonRadioBtn.Name = "commonRadioBtn";
            this.commonRadioBtn.Size = new System.Drawing.Size(115, 35);
            this.commonRadioBtn.TabIndex = 15;
            this.commonRadioBtn.TabStop = true;
            this.commonRadioBtn.Text = "Общий";
            this.commonRadioBtn.UseVisualStyleBackColor = true;
            this.commonRadioBtn.CheckedChanged += new System.EventHandler(this.commonRadioBtn_CheckedChanged);
            // 
            // nameRadioBtn
            // 
            this.nameRadioBtn.AutoSize = true;
            this.nameRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.nameRadioBtn.Location = new System.Drawing.Point(42, 142);
            this.nameRadioBtn.Name = "nameRadioBtn";
            this.nameRadioBtn.Size = new System.Drawing.Size(145, 35);
            this.nameRadioBtn.TabIndex = 16;
            this.nameRadioBtn.Text = "По имени";
            this.nameRadioBtn.UseVisualStyleBackColor = true;
            this.nameRadioBtn.CheckedChanged += new System.EventHandler(this.nameRadioBtn_CheckedChanged);
            // 
            // priceRadioBtn
            // 
            this.priceRadioBtn.AutoSize = true;
            this.priceRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.priceRadioBtn.Location = new System.Drawing.Point(42, 202);
            this.priceRadioBtn.Name = "priceRadioBtn";
            this.priceRadioBtn.Size = new System.Drawing.Size(126, 35);
            this.priceRadioBtn.TabIndex = 17;
            this.priceRadioBtn.Text = "По цене";
            this.priceRadioBtn.UseVisualStyleBackColor = true;
            this.priceRadioBtn.CheckedChanged += new System.EventHandler(this.priceRadioBtn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameRadioBtn);
            this.groupBox2.Controls.Add(this.priceRadioBtn);
            this.groupBox2.Controls.Add(this.commonRadioBtn);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.groupBox2.Location = new System.Drawing.Point(1159, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 320);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.addBtn.Location = new System.Drawing.Point(1159, 639);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(229, 31);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "Добавить запись";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.Visible = false;
            this.idCol.Width = 125;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Наименование";
            this.nameCol.MinimumWidth = 120;
            this.nameCol.Name = "nameCol";
            this.nameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameCol.Width = 350;
            // 
            // typeCol
            // 
            this.typeCol.HeaderText = "Тип услуги";
            this.typeCol.MinimumWidth = 6;
            this.typeCol.Name = "typeCol";
            this.typeCol.Width = 250;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Цена, руб.";
            this.priceCol.MinimumWidth = 6;
            this.priceCol.Name = "priceCol";
            this.priceCol.Width = 160;
            // 
            // saveCol
            // 
            this.saveCol.HeaderText = "Сохранить";
            this.saveCol.MinimumWidth = 6;
            this.saveCol.Name = "saveCol";
            this.saveCol.Width = 150;
            // 
            // deleteCol
            // 
            this.deleteCol.HeaderText = "Удалить";
            this.deleteCol.MinimumWidth = 6;
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.Width = 125;
            // 
            // imgUrl
            // 
            this.imgUrl.HeaderText = "Image Url";
            this.imgUrl.MinimumWidth = 6;
            this.imgUrl.Name = "imgUrl";
            this.imgUrl.Visible = false;
            this.imgUrl.Width = 125;
            // 
            // ProductsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1400, 698);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.productsDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsWindow";
            this.Load += new System.EventHandler(this.ProductsWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox exceptionTitleBox;
        private Label closeBtn;
        private DataGridView productsDataGrid;
        private PictureBox imgBox;
        private TextBox searchBox;
        private RadioButton commonRadioBtn;
        private RadioButton nameRadioBtn;
        private RadioButton priceRadioBtn;
        private GroupBox groupBox2;
        private Button addBtn;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn typeCol;
        private DataGridViewTextBoxColumn priceCol;
        private DataGridViewButtonColumn saveCol;
        private DataGridViewButtonColumn deleteCol;
        private DataGridViewTextBoxColumn imgUrl;
    }
}
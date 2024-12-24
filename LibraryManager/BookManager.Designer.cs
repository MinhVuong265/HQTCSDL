namespace LibraryManager
{
    partial class BookManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BookShowDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UpdateBookButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchBookButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MuonSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TraSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BookTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SoLuongBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TacGiaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BookIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BookTypeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookShowDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BookShowDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 360);
            this.panel1.TabIndex = 0;
            // 
            // BookShowDataGridView
            // 
            this.BookShowDataGridView.AllowUserToAddRows = false;
            this.BookShowDataGridView.AllowUserToDeleteRows = false;
            this.BookShowDataGridView.AllowUserToResizeColumns = false;
            this.BookShowDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookShowDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.BookShowDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookShowDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookShowDataGridView.ColumnHeadersHeight = 29;
            this.BookShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BookShowDataGridView.Location = new System.Drawing.Point(3, 3);
            this.BookShowDataGridView.Name = "BookShowDataGridView";
            this.BookShowDataGridView.ReadOnly = true;
            this.BookShowDataGridView.RowHeadersWidth = 51;
            this.BookShowDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BookShowDataGridView.RowTemplate.Height = 24;
            this.BookShowDataGridView.Size = new System.Drawing.Size(1102, 354);
            this.BookShowDataGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UpdateBookButton);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.SearchTextBox);
            this.panel3.Controls.Add(this.SearchBookButton);
            this.panel3.Controls.Add(this.AddBookButton);
            this.panel3.Location = new System.Drawing.Point(12, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 113);
            this.panel3.TabIndex = 0;
            // 
            // UpdateBookButton
            // 
            this.UpdateBookButton.Location = new System.Drawing.Point(785, 22);
            this.UpdateBookButton.Name = "UpdateBookButton";
            this.UpdateBookButton.Size = new System.Drawing.Size(155, 75);
            this.UpdateBookButton.TabIndex = 6;
            this.UpdateBookButton.Text = "Sửa sách";
            this.UpdateBookButton.UseVisualStyleBackColor = true;
            this.UpdateBookButton.Click += new System.EventHandler(this.UpdateBookButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(947, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 75);
            this.button3.TabIndex = 7;
            this.button3.Text = "Xóa sách";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RemoveBookButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhập thông tin:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(141, 53);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(299, 28);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.Tag = "";
            // 
            // SearchBookButton
            // 
            this.SearchBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBookButton.Location = new System.Drawing.Point(456, 52);
            this.SearchBookButton.Name = "SearchBookButton";
            this.SearchBookButton.Size = new System.Drawing.Size(110, 30);
            this.SearchBookButton.TabIndex = 1;
            this.SearchBookButton.Text = "Tìm kiếm";
            this.SearchBookButton.UseVisualStyleBackColor = true;
            this.SearchBookButton.Click += new System.EventHandler(this.SearchBookButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(624, 22);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(155, 75);
            this.AddBookButton.TabIndex = 5;
            this.AddBookButton.Text = "Thêm sách";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MuonSachToolStripMenuItem,
            this.TraSachToolStripMenuItem,
            this.thoongToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MuonSachToolStripMenuItem
            // 
            this.MuonSachToolStripMenuItem.Name = "MuonSachToolStripMenuItem";
            this.MuonSachToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.MuonSachToolStripMenuItem.Text = "Muợn sách";
            this.MuonSachToolStripMenuItem.Click += new System.EventHandler(this.MuonSachToolStripMenuItem_Click);
            // 
            // TraSachToolStripMenuItem
            // 
            this.TraSachToolStripMenuItem.Name = "TraSachToolStripMenuItem";
            this.TraSachToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.TraSachToolStripMenuItem.Text = "Quản lý sách mượn";
            this.TraSachToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐộcGiảToolStripMenuItem_Click);
            // 
            // thoongToolStripMenuItem
            // 
            this.thoongToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.thoongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.thoongToolStripMenuItem.Name = "thoongToolStripMenuItem";
            this.thoongToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.thoongToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // AccountToolStripMenuItem
            // 
            this.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem";
            this.AccountToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.AccountToolStripMenuItem.Text = "Thông tin cá nhân";
            this.AccountToolStripMenuItem.Click += new System.EventHandler(this.AccountToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.LogOutToolStripMenuItem.Text = "Đăng xuất";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BookTypeComboBox);
            this.panel2.Controls.Add(this.BookTypeIdTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.DoneButton);
            this.panel2.Controls.Add(this.SoLuongBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TacGiaTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BookNameTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BookIdTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 111);
            this.panel2.TabIndex = 4;
            // 
            // BookTypeIdTextBox
            // 
            this.BookTypeIdTextBox.Enabled = false;
            this.BookTypeIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTypeIdTextBox.Location = new System.Drawing.Point(95, 70);
            this.BookTypeIdTextBox.Name = "BookTypeIdTextBox";
            this.BookTypeIdTextBox.Size = new System.Drawing.Size(215, 28);
            this.BookTypeIdTextBox.TabIndex = 13;
            this.BookTypeIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookTypeIdTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã loại:";
            // 
            // DoneButton
            // 
            this.DoneButton.Enabled = false;
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(1013, 61);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(92, 41);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Text = "Xong";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // SoLuongBox
            // 
            this.SoLuongBox.Enabled = false;
            this.SoLuongBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongBox.Location = new System.Drawing.Point(855, 67);
            this.SoLuongBox.Name = "SoLuongBox";
            this.SoLuongBox.Size = new System.Drawing.Size(120, 28);
            this.SoLuongBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(744, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thể loại:";
            // 
            // TacGiaTextBox
            // 
            this.TacGiaTextBox.Enabled = false;
            this.TacGiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TacGiaTextBox.Location = new System.Drawing.Point(858, 14);
            this.TacGiaTextBox.Name = "TacGiaTextBox";
            this.TacGiaTextBox.Size = new System.Drawing.Size(215, 28);
            this.TacGiaTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(744, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên tác giả:";
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Enabled = false;
            this.BookNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameTextBox.Location = new System.Drawing.Point(469, 14);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(215, 28);
            this.BookNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sách:";
            // 
            // BookIdTextBox
            // 
            this.BookIdTextBox.Enabled = false;
            this.BookIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIdTextBox.Location = new System.Drawing.Point(95, 14);
            this.BookIdTextBox.Name = "BookIdTextBox";
            this.BookIdTextBox.Size = new System.Drawing.Size(215, 28);
            this.BookIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách:";
            // 
            // BookTypeComboBox
            // 
            this.BookTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BookTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BookTypeComboBox.Enabled = false;
            this.BookTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTypeComboBox.FormattingEnabled = true;
            this.BookTypeComboBox.Location = new System.Drawing.Point(469, 67);
            this.BookTypeComboBox.Name = "BookTypeComboBox";
            this.BookTypeComboBox.Size = new System.Drawing.Size(215, 30);
            this.BookTypeComboBox.TabIndex = 14;
            this.BookTypeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.BookTypeComboBox_Validating);
            // 
            // BookManager
            // 
            this.AcceptButton = this.SearchBookButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BookManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookShowDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MuonSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TraSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchBookButton;
        private System.Windows.Forms.Button UpdateBookButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView BookShowDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TacGiaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BookIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SoLuongBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TextBox BookTypeIdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox BookTypeComboBox;
    }
}
namespace LibraryManager
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccountdataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AccountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DisplayNameTextBox = new System.Windows.Forms.TextBox();
            this.FixAccountButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FixDoneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveAccountButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchNameButton = new System.Windows.Forms.Button();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DoneButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountdataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AccountdataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 552);
            this.panel1.TabIndex = 0;
            // 
            // AccountdataGridView
            // 
            this.AccountdataGridView.AllowUserToAddRows = false;
            this.AccountdataGridView.AllowUserToDeleteRows = false;
            this.AccountdataGridView.AllowUserToResizeColumns = false;
            this.AccountdataGridView.AllowUserToResizeRows = false;
            this.AccountdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountdataGridView.Location = new System.Drawing.Point(0, 0);
            this.AccountdataGridView.Name = "AccountdataGridView";
            this.AccountdataGridView.ReadOnly = true;
            this.AccountdataGridView.RowHeadersWidth = 51;
            this.AccountdataGridView.RowTemplate.Height = 24;
            this.AccountdataGridView.Size = new System.Drawing.Size(617, 546);
            this.AccountdataGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 78);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản lý tài khoản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AccountTypeComboBox);
            this.panel2.Controls.Add(this.DisplayNameTextBox);
            this.panel2.Controls.Add(this.FixAccountButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.FixDoneButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.RemoveAccountButton);
            this.panel2.Controls.Add(this.PasswordTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.UserNameTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.SearchNameButton);
            this.panel2.Controls.Add(this.SearchNameTextBox);
            this.panel2.Location = new System.Drawing.Point(641, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 362);
            this.panel2.TabIndex = 3;
            // 
            // AccountTypeComboBox
            // 
            this.AccountTypeComboBox.Enabled = false;
            this.AccountTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypeComboBox.FormattingEnabled = true;
            this.AccountTypeComboBox.Items.AddRange(new object[] {
            "Quản lý",
            "Admin"});
            this.AccountTypeComboBox.Location = new System.Drawing.Point(182, 251);
            this.AccountTypeComboBox.MaxDropDownItems = 2;
            this.AccountTypeComboBox.Name = "AccountTypeComboBox";
            this.AccountTypeComboBox.Size = new System.Drawing.Size(121, 30);
            this.AccountTypeComboBox.TabIndex = 16;
            // 
            // DisplayNameTextBox
            // 
            this.DisplayNameTextBox.Enabled = false;
            this.DisplayNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNameTextBox.Location = new System.Drawing.Point(180, 154);
            this.DisplayNameTextBox.Name = "DisplayNameTextBox";
            this.DisplayNameTextBox.Size = new System.Drawing.Size(249, 28);
            this.DisplayNameTextBox.TabIndex = 6;
            // 
            // FixAccountButton
            // 
            this.FixAccountButton.Location = new System.Drawing.Point(3, 300);
            this.FixAccountButton.Name = "FixAccountButton";
            this.FixAccountButton.Size = new System.Drawing.Size(145, 50);
            this.FixAccountButton.TabIndex = 12;
            this.FixAccountButton.Text = "Sửa";
            this.FixAccountButton.UseVisualStyleBackColor = true;
            this.FixAccountButton.Click += new System.EventHandler(this.FixAccountButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên hiển thị:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Loại tài khoản:";
            // 
            // FixDoneButton
            // 
            this.FixDoneButton.Enabled = false;
            this.FixDoneButton.Location = new System.Drawing.Point(303, 300);
            this.FixDoneButton.Name = "FixDoneButton";
            this.FixDoneButton.Size = new System.Drawing.Size(145, 50);
            this.FixDoneButton.TabIndex = 13;
            this.FixDoneButton.Text = "Xong";
            this.FixDoneButton.UseVisualStyleBackColor = true;
            this.FixDoneButton.Click += new System.EventHandler(this.FixDoneButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhập tên để tìm kiếm:";
            // 
            // RemoveAccountButton
            // 
            this.RemoveAccountButton.Location = new System.Drawing.Point(152, 300);
            this.RemoveAccountButton.Name = "RemoveAccountButton";
            this.RemoveAccountButton.Size = new System.Drawing.Size(145, 50);
            this.RemoveAccountButton.TabIndex = 13;
            this.RemoveAccountButton.Text = "Xóa";
            this.RemoveAccountButton.UseVisualStyleBackColor = true;
            this.RemoveAccountButton.Click += new System.EventHandler(this.RemoveAccountButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(180, 202);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(249, 28);
            this.PasswordTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mật khẩu:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Enabled = false;
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(180, 106);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(249, 28);
            this.UserNameTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên đăng nhập:";
            // 
            // SearchNameButton
            // 
            this.SearchNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchNameButton.Location = new System.Drawing.Point(326, 63);
            this.SearchNameButton.Name = "SearchNameButton";
            this.SearchNameButton.Size = new System.Drawing.Size(103, 31);
            this.SearchNameButton.TabIndex = 2;
            this.SearchNameButton.Text = "Tìm";
            this.SearchNameButton.UseVisualStyleBackColor = true;
            this.SearchNameButton.Click += new System.EventHandler(this.SearchNameButton_Click);
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchNameTextBox.Location = new System.Drawing.Point(8, 63);
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.Size = new System.Drawing.Size(312, 28);
            this.SearchNameTextBox.TabIndex = 1;
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(164, 3);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(123, 64);
            this.AddAccountButton.TabIndex = 11;
            this.AddAccountButton.Text = "Thêm";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DoneButton);
            this.panel4.Controls.Add(this.AddAccountButton);
            this.panel4.Location = new System.Drawing.Point(641, 466);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 183);
            this.panel4.TabIndex = 4;
            // 
            // DoneButton
            // 
            this.DoneButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DoneButton.Location = new System.Drawing.Point(0, 116);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(445, 64);
            this.DoneButton.TabIndex = 14;
            this.DoneButton.Text = "Thoát";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // AdminForm
            // 
            this.AcceptButton = this.SearchNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DoneButton;
            this.ClientSize = new System.Drawing.Size(1104, 661);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountdataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchNameButton;
        private System.Windows.Forms.TextBox SearchNameTextBox;
        private System.Windows.Forms.Button RemoveAccountButton;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button FixAccountButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DisplayNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.DataGridView AccountdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FixDoneButton;
        private System.Windows.Forms.ComboBox AccountTypeComboBox;
        private System.Windows.Forms.Label label6;
    }
}
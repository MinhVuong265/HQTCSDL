namespace LibraryManager
{
    partial class BorrowBookManager
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
            this.ReaderDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BookBorrowInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.ReaderNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TelNumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReaderIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveReaderButton = new System.Windows.Forms.Button();
            this.UpdateReaderInfoButton = new System.Windows.Forms.Button();
            this.RemoveBorrowBookButton = new System.Windows.Forms.Button();
            this.BorrowBookButton = new System.Windows.Forms.Button();
            this.AddReaderButton = new System.Windows.Forms.Button();
            this.SearchReaderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchReaderButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookBorrowInfoDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReaderDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 297);
            this.panel1.TabIndex = 0;
            // 
            // ReaderDataGridView
            // 
            this.ReaderDataGridView.AllowUserToAddRows = false;
            this.ReaderDataGridView.AllowUserToDeleteRows = false;
            this.ReaderDataGridView.AllowUserToResizeColumns = false;
            this.ReaderDataGridView.AllowUserToResizeRows = false;
            this.ReaderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReaderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReaderDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ReaderDataGridView.MultiSelect = false;
            this.ReaderDataGridView.Name = "ReaderDataGridView";
            this.ReaderDataGridView.ReadOnly = true;
            this.ReaderDataGridView.RowHeadersWidth = 51;
            this.ReaderDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ReaderDataGridView.RowTemplate.Height = 24;
            this.ReaderDataGridView.Size = new System.Drawing.Size(669, 291);
            this.ReaderDataGridView.TabIndex = 0;
            this.ReaderDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReaderDataGridView_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BookBorrowInfoDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1338, 417);
            this.panel2.TabIndex = 1;
            // 
            // BookBorrowInfoDataGridView
            // 
            this.BookBorrowInfoDataGridView.AllowUserToAddRows = false;
            this.BookBorrowInfoDataGridView.AllowUserToDeleteRows = false;
            this.BookBorrowInfoDataGridView.AllowUserToResizeColumns = false;
            this.BookBorrowInfoDataGridView.AllowUserToResizeRows = false;
            this.BookBorrowInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookBorrowInfoDataGridView.ColumnHeadersHeight = 29;
            this.BookBorrowInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BookBorrowInfoDataGridView.Location = new System.Drawing.Point(6, 0);
            this.BookBorrowInfoDataGridView.MultiSelect = false;
            this.BookBorrowInfoDataGridView.Name = "BookBorrowInfoDataGridView";
            this.BookBorrowInfoDataGridView.ReadOnly = true;
            this.BookBorrowInfoDataGridView.RowHeadersWidth = 51;
            this.BookBorrowInfoDataGridView.RowTemplate.Height = 24;
            this.BookBorrowInfoDataGridView.Size = new System.Drawing.Size(1332, 411);
            this.BookBorrowInfoDataGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ExitButton);
            this.panel3.Controls.Add(this.DoneButton);
            this.panel3.Controls.Add(this.ReaderNameTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.AddressTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TelNumTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ReaderIDTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.RemoveReaderButton);
            this.panel3.Controls.Add(this.UpdateReaderInfoButton);
            this.panel3.Controls.Add(this.RemoveBorrowBookButton);
            this.panel3.Controls.Add(this.BorrowBookButton);
            this.panel3.Controls.Add(this.AddReaderButton);
            this.panel3.Controls.Add(this.SearchReaderTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.SearchReaderButton);
            this.panel3.Location = new System.Drawing.Point(693, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 294);
            this.panel3.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(551, 234);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 38);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.AutoSize = true;
            this.DoneButton.Enabled = false;
            this.DoneButton.Location = new System.Drawing.Point(343, 75);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(97, 38);
            this.DoneButton.TabIndex = 16;
            this.DoneButton.Text = "Xong";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // ReaderNameTextBox
            // 
            this.ReaderNameTextBox.Enabled = false;
            this.ReaderNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderNameTextBox.Location = new System.Drawing.Point(108, 110);
            this.ReaderNameTextBox.Name = "ReaderNameTextBox";
            this.ReaderNameTextBox.Size = new System.Drawing.Size(207, 24);
            this.ReaderNameTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Họ tên:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Enabled = false;
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(108, 177);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(207, 24);
            this.AddressTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa chỉ:";
            // 
            // TelNumTextBox
            // 
            this.TelNumTextBox.Enabled = false;
            this.TelNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelNumTextBox.Location = new System.Drawing.Point(108, 143);
            this.TelNumTextBox.Name = "TelNumTextBox";
            this.TelNumTextBox.Size = new System.Drawing.Size(207, 24);
            this.TelNumTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số điện thoại:";
            // 
            // ReaderIDTextBox
            // 
            this.ReaderIDTextBox.Enabled = false;
            this.ReaderIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderIDTextBox.Location = new System.Drawing.Point(108, 75);
            this.ReaderIDTextBox.Name = "ReaderIDTextBox";
            this.ReaderIDTextBox.Size = new System.Drawing.Size(207, 24);
            this.ReaderIDTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã độc giả:";
            // 
            // RemoveReaderButton
            // 
            this.RemoveReaderButton.AutoSize = true;
            this.RemoveReaderButton.Location = new System.Drawing.Point(3, 229);
            this.RemoveReaderButton.Name = "RemoveReaderButton";
            this.RemoveReaderButton.Size = new System.Drawing.Size(97, 38);
            this.RemoveReaderButton.TabIndex = 7;
            this.RemoveReaderButton.Text = "Xóa độc giả";
            this.RemoveReaderButton.UseVisualStyleBackColor = true;
            this.RemoveReaderButton.Click += new System.EventHandler(this.RemoveReaderButton_Click);
            // 
            // UpdateReaderInfoButton
            // 
            this.UpdateReaderInfoButton.AutoSize = true;
            this.UpdateReaderInfoButton.Location = new System.Drawing.Point(216, 229);
            this.UpdateReaderInfoButton.Name = "UpdateReaderInfoButton";
            this.UpdateReaderInfoButton.Size = new System.Drawing.Size(97, 38);
            this.UpdateReaderInfoButton.TabIndex = 6;
            this.UpdateReaderInfoButton.Text = "Sửa thông tin";
            this.UpdateReaderInfoButton.UseVisualStyleBackColor = true;
            this.UpdateReaderInfoButton.Click += new System.EventHandler(this.UpdateReaderInfoButton_Click);
            // 
            // RemoveBorrowBookButton
            // 
            this.RemoveBorrowBookButton.AutoSize = true;
            this.RemoveBorrowBookButton.Location = new System.Drawing.Point(551, 146);
            this.RemoveBorrowBookButton.Name = "RemoveBorrowBookButton";
            this.RemoveBorrowBookButton.Size = new System.Drawing.Size(97, 38);
            this.RemoveBorrowBookButton.TabIndex = 5;
            this.RemoveBorrowBookButton.Text = "Trả sách";
            this.RemoveBorrowBookButton.UseVisualStyleBackColor = true;
            this.RemoveBorrowBookButton.Click += new System.EventHandler(this.RemoveBorrowBookButton_Click);
            // 
            // BorrowBookButton
            // 
            this.BorrowBookButton.AutoSize = true;
            this.BorrowBookButton.Location = new System.Drawing.Point(551, 190);
            this.BorrowBookButton.Name = "BorrowBookButton";
            this.BorrowBookButton.Size = new System.Drawing.Size(97, 38);
            this.BorrowBookButton.TabIndex = 4;
            this.BorrowBookButton.Text = "Mượn sách";
            this.BorrowBookButton.UseVisualStyleBackColor = true;
            this.BorrowBookButton.Click += new System.EventHandler(this.BorrowBookButton_Click);
            // 
            // AddReaderButton
            // 
            this.AddReaderButton.AutoSize = true;
            this.AddReaderButton.Location = new System.Drawing.Point(106, 229);
            this.AddReaderButton.Name = "AddReaderButton";
            this.AddReaderButton.Size = new System.Drawing.Size(100, 38);
            this.AddReaderButton.TabIndex = 3;
            this.AddReaderButton.Text = "Thêm độc giả";
            this.AddReaderButton.UseVisualStyleBackColor = true;
            this.AddReaderButton.Click += new System.EventHandler(this.AddReaderButton_Click);
            // 
            // SearchReaderTextBox
            // 
            this.SearchReaderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchReaderTextBox.Location = new System.Drawing.Point(180, 28);
            this.SearchReaderTextBox.Name = "SearchReaderTextBox";
            this.SearchReaderTextBox.Size = new System.Drawing.Size(352, 28);
            this.SearchReaderTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số điện thoại:";
            // 
            // SearchReaderButton
            // 
            this.SearchReaderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchReaderButton.Location = new System.Drawing.Point(551, 20);
            this.SearchReaderButton.Name = "SearchReaderButton";
            this.SearchReaderButton.Size = new System.Drawing.Size(100, 39);
            this.SearchReaderButton.TabIndex = 0;
            this.SearchReaderButton.Text = "Tìm kiếm";
            this.SearchReaderButton.UseVisualStyleBackColor = true;
            this.SearchReaderButton.Click += new System.EventHandler(this.SearchReaderButton_Click);
            // 
            // BorrowBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(1362, 735);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BorrowBookManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý sách mượn";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReaderDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookBorrowInfoDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ReaderDataGridView;
        private System.Windows.Forms.DataGridView BookBorrowInfoDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SearchReaderButton;
        private System.Windows.Forms.TextBox SearchReaderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateReaderInfoButton;
        private System.Windows.Forms.Button RemoveBorrowBookButton;
        private System.Windows.Forms.Button AddReaderButton;
        private System.Windows.Forms.TextBox ReaderNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TelNumTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReaderIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveReaderButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button BorrowBookButton;
        private System.Windows.Forms.Button ExitButton;
    }
}
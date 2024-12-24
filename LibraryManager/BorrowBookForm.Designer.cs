namespace LibraryManager
{
    partial class BorrowBookForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NameReaderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IdReaderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TelPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBookButton = new System.Windows.Forms.Button();
            this.ListBookDataGridView = new System.Windows.Forms.DataGridView();
            this.BookIdTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.NameReaderTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.IdReaderTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddressTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TelPhoneTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 472);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xong";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thông tin độc giả";
            // 
            // NameReaderTextBox
            // 
            this.NameReaderTextBox.Enabled = false;
            this.NameReaderTextBox.Location = new System.Drawing.Point(143, 216);
            this.NameReaderTextBox.Name = "NameReaderTextBox";
            this.NameReaderTextBox.Size = new System.Drawing.Size(292, 28);
            this.NameReaderTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ tên:";
            // 
            // IdReaderTextBox
            // 
            this.IdReaderTextBox.Enabled = false;
            this.IdReaderTextBox.Location = new System.Drawing.Point(143, 171);
            this.IdReaderTextBox.Name = "IdReaderTextBox";
            this.IdReaderTextBox.Size = new System.Drawing.Size(292, 28);
            this.IdReaderTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã độc giả:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Enabled = false;
            this.AddressTextBox.Location = new System.Drawing.Point(143, 257);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(292, 28);
            this.AddressTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // TelPhoneTextBox
            // 
            this.TelPhoneTextBox.Location = new System.Drawing.Point(146, 64);
            this.TelPhoneTextBox.Name = "TelPhoneTextBox";
            this.TelPhoneTextBox.Size = new System.Drawing.Size(289, 28);
            this.TelPhoneTextBox.TabIndex = 1;
            this.TelPhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelPhoneTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchBookButton);
            this.panel2.Controls.Add(this.ListBookDataGridView);
            this.panel2.Controls.Add(this.BookIdTextBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(607, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 472);
            this.panel2.TabIndex = 1;
            // 
            // SearchBookButton
            // 
            this.SearchBookButton.Location = new System.Drawing.Point(335, 66);
            this.SearchBookButton.Name = "SearchBookButton";
            this.SearchBookButton.Size = new System.Drawing.Size(96, 30);
            this.SearchBookButton.TabIndex = 12;
            this.SearchBookButton.Text = "Xong";
            this.SearchBookButton.UseVisualStyleBackColor = true;
            this.SearchBookButton.Click += new System.EventHandler(this.SearchBookButton_Click);
            // 
            // ListBookDataGridView
            // 
            this.ListBookDataGridView.AllowUserToAddRows = false;
            this.ListBookDataGridView.AllowUserToDeleteRows = false;
            this.ListBookDataGridView.AllowUserToResizeColumns = false;
            this.ListBookDataGridView.AllowUserToResizeRows = false;
            this.ListBookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListBookDataGridView.Location = new System.Drawing.Point(7, 102);
            this.ListBookDataGridView.Name = "ListBookDataGridView";
            this.ListBookDataGridView.ReadOnly = true;
            this.ListBookDataGridView.RowHeadersWidth = 51;
            this.ListBookDataGridView.RowTemplate.Height = 24;
            this.ListBookDataGridView.Size = new System.Drawing.Size(810, 365);
            this.ListBookDataGridView.TabIndex = 18;
            // 
            // BookIdTextBox
            // 
            this.BookIdTextBox.Location = new System.Drawing.Point(139, 65);
            this.BookIdTextBox.Name = "BookIdTextBox";
            this.BookIdTextBox.Size = new System.Drawing.Size(170, 28);
            this.BookIdTextBox.TabIndex = 11;
            this.BookIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookIdTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nhập mã sách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thông tin sách mượn";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(1151, 508);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(135, 46);
            this.DoneButton.TabIndex = 2;
            this.DoneButton.Text = "Mượn";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(1292, 508);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(135, 46);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Xong";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(1439, 573);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BorrowBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn sách";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBookDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameReaderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdReaderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TelPhoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookIdTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.DataGridView ListBookDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SearchBookButton;
        private System.Windows.Forms.Button ExitButton;
    }
}
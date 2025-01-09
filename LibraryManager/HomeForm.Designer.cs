namespace LibraryManager
{
    partial class HomeForm
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
            this.Book = new System.Windows.Forms.Button();
            this.Reader = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.Button();
            this.Supplier = new System.Windows.Forms.Button();
            this.Staff = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Book
            // 
            this.Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book.Location = new System.Drawing.Point(149, 82);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(149, 84);
            this.Book.TabIndex = 0;
            this.Book.Text = "Quản lý sách";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // Reader
            // 
            this.Reader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reader.Location = new System.Drawing.Point(417, 82);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(149, 84);
            this.Reader.TabIndex = 1;
            this.Reader.Text = "Quản lý độc giả";
            this.Reader.UseVisualStyleBackColor = true;
            this.Reader.Click += new System.EventHandler(this.Reader_Click);
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(149, 200);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(149, 84);
            this.Category.TabIndex = 2;
            this.Category.Text = "Quản lý thể loại";
            this.Category.UseVisualStyleBackColor = true;
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // Supplier
            // 
            this.Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier.Location = new System.Drawing.Point(417, 200);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(149, 84);
            this.Supplier.TabIndex = 3;
            this.Supplier.Text = "Quản lý nhà cung cấp";
            this.Supplier.UseVisualStyleBackColor = true;
            this.Supplier.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // Staff
            // 
            this.Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff.Location = new System.Drawing.Point(269, 307);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(173, 95);
            this.Staff.TabIndex = 4;
            this.Staff.Text = "Quản lý nhân viên và báo cáo";
            this.Staff.UseVisualStyleBackColor = true;
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(46, 18);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "label1";
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLabel.Location = new System.Drawing.Point(643, 9);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(74, 18);
            this.LogoutLabel.TabIndex = 6;
            this.LogoutLabel.Text = "Đăng xuất";
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.Supplier);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Reader);
            this.Controls.Add(this.Book);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Button Reader;
        private System.Windows.Forms.Button Category;
        private System.Windows.Forms.Button Supplier;
        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LogoutLabel;
    }
}
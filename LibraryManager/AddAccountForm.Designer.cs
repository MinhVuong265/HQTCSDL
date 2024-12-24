namespace LibraryManager
{
    partial class AddAccountForm
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
            this.ExitAddButton = new System.Windows.Forms.Button();
            this.DoneAddButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPassTxtBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NewDisplayNameTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NewUserNameTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TypeAccCbBox = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitAddButton
            // 
            this.ExitAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitAddButton.Location = new System.Drawing.Point(377, 259);
            this.ExitAddButton.Name = "ExitAddButton";
            this.ExitAddButton.Size = new System.Drawing.Size(98, 36);
            this.ExitAddButton.TabIndex = 5;
            this.ExitAddButton.Text = "Thoát";
            this.ExitAddButton.UseVisualStyleBackColor = true;
            // 
            // DoneAddButton
            // 
            this.DoneAddButton.Location = new System.Drawing.Point(273, 259);
            this.DoneAddButton.Name = "DoneAddButton";
            this.DoneAddButton.Size = new System.Drawing.Size(98, 36);
            this.DoneAddButton.TabIndex = 4;
            this.DoneAddButton.Text = "Xong";
            this.DoneAddButton.UseVisualStyleBackColor = true;
            this.DoneAddButton.Click += new System.EventHandler(this.DoneAddButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.NewPassTxtBox);
            this.panel3.Location = new System.Drawing.Point(12, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 55);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // NewPassTxtBox
            // 
            this.NewPassTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassTxtBox.Location = new System.Drawing.Point(184, 10);
            this.NewPassTxtBox.Name = "NewPassTxtBox";
            this.NewPassTxtBox.Size = new System.Drawing.Size(238, 28);
            this.NewPassTxtBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.NewDisplayNameTxtBox);
            this.panel2.Location = new System.Drawing.Point(12, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 55);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hiển thị:";
            // 
            // NewDisplayNameTxtBox
            // 
            this.NewDisplayNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDisplayNameTxtBox.Location = new System.Drawing.Point(184, 13);
            this.NewDisplayNameTxtBox.Name = "NewDisplayNameTxtBox";
            this.NewDisplayNameTxtBox.Size = new System.Drawing.Size(238, 28);
            this.NewDisplayNameTxtBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NewUserNameTxtBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // NewUserNameTxtBox
            // 
            this.NewUserNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserNameTxtBox.Location = new System.Drawing.Point(184, 13);
            this.NewUserNameTxtBox.Name = "NewUserNameTxtBox";
            this.NewUserNameTxtBox.Size = new System.Drawing.Size(238, 28);
            this.NewUserNameTxtBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại tài khoản:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TypeAccCbBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 55);
            this.panel4.TabIndex = 3;
            // 
            // TypeAccCbBox
            // 
            this.TypeAccCbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeAccCbBox.FormattingEnabled = true;
            this.TypeAccCbBox.Items.AddRange(new object[] {
            "Quản lý",
            "Admin"});
            this.TypeAccCbBox.Location = new System.Drawing.Point(184, 12);
            this.TypeAccCbBox.MaxDropDownItems = 2;
            this.TypeAccCbBox.Name = "TypeAccCbBox";
            this.TypeAccCbBox.Size = new System.Drawing.Size(155, 28);
            this.TypeAccCbBox.TabIndex = 2;
            this.TypeAccCbBox.Text = "Quản lý";
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitAddButton;
            this.ClientSize = new System.Drawing.Size(492, 306);
            this.Controls.Add(this.ExitAddButton);
            this.Controls.Add(this.DoneAddButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tài khoản mới";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitAddButton;
        private System.Windows.Forms.Button DoneAddButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPassTxtBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewDisplayNameTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewUserNameTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox TypeAccCbBox;
    }
}
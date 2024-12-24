namespace LibraryManager
{
    partial class AddReaderForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.NewAddressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NewTelNumTextBox = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitAddButton
            // 
            this.ExitAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitAddButton.Location = new System.Drawing.Point(376, 213);
            this.ExitAddButton.Name = "ExitAddButton";
            this.ExitAddButton.Size = new System.Drawing.Size(98, 36);
            this.ExitAddButton.TabIndex = 11;
            this.ExitAddButton.Text = "Thoát";
            this.ExitAddButton.UseVisualStyleBackColor = true;
            // 
            // DoneAddButton
            // 
            this.DoneAddButton.Location = new System.Drawing.Point(272, 213);
            this.DoneAddButton.Name = "DoneAddButton";
            this.DoneAddButton.Size = new System.Drawing.Size(98, 36);
            this.DoneAddButton.TabIndex = 10;
            this.DoneAddButton.Text = "Xong";
            this.DoneAddButton.UseVisualStyleBackColor = true;
            this.DoneAddButton.Click += new System.EventHandler(this.DoneAddButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NewAddressTextBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 55);
            this.panel4.TabIndex = 9;
            // 
            // NewAddressTextBox
            // 
            this.NewAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAddressTextBox.Location = new System.Drawing.Point(184, 10);
            this.NewAddressTextBox.Name = "NewAddressTextBox";
            this.NewAddressTextBox.Size = new System.Drawing.Size(238, 28);
            this.NewAddressTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.FullNameTextBox);
            this.panel3.Location = new System.Drawing.Point(12, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 55);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTextBox.Location = new System.Drawing.Point(184, 10);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(238, 28);
            this.FullNameTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.NewTelNumTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 55);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại:";
            // 
            // NewTelNumTextBox
            // 
            this.NewTelNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTelNumTextBox.Location = new System.Drawing.Point(184, 13);
            this.NewTelNumTextBox.Name = "NewTelNumTextBox";
            this.NewTelNumTextBox.Size = new System.Drawing.Size(238, 28);
            this.NewTelNumTextBox.TabIndex = 0;
            // 
            // AddReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitAddButton;
            this.ClientSize = new System.Drawing.Size(487, 269);
            this.Controls.Add(this.ExitAddButton);
            this.Controls.Add(this.DoneAddButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm độc giả";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitAddButton;
        private System.Windows.Forms.Button DoneAddButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewTelNumTextBox;
        private System.Windows.Forms.TextBox NewAddressTextBox;
    }
}
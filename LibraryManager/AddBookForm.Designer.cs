﻿namespace LibraryManager
{
    partial class AddBookForm
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
            this.SoLuongBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NewTypeBookComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NewTacGiaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NewBookNameTextBox = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitAddButton
            // 
            this.ExitAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitAddButton.Location = new System.Drawing.Point(377, 259);
            this.ExitAddButton.Name = "ExitAddButton";
            this.ExitAddButton.Size = new System.Drawing.Size(98, 36);
            this.ExitAddButton.TabIndex = 11;
            this.ExitAddButton.Text = "Thoát";
            this.ExitAddButton.UseVisualStyleBackColor = true;
            // 
            // DoneAddButton
            // 
            this.DoneAddButton.Location = new System.Drawing.Point(273, 259);
            this.DoneAddButton.Name = "DoneAddButton";
            this.DoneAddButton.Size = new System.Drawing.Size(98, 36);
            this.DoneAddButton.TabIndex = 10;
            this.DoneAddButton.Text = "Xong";
            this.DoneAddButton.UseVisualStyleBackColor = true;
            this.DoneAddButton.Click += new System.EventHandler(this.DoneAddButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SoLuongBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 55);
            this.panel4.TabIndex = 4;
            // 
            // SoLuongBox
            // 
            this.SoLuongBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongBox.Location = new System.Drawing.Point(184, 13);
            this.SoLuongBox.Name = "SoLuongBox";
            this.SoLuongBox.Size = new System.Drawing.Size(120, 27);
            this.SoLuongBox.TabIndex = 2;
            this.SoLuongBox.ThousandsSeparator = true;
            this.SoLuongBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NewTypeBookComboBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 55);
            this.panel3.TabIndex = 3;
            // 
            // NewTypeBookComboBox
            // 
            this.NewTypeBookComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NewTypeBookComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NewTypeBookComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTypeBookComboBox.FormattingEnabled = true;
            this.NewTypeBookComboBox.Location = new System.Drawing.Point(184, 13);
            this.NewTypeBookComboBox.Name = "NewTypeBookComboBox";
            this.NewTypeBookComboBox.Size = new System.Drawing.Size(238, 30);
            this.NewTypeBookComboBox.TabIndex = 2;
            this.NewTypeBookComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.NewTypeBookComboBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thể loại:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.NewTacGiaTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 55);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tác giả:";
            // 
            // NewTacGiaTextBox
            // 
            this.NewTacGiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTacGiaTextBox.Location = new System.Drawing.Point(184, 13);
            this.NewTacGiaTextBox.Name = "NewTacGiaTextBox";
            this.NewTacGiaTextBox.Size = new System.Drawing.Size(238, 28);
            this.NewTacGiaTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NewBookNameTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sách:";
            // 
            // NewBookNameTextBox
            // 
            this.NewBookNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBookNameTextBox.Location = new System.Drawing.Point(184, 13);
            this.NewBookNameTextBox.Name = "NewBookNameTextBox";
            this.NewBookNameTextBox.Size = new System.Drawing.Size(238, 28);
            this.NewBookNameTextBox.TabIndex = 0;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitAddButton;
            this.ClientSize = new System.Drawing.Size(486, 303);
            this.Controls.Add(this.ExitAddButton);
            this.Controls.Add(this.DoneAddButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBookForm";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitAddButton;
        private System.Windows.Forms.Button DoneAddButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewTacGiaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewBookNameTextBox;
        private System.Windows.Forms.NumericUpDown SoLuongBox;
        private System.Windows.Forms.ComboBox NewTypeBookComboBox;
    }
}
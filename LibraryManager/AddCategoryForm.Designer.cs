namespace LibraryManager
{
    partial class AddCategoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NewCategortyTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitAddButton
            // 
            this.ExitAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitAddButton.Location = new System.Drawing.Point(285, 87);
            this.ExitAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitAddButton.Name = "ExitAddButton";
            this.ExitAddButton.Size = new System.Drawing.Size(74, 29);
            this.ExitAddButton.TabIndex = 17;
            this.ExitAddButton.Text = "Thoát";
            this.ExitAddButton.UseVisualStyleBackColor = true;
            // 
            // DoneAddButton
            // 
            this.DoneAddButton.Location = new System.Drawing.Point(207, 87);
            this.DoneAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.DoneAddButton.Name = "DoneAddButton";
            this.DoneAddButton.Size = new System.Drawing.Size(74, 29);
            this.DoneAddButton.TabIndex = 16;
            this.DoneAddButton.Text = "Xong";
            this.DoneAddButton.UseVisualStyleBackColor = true;
            this.DoneAddButton.Click += new System.EventHandler(this.DoneAddButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NewCategortyTextBox);
            this.panel1.Location = new System.Drawing.Point(11, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 45);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên thể loại:";
            // 
            // NewCategortyTextBox
            // 
            this.NewCategortyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCategortyTextBox.Location = new System.Drawing.Point(138, 11);
            this.NewCategortyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewCategortyTextBox.Name = "NewCategortyTextBox";
            this.NewCategortyTextBox.Size = new System.Drawing.Size(180, 24);
            this.NewCategortyTextBox.TabIndex = 0;
            // 
            // AddCategoryForm
            // 
            this.AcceptButton = this.DoneAddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitAddButton;
            this.ClientSize = new System.Drawing.Size(370, 119);
            this.Controls.Add(this.ExitAddButton);
            this.Controls.Add(this.DoneAddButton);
            this.Controls.Add(this.panel1);
            this.Name = "AddCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thể loại";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitAddButton;
        private System.Windows.Forms.Button DoneAddButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewCategortyTextBox;
    }
}
namespace LibraryManager
{
    partial class AddSupplierForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPhoneTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NewSupplierNameTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.NewAddressTextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitAddButton
            // 
            this.ExitAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitAddButton.Location = new System.Drawing.Point(332, 182);
            this.ExitAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitAddButton.Name = "ExitAddButton";
            this.ExitAddButton.Size = new System.Drawing.Size(74, 29);
            this.ExitAddButton.TabIndex = 17;
            this.ExitAddButton.Text = "Thoát";
            this.ExitAddButton.UseVisualStyleBackColor = true;
            // 
            // DoneAddButton
            // 
            this.DoneAddButton.Location = new System.Drawing.Point(254, 182);
            this.DoneAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.DoneAddButton.Name = "DoneAddButton";
            this.DoneAddButton.Size = new System.Drawing.Size(74, 29);
            this.DoneAddButton.TabIndex = 16;
            this.DoneAddButton.Text = "Xong";
            this.DoneAddButton.UseVisualStyleBackColor = true;
            this.DoneAddButton.Click += new System.EventHandler(this.DoneAddButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.NewPhoneTextBox);
            this.panel2.Location = new System.Drawing.Point(11, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 45);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại:";
            // 
            // NewPhoneTextBox
            // 
            this.NewPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPhoneTextBox.Location = new System.Drawing.Point(138, 11);
            this.NewPhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewPhoneTextBox.Name = "NewPhoneTextBox";
            this.NewPhoneTextBox.Size = new System.Drawing.Size(257, 24);
            this.NewPhoneTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NewSupplierNameTextBox);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 45);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhà cung cấp:";
            // 
            // NewSupplierNameTextBox
            // 
            this.NewSupplierNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSupplierNameTextBox.Location = new System.Drawing.Point(138, 11);
            this.NewSupplierNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewSupplierNameTextBox.Name = "NewSupplierNameTextBox";
            this.NewSupplierNameTextBox.Size = new System.Drawing.Size(257, 24);
            this.NewSupplierNameTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.NewAddressTextBox);
            this.panel3.Location = new System.Drawing.Point(11, 109);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 45);
            this.panel3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            // 
            // NewAddressTextBox
            // 
            this.NewAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAddressTextBox.Location = new System.Drawing.Point(138, 11);
            this.NewAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewAddressTextBox.Name = "NewAddressTextBox";
            this.NewAddressTextBox.Size = new System.Drawing.Size(257, 24);
            this.NewAddressTextBox.TabIndex = 0;
            // 
            // AddSupplierForm
            // 
            this.AcceptButton = this.DoneAddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitAddButton;
            this.ClientSize = new System.Drawing.Size(432, 232);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ExitAddButton);
            this.Controls.Add(this.DoneAddButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSupplierForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitAddButton;
        private System.Windows.Forms.Button DoneAddButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewPhoneTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewSupplierNameTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewAddressTextBox;
    }
}
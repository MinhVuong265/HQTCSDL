namespace LibraryManager
{
    partial class ViewDetailsForm
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
            this.BookListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BookListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookListDataGridView
            // 
            this.BookListDataGridView.AllowUserToAddRows = false;
            this.BookListDataGridView.AllowUserToDeleteRows = false;
            this.BookListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.BookListDataGridView.Name = "BookListDataGridView";
            this.BookListDataGridView.ReadOnly = true;
            this.BookListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookListDataGridView.Size = new System.Drawing.Size(568, 290);
            this.BookListDataGridView.TabIndex = 0;
            // 
            // ViewDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 317);
            this.Controls.Add(this.BookListDataGridView);
            this.Name = "ViewDetailsForm";
            this.Text = "Chi tiết";
            ((System.ComponentModel.ISupportInitialize)(this.BookListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookListDataGridView;
    }
}
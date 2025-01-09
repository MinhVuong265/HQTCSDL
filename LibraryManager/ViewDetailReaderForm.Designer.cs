namespace LibraryManager
{
    partial class ViewDetailReaderForm
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
            this.ReaderDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReaderDataGridView
            // 
            this.ReaderDataGridView.AllowUserToAddRows = false;
            this.ReaderDataGridView.AllowUserToDeleteRows = false;
            this.ReaderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReaderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReaderDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ReaderDataGridView.Name = "ReaderDataGridView";
            this.ReaderDataGridView.ReadOnly = true;
            this.ReaderDataGridView.Size = new System.Drawing.Size(935, 319);
            this.ReaderDataGridView.TabIndex = 0;
            // 
            // ViewDetailReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 343);
            this.Controls.Add(this.ReaderDataGridView);
            this.Name = "ViewDetailReaderForm";
            this.Text = "ViewDetailReaderForm";
            ((System.ComponentModel.ISupportInitialize)(this.ReaderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReaderDataGridView;
    }
}
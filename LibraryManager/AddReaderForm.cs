using LibraryManager.DAL;
using LibraryManager.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class AddReaderForm : Form
    {
        public AddReaderForm()
        {
            InitializeComponent();
        }

        private void DoneAddButton_Click(object sender, EventArgs e)
        {
            string name = FullNameTextBox.Text;
            string telnum = NewTelNumTextBox.Text;
            string address = NewAddressTextBox.Text;

            if (name == "" || telnum == "" || address == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Xác nhận thêm độc giả này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ReaderDAL.Instance.AddReader(name, telnum, address))
                    {
                        Reader ReaderID = ReaderDAL.Instance.GetReader(telnum);
                        if (ReaderDAL.Instance.AddBorrowCard(ReaderID.ReaderId))
                        {
                            MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Thêm độc giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReaderDAL.Instance.RemoveReader(telnum);
                        }
                    }
                    
                }
            }
 
        }

        public void GetTelNum(TextBox telnumtextbox)
        {
            NewTelNumTextBox.Text = telnumtextbox.Text;
        }
    }
}

using LibraryManager.DAL;
using LibraryManager.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class BorrowBookForm : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set { loginAccount = value; } }
        public BorrowBookForm(Account acc)
        {
            loginAccount = acc;
            InitializeComponent();
            LoadBook();
        }

        public delegate void PassData(TextBox Text);
        private void button2_Click(object sender, EventArgs e)
        {
            string telphone = TelPhoneTextBox.Text;

            Reader reader = ReaderDAL.Instance.GetReader(telphone);
            if(TelPhoneTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (reader != null)
                {
                    IdReaderTextBox.Text = reader.ReaderId;
                    NameReaderTextBox.Text = reader.ReaderName;
                    AddressTextBox.Text = reader.ReaderAddress;
                }
                else if (MessageBox.Show("Độc giả không tồn tại!\nThêm độc giả?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    AddReaderForm f = new AddReaderForm();
                    PassData data = new PassData(f.GetTelNum);
                    data(TelPhoneTextBox);
                    f.ShowDialog();
                }
            }  
        }

        void LoadBook()
        {
            ListBookDataGridView.DataSource = BookDAL.Instance.LoadBook();
        }

        private void SearchBookButton_Click(object sender, EventArgs e)
        {
            string id = BookIdTextBox.Text;

            if (id != "")
            {
                ListBookDataGridView.DataSource = BookDAL.Instance.SearchBook(id);
            }
            else LoadBook();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {


            string readerid = IdReaderTextBox.Text;
            string bookid = BookIdTextBox.Text;
            string quanly = loginAccount.UserName;
            if (readerid == "" || bookid == "")
            {
                 MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Xác nhận mượn sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BookBorrowDAL.Instance.BorrowBook(readerid, bookid, quanly))
                    {
                            MessageBox.Show("Mượn sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                         MessageBox.Show("Mượn sách thất bại\nKiểm tra lại thông tin hoặc số lượng sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                }

            
        }

        private void TelPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BookIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}

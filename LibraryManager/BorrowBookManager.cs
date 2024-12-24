using LibraryManager.DAL;
using LibraryManager.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    
    public partial class BorrowBookManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set { loginAccount = value; } }

        BindingSource ReaderList = new BindingSource();
        public BorrowBookManager(Account acc)
        {
            loginAccount = acc;
            InitializeComponent();
            fload();
        }

        public void fload()
        {
            LoadReader();
            ReaderDataGridView.DataSource = ReaderList;
            ReaderBinding();
            //LoadBookBorrowInfo();
        }

        public void LoadReader()
        {
            ReaderList.DataSource = ReaderDAL.Instance.LoadReader();
        }

        private void ReaderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;

            if (numrow >= 0)
            {
                string ReaderID = ReaderDataGridView.Rows[numrow].Cells[0].Value.ToString();

                BookBorrowInfoDataGridView.DataSource = BookBorrowDAL.Instance.LoadBookBorrowInfo(ReaderID);
            }

        }

        public void SearchReaderButton_Click(object sender, EventArgs e)
        {
            string telnum = SearchReaderTextBox.Text;

            if (telnum != "")
            {
                ReaderList.DataSource = ReaderDAL.Instance.SearchReader(telnum);
            }
            else
            {
                LoadReader();
            }
        }

        public void ReaderBinding()
        {
            ReaderIDTextBox.DataBindings.Add(new Binding("Text", ReaderDataGridView.DataSource, "Mã độc giả", true, DataSourceUpdateMode.Never));
            ReaderNameTextBox.DataBindings.Add(new Binding("Text", ReaderDataGridView.DataSource, "Tên độc giả", true, DataSourceUpdateMode.Never));
            TelNumTextBox.DataBindings.Add(new Binding("Text", ReaderDataGridView.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            AddressTextBox.DataBindings.Add(new Binding("Text", ReaderDataGridView.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
        }

        private void UpdateReaderInfoButton_Click(object sender, EventArgs e)
        {
            ReaderNameTextBox.Enabled = true;
            TelNumTextBox.Enabled = true;
            AddressTextBox.Enabled = true;
            DoneButton.Enabled = true;

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            string id = ReaderIDTextBox.Text;
            string name = ReaderNameTextBox.Text;
            string telnum = TelNumTextBox.Text;
            string address = AddressTextBox.Text;

            if (id == "" || name == "" || telnum == "" || address == "")
            {
                MessageBox.Show("Thông tin nhập vào chưa hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Xác nhận cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ReaderDAL.Instance.UpdateReaderInfo(id, name, telnum, address))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadReader();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            ReaderNameTextBox.Enabled = false;
            TelNumTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            DoneButton.Enabled = false;
        }

        private void AddReaderButton_Click(object sender, EventArgs e)
        {
            AddReaderForm f = new AddReaderForm();
            f.ShowDialog();
            LoadReader();
        }

        private void RemoveReaderButton_Click(object sender, EventArgs e)
        {
            string id = ReaderIDTextBox.Text;
            try
            {
                if (MessageBox.Show("Xác nhận xóa độc giả này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ReaderDAL.Instance.RemoveBorrowCard(id) && ReaderDAL.Instance.RemoveReader(id))
                    {
                        MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadReader();
                    }
                    else
                    {
                        MessageBox.Show("Xóa độc giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Vui lòng trả hết sách trước khi xóa độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void RemoveBorrowBookButton_Click(object sender, EventArgs e)
        {
            if(BookBorrowInfoDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không tồn tại sách mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string bookid = BookBorrowInfoDataGridView.CurrentRow.Cells[0].Value.ToString();
                string ngaymuon = BookBorrowInfoDataGridView.CurrentRow.Cells[2].Value.ToString();
                string ngaytra = BookBorrowInfoDataGridView.CurrentRow.Cells[3].Value.ToString();
                string quanly = BookBorrowInfoDataGridView.CurrentRow.Cells[4].Value.ToString();
                string readerid = ReaderDataGridView.CurrentRow.Cells[0].Value.ToString();

                if (MessageBox.Show("Xác nhận trả sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BookBorrowDAL.Instance.DeleteBorrowBoook(bookid, readerid, ngaymuon, ngaytra, quanly))
                    {
                        MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BookBorrowInfoDataGridView.DataSource = BookBorrowDAL.Instance.LoadBookBorrowInfo(readerid);
                    }
                    else
                    {
                        MessageBox.Show("Trả sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BorrowBookButton_Click(object sender, EventArgs e)
        {
            BorrowBookForm f = new BorrowBookForm(loginAccount);
            f.ShowDialog();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

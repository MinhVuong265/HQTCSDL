using LibraryManager.DAL;
using LibraryManager.DTL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class BookManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set { loginAccount = value; AdminTab(loginAccount.Type); } }

        BindingSource BookList = new BindingSource();

        public BookManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            fload();
        }

        void fload()
        {
            
            LoadBook();
            BookShowDataGridView.DataSource = BookList;
            Book_Binding();
            loadBookType();
        }

       
       
        //public void AdminTab(TextBox NameLoginTextBox)
        //{
        //    string username = NameLoginTextBox.Text;
        //    if (AccountDAL.Instance.AdminCheck(username))
        //    {
        //        adminToolStripMenuItem.Enabled = true;
        //    }
        //    else adminToolStripMenuItem.Enabled = false;
        //}

        //ss acc ad hay staff
        public void AdminTab(string type)
        {
            adminToolStripMenuItem.Enabled = type == "admin"; 
        }
        public void LoadBook()
        {
            BookList.DataSource = BookDAL.Instance.LoadBook();
        }

        private void SearchBookButton_Click(object sender, EventArgs e)
        {
            string BookName = SearchTextBox.Text;
            if(SearchTextBox.Text == "")
            {
                LoadBook();
            }
            else BookList.DataSource = BookDAL.Instance.SearchBook(BookName);
        }

        void Book_Binding()
        {
            BookIdTextBox.DataBindings.Add(new Binding("Text", BookShowDataGridView.DataSource, "Mã sách", true, DataSourceUpdateMode.Never));
            BookNameTextBox.DataBindings.Add(new Binding("Text", BookShowDataGridView.DataSource, "Tên sách", true, DataSourceUpdateMode.Never));
            TacGiaTextBox.DataBindings.Add(new Binding("Text", BookShowDataGridView.DataSource, "Tên tác giả", true, DataSourceUpdateMode.Never));
            BookTypeComboBox.DataBindings.Add(new Binding("Text", BookShowDataGridView.DataSource, "Thể loại", true, DataSourceUpdateMode.Never));
            BookTypeIdTextBox.DataBindings.Add(new Binding("Text", BookShowDataGridView.DataSource, "Mã loại", true, DataSourceUpdateMode.Never));
            SoLuongBox.DataBindings.Add(new Binding("Text", BookShowDataGridView.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
        }

        private void RemoveBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                string bookid = BookIdTextBox.Text;
                string bookname = BookNameTextBox.Text;

                //DisplayNameTextBox.Enabled = false;
                //PasswordTextBox.Enabled = false;
                //FixDoneButton.Enabled = false;
                //RemoveAccountButton.Enabled = false;
                //AccountTypeComboBox.Enabled = false;
                //FixAccountButton.Enabled = true;

                if (MessageBox.Show("Xác nhận xóa sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BookDAL.Instance.RemoveBook(bookid, bookname))
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBook();
                    }
                    else MessageBox.Show("Xóa sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xóa sách thất bại do sách đang được mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void UpdateBookButton_Click(object sender, EventArgs e)
        {
            BookNameTextBox.Enabled = true;
            TacGiaTextBox.Enabled = true;
            BookTypeComboBox.Enabled = true;
            UpdateBookButton.Enabled = false;
            SoLuongBox.Enabled = true;
            DoneButton.Enabled = true;

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            try
            {
                string bookid = BookIdTextBox.Text;
                string bookname = BookNameTextBox.Text;
                string tacgia = TacGiaTextBox.Text;
                string theloai = BookTypeComboBox.Text;
                int soluong = Convert.ToInt32(SoLuongBox.Value);

                if (bookid == "" || bookname == "" || tacgia == "" || soluong < 0)
                {
                    MessageBox.Show("Thông tin nhập vào chưa hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Xác nhận cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (BookDAL.Instance.UpdateBook(bookid, bookname, tacgia, theloai, soluong))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBook();
                        }
                        else MessageBox.Show("Cập nhật thất bại! Vui lòng sửa lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Thông tin nhập vào chưa hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            BookNameTextBox.Enabled = false;
            TacGiaTextBox.Enabled = false;
            BookTypeComboBox.Enabled = false;
            SoLuongBox.Enabled = false;
            UpdateBookButton.Enabled = true;
            DoneButton.Enabled = false;
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddBookForm f = new AddBookForm();
            f.ShowDialog();
            LoadBook();
        }



        private void MuonSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBookForm f = new BorrowBookForm(loginAccount);
            f.ShowDialog(this);
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBookManager f = new BorrowBookManager(loginAccount);
            Hide();
            f.ShowDialog();
            LoadBook();
            Show();
        }


        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm a = new AdminForm();
            Hide();
            a.ShowDialog();
            Show();
        }


        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm a = new AccountForm(LoginAccount);
            a.ShowDialog();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm a = new SupplierForm();
            Hide();
            a.ShowDialog();
            Show();
        }
        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm a = new CategoryForm();
            Hide();
            a.ShowDialog();
            Show();
        }
        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        void loadBookType()
        {
            AutoCompleteStringCollection TheLoaiCollection = new AutoCompleteStringCollection();

            DataTable BookType = BookDAL.Instance.GetTheLoai();

            foreach (DataRow item in BookType.Rows)
            {
                TheLoaiCollection.Add(item["Ten"].ToString());
            }

            BookTypeComboBox.DataSource = TheLoaiCollection;
            BookTypeComboBox.AutoCompleteCustomSource = TheLoaiCollection;
            BookTypeComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }



        //khong nhap chu trong BookTypeIdTextBox : id the loai
        private void BookTypeIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BookTypeComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (BookTypeComboBox.FindStringExact(BookTypeComboBox.Text) < 0 && BookTypeComboBox.Text != "")
            {
                MessageBox.Show("Thể loại không hợp lệ!\nVui lòng chọn thể loại được đề xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        
    }
}

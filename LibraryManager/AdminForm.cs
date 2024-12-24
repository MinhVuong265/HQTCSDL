using LibraryManager.DAL;
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
    public partial class AdminForm : Form
    {

        BindingSource AccountList = new BindingSource();
        public AdminForm()
        {
            InitializeComponent();
            fLoad();
        }

        void fLoad()
        {
            AccountdataGridView.DataSource = AccountList;
            LoadAccountList();
            Account_Binding();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void LoadAccountList()
        {
            AccountList.DataSource = AccountDAL.Instance.LoadAccount();

        }

        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            string displayname = SearchNameTextBox.Text;
            if (displayname != "")
            {
                AccountList.DataSource = AccountDAL.Instance.SearchAccount(displayname);
            }
            else LoadAccountList();
        }

        private void FixAccountButton_Click(object sender, EventArgs e)
        {
            DisplayNameTextBox.Enabled = true;
            PasswordTextBox.Enabled = true;
            FixDoneButton.Enabled = true;
            AccountTypeComboBox.Enabled = true;
            FixAccountButton.Enabled = false;
        }

        private void FixDoneButton_Click(object sender, EventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;
            string displayname = DisplayNameTextBox.Text;
            int type = Convert.ToInt32(AccountTypeComboBox.SelectedIndex);

            if (username == "" || displayname == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Xác nhận cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (AccountDAL.Instance.AdminUpdateAccount(username, displayname, password, type))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountList();
                    }
                    else MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            DisplayNameTextBox.Enabled = false;
            PasswordTextBox.Enabled = false;
            FixDoneButton.Enabled = false;
            AccountTypeComboBox.Enabled = false;
            FixAccountButton.Enabled = true;
        }

        void Account_Binding()
        {
            DisplayNameTextBox.DataBindings.Add(new Binding("Text", AccountdataGridView.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
            UserNameTextBox.DataBindings.Add(new Binding("Text", AccountdataGridView.DataSource, "Tên đăng nhập", true, DataSourceUpdateMode.Never));
            AccountTypeComboBox.DataBindings.Add(new Binding("Text", AccountdataGridView.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never));
            PasswordTextBox.DataBindings.Add(new Binding("Text", AccountdataGridView.DataSource, "Mật khẩu", true, DataSourceUpdateMode.Never));
        }

        private void RemoveAccountButton_Click(object sender, EventArgs e)
        {
            string username = UserNameTextBox.Text;
            string displayname = DisplayNameTextBox.Text;

            

            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (AccountDAL.Instance.RemoveAccount(username, displayname))
                {
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccountList();
                }
                else MessageBox.Show("Xóa tài khoản thất bại do tài khoản này đang quản lý sách mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            AddAccountForm f = new AddAccountForm();
            f.ShowDialog();
            LoadAccountList();
        }
    }
}

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
    public partial class AccountForm : Form
    {
        private Account loginAccount;
        public Account LoginAccount { get => loginAccount; set { loginAccount = value; ShowAccountDetail(loginAccount); } }

        public AccountForm(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ShowAccountDetail(Account acc)
        {
            UserNameDetailTextBox.Text = LoginAccount.UserName;
            DisplayNameDetailTextBox.Text = LoginAccount.DisplayName;
        }

        void UpdateAccount()
        {
            string displayname = DisplayNameDetailTextBox.Text;
            string username = UserNameDetailTextBox.Text;
            string password = PasswordTextBox.Text;
            string newpassword = NewPasswordTextBox.Text;
            string newpasswordconfirm = NewPasswordConfirmTextBox.Text;

            if(newpasswordconfirm != newpassword)
            {
                MessageBox.Show("Nhập lại mật khẩu chưa trùng khớp! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(AccountDAL.Instance.UpdateAccount(username, displayname, password, newpassword))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Mật khẩu sai!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
}

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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //public delegate void PassData(TextBox Text);

        public void LoginButton_Click(object sender, EventArgs e)
        {
            string username = NameLoginTextBox.Text;
            string password = PasswordTextBox.Text;
            if (LoginCheck(username,password))
            {
                Account loginAccount = AccountDAL.Instance.GetAccountByUserName(username);
                //BookManager b = new BookManager(loginAccount);
                HomeForm b = new HomeForm(loginAccount);
                //PassData data = new PassData(b.AdminTab);
                //data(NameLoginTextBox);
                this.Hide();
                b.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        bool LoginCheck(string username, string password)
        {
            return AccountDAL.Instance.Login(username,password);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void ShowPassWordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckState state = ShowPassWordCheckBox.CheckState;
            if (state == CheckState.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else PasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}

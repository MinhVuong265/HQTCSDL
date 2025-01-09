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
    public partial class HomeForm : Form
    {
        Account account;
        public HomeForm(Account acc)
        {
            account = acc;
            InitializeComponent();
            NameLabel.Text = string.Format("Xin chào {0}",acc.DisplayName);
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void Book_Click(object sender, EventArgs e)
        {
            BookManager f = new BookManager(account);
            Hide();
            f.ShowDialog();
            Show();
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            SupplierForm f = new SupplierForm();
            Hide(); 
            f.ShowDialog();
            Show();
        }

        private void Reader_Click(object sender, EventArgs e)
        {
            ReaderForm f = new ReaderForm();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            StaffForm f = new StaffForm();
            Hide(); f.ShowDialog();
            Show();
        }
    }
}

using LibraryManager.DAL;
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
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void DoneAddButton_Click(object sender, EventArgs e)
        {
            string name = NewSupplierNameTextBox.Text;
            string phone = NewPhoneTextBox.Text;
            string address = NewAddressTextBox.Text;

            if(name == "" && phone == "" && address == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(name == "")
            {
                MessageBox.Show("Không thể bỏ trống tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(phone == "")
            {
                MessageBox.Show("Không thể để trống số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(MessageBox.Show("Thêm nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(SupplierDAL.Instance.addSupplier(name, phone, address))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại. Kiểm tra lại thông tin nhập vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

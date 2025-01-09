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
    public partial class SupplierForm : Form
    {
        BindingSource SupplierList = new BindingSource();
        public SupplierForm()
        {
            InitializeComponent();
            formLoad();
            SupplierBinding();
        }

        void formLoad()
        {
            LoadSupplier();
            SupplierDataGridView.DataSource = SupplierList;
        }
        void LoadSupplier()
        {
            SupplierList.DataSource = SupplierDAL.Instance.loadSupplier();
        }

        void SupplierBinding()
        {
            IDTextBox.DataBindings.Add(new Binding("Text", SupplierDataGridView.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            NameTextBox.DataBindings.Add(new Binding("Text", SupplierDataGridView.DataSource, "Tên nhà cung cấp", true, DataSourceUpdateMode.Never));
            PhoneTextBox.DataBindings.Add(new Binding("Text", SupplierDataGridView.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            AddressTextBox.DataBindings.Add(new Binding("Text", SupplierDataGridView.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //viết trigger, nếu xóa thì chuyển trạng thái về ngừng hợp tác
            string id = IDTextBox.Text;

            try
            {
                if (MessageBox.Show("Bạn muốn xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SupplierDAL.Instance.deleteSupplier(id))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSupplier();
                    }
                    else MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void EditButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Enabled = true;
            PhoneTextBox.Enabled = true;
            AddressTextBox.Enabled = true;
            DoneButton.Enabled = true;
            CancelButton.Enabled = true;

            AddButton.Enabled = false;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Enabled = false;
            PhoneTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            DoneButton.Enabled = false;
            CancelButton.Enabled = false;

            AddButton.Enabled = true;
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            string id = IDTextBox.Text;
            string name = NameTextBox.Text;
            string phone = PhoneTextBox.Text;
            string address = AddressTextBox.Text;
            if (name == "")
            {
                MessageBox.Show("Không thể để trống tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (phone == "")
            {
                MessageBox.Show("Không thể để trống số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Xác nhận cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SupplierDAL.Instance.updateSupplier(id,name,phone,address))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSupplier();
                    }
                    else MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            NameTextBox.Enabled = false;
            DoneButton.Enabled = false;
            PhoneTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            DoneButton.Enabled = false;
            CancelButton.Enabled = false;

            AddButton.Enabled = true;
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddSupplierForm f = new AddSupplierForm();
            f.ShowDialog();
            LoadSupplier();
        }
    }
}

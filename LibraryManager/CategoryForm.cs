using LibraryManager.DAL;
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
    public partial class CategoryForm : Form
    {

        BindingSource CategoryList = new BindingSource();
        public CategoryForm()
        {
            InitializeComponent();
            formLoad();
            CategoryBinding();
        }

        void formLoad()
        {
            LoadCategory();
            CategoryDataGridView.DataSource = CategoryList;
        }

        void LoadCategory()
        {
            CategoryList.DataSource = CategoryDAL.Instance.loadCategory();
        }

        void CategoryBinding()
        {
            IDTextBox.DataBindings.Add(new Binding("Text", CategoryDataGridView.DataSource, "Mã thể loại", true, DataSourceUpdateMode.Never));
            NameTextBox.DataBindings.Add(new Binding("Text", CategoryDataGridView.DataSource, "Tên thể loại", true, DataSourceUpdateMode.Never));
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddCategoryForm f = new AddCategoryForm();
            f.ShowDialog();
            LoadCategory();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string ID = IDTextBox.Text;
            try
            {
                if (MessageBox.Show("Bạn muốn xóa thể loại này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CategoryDAL.Instance.deleteCategory(ID))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategory();
                    }
                    else MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể xóa do đang tồn tại sách có thể loại này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            NameTextBox.Enabled = true;
            DoneButton.Enabled = true;
            CancelButton.Enabled = true;

            AddButton.Enabled = false;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Enabled =  false;
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

            if(name == "")
            {
                MessageBox.Show("Không thể để trống tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Xác nhận cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CategoryDAL.Instance.updateCategory(id, name))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategory();
                    }
                    else MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            NameTextBox.Enabled = false;
            DoneButton.Enabled = false;
            CancelButton.Enabled = false;

            AddButton.Enabled = true;
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKeForm f = new ThongKeForm();
            Hide();
            f.ShowDialog();
            Show();
        }
    }
}

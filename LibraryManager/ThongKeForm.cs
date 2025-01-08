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
    public partial class ThongKeForm : Form
    {
        BindingSource BookList = new BindingSource();
        public ThongKeForm()
        {
            InitializeComponent();
            formLoad();
            //loadBookType();
            BookDataGridView.DataSource = BookList;
        }

        void formLoad()
        {
            loadBookByCategory();
            BookDataGridView.DataSource = BookList;
        }

        void loadBookByCategory()
        {
            BookList.DataSource = CategoryDAL.Instance.CategoryBookCount();
        }

        //void loadBookType()
        //{
        //    AutoCompleteStringCollection TheLoaiCollection = new AutoCompleteStringCollection();

        //    DataTable category = CategoryDAL.Instance.loadCategory();

        //    foreach (DataRow item in category.Rows)
        //    {
        //        TheLoaiCollection.Add(item["Ten"].ToString());
        //    }
        //    CategoryComboBox.Text = TheLoaiCollection[0].ToString();
        //    CategoryComboBox.DataSource = TheLoaiCollection;
        //    CategoryComboBox.AutoCompleteCustomSource = TheLoaiCollection;
        //    CategoryComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //}

        //private void BookTypeComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{

        //}

        //private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    string name = CategoryComboBox.SelectedItem.ToString();

        //    BookList.DataSource = CategoryDAL.Instance.CategoryBookCount();
        //}

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (BookDataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị từ cột đầu tiên của hàng được chọn
                string name = BookDataGridView.SelectedRows[0].Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(name))
                {
                    // Truyền tên sang form ViewDetailsForm
                    ViewDetailsForm f = new ViewDetailsForm(name);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Không thể lấy giá trị từ cột đầu tiên của hàng được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để thực hiện thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

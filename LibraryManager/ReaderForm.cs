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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManager
{
    public partial class ReaderForm : Form
    {
        BindingSource ReaderList = new BindingSource();
        public ReaderForm()
        {
            InitializeComponent();
            formLoad();
        }

        void formLoad()
        {
            loadReader();
            ReaderDataGridView.DataSource = ReaderList;
            ReaderBinding();
        }

        void loadReader()
        {
            ReaderList.DataSource = ReaderDAL.Instance.LoadReader();
        }

        private void SearchBookButton_Click(object sender, EventArgs e)
        {

            string phone = SearchTextBox.Text;
            if(phone == "")
            {
                loadReader();
            }
            else
            {
                ReaderList.DataSource = ReaderDAL.Instance.SearchReader(phone);
            }
            
        }

        void ReaderBinding()
        {
            IDTextBox.DataBindings.Add(new Binding("Text", ReaderDataGridView.DataSource, "ID", true, DataSourceUpdateMode.Never));
            NameTextBox.DataBindings.Add(new Binding("Text", ReaderDataGridView.DataSource, "Họ tên", true, DataSourceUpdateMode.Never));
            PhoneTextBox.DataBindings.Add(new Binding("Text", ReaderDataGridView.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            AddressTextBox.DataBindings.Add(new Binding("Text", ReaderDataGridView.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            textBox1.DataBindings.Add(new Binding("Text", ReaderDataGridView.DataSource, "Tổng sách mượn", true, DataSourceUpdateMode.Never));
        }

        private void ViewDetailButton_Click(object sender, EventArgs e)
        {
            string phone = PhoneTextBox.Text;
            ViewDetailReaderForm f = new ViewDetailReaderForm(phone);
            f.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddReaderForm f = new AddReaderForm();
            f.ShowDialog();
        }
    }
}

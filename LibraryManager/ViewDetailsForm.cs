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
    public partial class ViewDetailsForm : Form
    {
        public ViewDetailsForm(string name)
        {
            InitializeComponent();
            BookListDataGridView.DataSource = CategoryDAL.Instance.BookByCategory(name);
        }
    }
}

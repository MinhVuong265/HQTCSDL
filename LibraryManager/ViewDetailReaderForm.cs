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
    public partial class ViewDetailReaderForm : Form
    {
        BindingSource ReaderList = new BindingSource();
        public ViewDetailReaderForm(string phone)
        {
            InitializeComponent();
            formLoad(phone);
        }

        void formLoad(string phone)
        {
            loadReader(phone);
            ReaderDataGridView.DataSource = ReaderList;
        }

        void loadReader(string phone)
        {
            ReaderList.DataSource = ReaderDAL.Instance.getBorrowBookByPhone(phone);
        }

    }
}

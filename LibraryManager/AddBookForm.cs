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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            loadBookType();
        }

        private void DoneAddButton_Click(object sender, EventArgs e)
        {
            string bookname = NewBookNameTextBox.Text;
            string tacgia = NewTacGiaTextBox.Text;
            string tenloai = NewTypeBookComboBox.Text;
            int soluong = Convert.ToInt32(SoLuongBox.Text);
            

            if(bookname == "" || tacgia == "" || tenloai == "" || soluong < 0)
            {
                Close();
            }
            else
            {
                if (MessageBox.Show("Thêm sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BookDAL.Instance.AddBook(bookname, tacgia, tenloai, soluong))
                    {
                        MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            
        }

        void loadBookType()
        {
            AutoCompleteStringCollection TheLoaiCollection = new AutoCompleteStringCollection();

            DataTable BookType = BookDAL.Instance.GetTheLoai();

            foreach (DataRow item in BookType.Rows)
            {
                TheLoaiCollection.Add(item["TenLoai"].ToString());
            }
            
            NewTypeBookComboBox.DataSource = TheLoaiCollection;
            NewTypeBookComboBox.AutoCompleteCustomSource = TheLoaiCollection;
            NewTypeBookComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void NewTypeBookComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (NewTypeBookComboBox.FindStringExact(NewTypeBookComboBox.Text) < 0 && NewTypeBookComboBox.Text != "")
            {
                MessageBox.Show("Thể loại không hợp lệ!\nVui lòng chọn thể loại được đề xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }
    }
}

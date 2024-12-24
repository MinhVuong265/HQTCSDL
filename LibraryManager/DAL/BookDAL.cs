using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DAL
{
    public class BookDAL
    {
        private static BookDAL instance;
        public static BookDAL Instance
        {
            get { if (instance == null) instance = new BookDAL(); return instance; }
            private set { instance = value; }
        }

        public DataTable LoadBook()
        {
            string query = "select Sach.MaSach as [Mã sách], Sach.TenSach as [Tên sách], Sach.TenTacGia as [Tên tác giả], TheLoai.TenLoai as [Thể loại], Sach.MaLoai as [Mã loại], Sach.SoLuong as [Số lượng] from Sach, TheLoai where Sach.MaLoai = TheLoai.MaLoai";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;

        }

        public DataTable GetBookType()
        {
            string query = "select MaLoai as [Mã loại] from Sach";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }

        public DataTable SearchBook(string search_info)
        {
            string query = "exec Search_Book @search_info ";

            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {search_info});

            return result;
        }

        public string GetMaLoai(string TenLoai)
        {
            string query = $"Select MaLoai from TheLoai where TenLoai = N'{TenLoai}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data.Rows[0].ToString();
        }

        public bool AddBook(string book_name, string tacgia_name, string tenloai, int soluong)
        {
            string query = string.Format("exec Add_Book @tensach , @tentacgia , @tenloai , @soluong ");

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { book_name, tacgia_name, tenloai, soluong });

            return result > 0;
        }

        public bool RemoveBook(string book_id, string book_name)
        {
            string query = string.Format("delete from Sach where MaSach = {0} and TenSach = N'{1}'", book_id, book_name);

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateBook(string book_id, string book_name, string tacgia, string theloai, int soluong )
        {
            string query = string.Format("exec Update_Book @masach , @tensach , @tentacgia , @tenloai , @soluong ");

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {book_id, book_name, tacgia, theloai, soluong});

            return result>0;
        }

        public DataTable GetTheLoai()
        {
            string query = "Select * from TheLoai";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }
    }
}

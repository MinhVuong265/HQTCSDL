using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManager.DAL
{
    internal class BookBorrowDAL
    {
        private static BookBorrowDAL instance;
        public static BookBorrowDAL Instance
        {
            get { if (instance == null) instance = new BookBorrowDAL(); return instance; }
            private set { instance = value; }
        }
   

        public DataTable LoadBookBorrowInfo(string ReaderID)
        {
            string query = $"select SachMuon.MaSach as [Mã sách], Sach.TenSach as [Tên sách], SachMuon.NgayMuon as [Ngày mượn], SachMuon.NgayTra as [Ngày trả], TaiKhoan.TenHienThi as [Tên quản lý] from SachMuon, TheMuon, Sach, DocGia, QuanLy, TaiKhoan where SachMuon.MaThe = TheMuon.MaThe and SachMuon.MaSach = Sach.MaSach and TheMuon.MaDocGia = DocGia.MaDocGia and DocGia.MaDocGia = {ReaderID} and SachMuon.MaQuanLy = QuanLy.MaQuanLy and QuanLy.TenDangNhap = TaiKhoan.TenDangNhap";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }

        public bool DeleteBorrowBoook(string bookid, string readerid, string ngaymuon, string ngaytra, string quanly)
        {
            string query = $"exec Delete_BorrowBook {bookid}, {readerid}, '{ngaymuon}', '{ngaytra}', '{quanly}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool BorrowBook(string readerid, string bookid, string quanly)
        {
            string query = $"exec Borrow_Book {readerid}, {bookid}, '{quanly}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }


    }
}

using LibraryManager.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DAL
{
    internal class ReaderDAL
    {
        private static ReaderDAL instance;
        public static ReaderDAL Instance
        {
            get { if (instance == null) instance = new ReaderDAL(); return instance; }
            private set { instance = value; }
        }

        public DataTable LoadReader()
        {
            string query = "select MaDocGia as [Mã độc giả], TenDocGia as [Tên độc giả], SoDienThoai as [Số điện thoại], DiaChi as [Địa chỉ] from DocGia";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }
        public DataTable SearchReader(string telnumber)
        {
            string query = $"select MaDocGia as [Mã độc giả], TenDocGia as [Tên độc giả], SoDienThoai as [Số điện thoại], DiaChi as [Địa chỉ] from DocGia where SoDienThoai = '{telnumber}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public bool UpdateReaderInfo(string id, string name, string telnum, string address)
        {
            string query = string.Format("update DocGia set TenDocGia = N'{0}', SoDienThoai = N'{1}', DiaChi = N'{2}' where MaDocGia = {3}", name, telnum, address, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool AddReader(string name, string telnum, string address)
        {
            string query = $"insert into DocGia (TenDocGia, SoDienThoai, DiaChi) values (N'{name}', '{telnum}', N'{address}')";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }


        public bool AddBorrowCard(string ReaderId)
        {
            string query = $"insert into TheMuon (MaDocGia) values ({ReaderId})";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool RemoveBorrowCard(string ReaderId)
        {
            string query = $"delete from TheMuon where MaDocGia = {ReaderId}";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool RemoveReader(string readerid)
        {
            string query = $"delete from DocGia where MaDocGia = {readerid}";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public Reader GetReader(string telnumber)
        {
            string query = $"select MaDocGia, TenDocGia, SoDienThoai, DiaChi from DocGia where SoDienThoai = '{telnumber}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                return new Reader(item);
            }
            return null;
        }
    }
}

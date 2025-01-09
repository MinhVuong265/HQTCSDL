using LibraryManager.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            string query = "select ID as [ID], HoTen as [Họ tên], SoDienThoai as [Số điện thoại], DiaChi as [Địa chỉ], TongSachMuon as [Tổng sách mượn] from DocGia_SoSachMuon";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }
        

        public DataTable getBorrowBookByPhone(string phone)
        {
            string query = string.Format("select * from ChiTietSachMuon where IDDocGia = dbo.LayChiTietSachMuon('{0}')", phone);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }

        public DataTable SearchReader(string telnumber)
        {
            string query = $"select ID as [ID], HoTen as [Họ tên], SoDienThoai as [Số điện thoại], DiaChi as [Địa chỉ], TongSachMuon as [Tổng sách mượn] from DocGia_SoSachMuon where SoDienThoai = '{telnumber}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public bool AddReader(string name, string telnum, string address)
        {
            string query = string.Format("exec Add_Docgia @Ten, @SoDienThoai, @DiaChi");


            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { name, telnum, address });

            return result > 0;
        }

        //



        public bool UpdateReaderInfo(string id, string name, string telnum, string address)
        {
            string query = string.Format("update DocGia set TenDocGia = N'{0}', SoDienThoai = N'{1}', DiaChi = N'{2}' where MaDocGia = {3}", name, telnum, address, id);
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

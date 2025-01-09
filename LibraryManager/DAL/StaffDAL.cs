using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DAL
{
    internal class StaffDAL
    {
        private static StaffDAL instance;
        public static StaffDAL Instance
        {
            get { if (instance == null) instance = new StaffDAL(); return instance; }
            private set { instance = value; }
        }

        public DataTable getBaoCao(int thang, int nam)
        {
            string query = "SELECT * FROM BaoCao WHERE Thang = @Thang AND Nam = @Nam";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { thang, nam });
        }

        public bool updateBaoCao(int thang, int nam)
        {
            string query = "EXEC sp_CapNhatTongSachMuon @Thang, @Nam";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { thang, nam });
            return result > 0; 
        }
        public DataTable getStaffAccByID(string id)
        {
            string query = string.Format("select * from fn_GetNhanVienTaiKhoan({0})", id);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }

        public DataTable getStaffBySumBorrow(int quantity)
        {
            string query = string.Format("select * from dbo.GetNhanVienWithBooksBorrowedMoreThan({0})", quantity);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }

        public bool updateDate(string bookID, string staffID, string returnDate, string borrowDate, string borrowBookID)
        {
            string query = "exec UpdateNgayMuonNgayTra  @IDSach, @IDNhanVien, @NgayTra , @NgayMuon, @IDSachMuon";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { bookID, staffID, returnDate, borrowDate, borrowBookID }); ;
            return result > 0;
        }

        

    }
}

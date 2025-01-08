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
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { instance = value; }
        }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @username , @password";
            
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {username,password});

            return result.Rows.Count > 0;
        }

        public bool AdminCheck(string username)
        {
            string query = "Select * from TaiKhoan where TenDangNhap = N'" + username + "' and LoaiTK = 1";

            DataTable result = DataProvider.Instance.ExcuteQuery(query);

            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Select TenDangNhap, MatKhau, LoaiTK, HoTen from TaiKhoan, NhanVien where TenDangNhap = '" + username + "'" + "and TaiKhoan.IDNhanVien = NhanVien.ID");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public DataTable LoadAccount()
        {
            string query = "select TaiKhoan.TenHienThi as [Tên hiển thị], TaiKhoan.TenDangNhap as [Tên đăng nhập], TaiKhoan.MatKhau as [Mật khẩu], Account_Type.TenTK as [Loại tài khoản] from TaiKhoan, Account_Type where TaiKhoan.LoaiTK = Account_Type.LoaiTk";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public bool UpdateAccount(string username, string displayname, string pass, string newpass)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("exec USP_UpdateAccount @username , @displayname , @password , @newpassword ", new object[] { username, displayname, pass, newpass});

            return result>0;
        }

        public DataTable SearchAccount(string displayname)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("exec Search_Account @displayname", new object[] {displayname});
            return data;
        }

        public bool AdminUpdateAccount(string username, string displayname, string password, int type)
        {
            string query = string.Format("update TaiKhoan set TenHienThi = N'{0}', MatKhau = '{1}', LoaiTK = {2} where TenDangNhap = '{3}'", displayname, password, type, username);

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool RemoveAccount(string username, string displayname)
        {
            string query = string.Format("exec Remove_Account '{0}', N'{1}'",username,displayname);

            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result>1;
        }

        public bool AddAccount(string username, string displayname, string password, int type)
        {
            string query = "exec Add_Account @username , @displayname , @password , @type ";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {username, displayname, password, type});
            return result>0;
        }
    }
}

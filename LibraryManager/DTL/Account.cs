using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DTL
{
    public class Account
    {
        public Account(string userName, string displayName, string type, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.UserName = row["TenDangNhap"].ToString();
            this.DisplayName = row["HoTen"].ToString();
            this.Type = row["LoaiTK"].ToString();
            this.Password = row["MatKhau"].ToString();
        }

        private string displayName;

        private string userName;

        private string password;

        private string type;

        public string UserName
        {
            get { return userName; } 
            set { userName = value; }
        }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
    }
}

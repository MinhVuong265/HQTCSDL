using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DAL
{
    internal class SupplierDAL
    {
        private static SupplierDAL instance;
        public static SupplierDAL Instance
        {
            get { if (instance == null) instance = new SupplierDAL(); return instance; }
            private set { instance = value; }
        }

        public DataTable loadSupplier()
        {
            string query = "exec proc_ThongKeNhaCungCap";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            return dt;
        }

        public bool deleteSupplier(string id)
        {
            string query = string.Format("Delete from NhaCungCap where ID = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool addSupplier(string name, string phone, string address)
        {
            string query = string.Format("Insert into NhaCungCap values (N'{0}', '{1}', N'{2}', N'Hoạt động')", name, phone, address);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool updateSupplier(string id, string name, string phone , string address)
        {
            string query = string.Format("Update NhaCungCap set Ten = N'{0}', SoDienThoai = '{1}', DiaChi = N'{2}' where ID = '{3}'", name, phone, address, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
             
            return result > 0;
        }
    }
}

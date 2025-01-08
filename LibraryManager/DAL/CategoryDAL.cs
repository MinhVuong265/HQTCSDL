using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.DAL
{
    internal class CategoryDAL
    {
        private static CategoryDAL instance;
        public static CategoryDAL Instance
        {
            get { if (instance == null) instance = new CategoryDAL(); return instance; }
            private set { instance = value; }
        }

        public DataTable loadCategory()
        {
            string query = "select ID as N'Mã thể loại', Ten as N'Tên thể loại' from TheLoai";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            return dt;

        }

        public bool deleteCategory(string id)
        {
            string query = string.Format("delete from TheLoai where ID = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result>0;
        }

        public bool updateCategory(string id, string name)
        {
            string query = string.Format("update TheLoai set Ten = N'{0}' where ID = {1}", name, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result>0;
        }

        public string addCategory(string name)
        {
            string query = string.Format("insert into TheLoai values (N'{0}')", name);
            int result = 0;
            try
            {
                result = DataProvider.Instance.ExcuteNonQuery(query);

                if(result>0)
                {
                    return string.Empty;
                }
                else
                {
                    return "Thêm thất bại!";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message;
                //MessageBox.Show(ex.Message,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }

        public DataTable CategoryBookCount()
        {
            string query = ("select * from view_CategoryBookCount");
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            return dt;
        }

        public DataTable BookByCategory(string name)
        {
            string query = string.Format("select * from dbo.BookByCategory(N'{0}')", name);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            return dt;
        }

        
    }
}

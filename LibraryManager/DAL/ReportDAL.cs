using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DAL
{
    internal class ReportDAL
    {
        private static ReportDAL instance;
        public static ReportDAL Instance
        {
            get { if (instance == null) instance = new ReportDAL(); return instance; }
            private set { instance = value; }
        }

        public DataTable loadReport()
        {
            string query = "select * from View_BaoCao_NhanVien";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            return dt;
        }

        public DataTable loadReportWithFilter(string year, string income)
        {
            string query = string.Format("select * from View_BaoCao_NhanVien where Nam = {0} and DoanhThu > {1}", year, income);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            return dt; 
        }

        public DataTable getReportByStaff(string id)
        {
            string query = string.Format("Select * from View_NhanVien_SachMuon where NhanVienID = {0}", id);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            return dt;
        }
    }
}

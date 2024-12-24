using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DTL
{
    public class Reader
    {
        public Reader(string id, string telnum, string name, string address)
        {
            ReaderId = id;
            ReaderTelnum = telnum;
            ReaderName = name;
            ReaderAddress = address;
        }

        public Reader(DataRow row)
        {
            ReaderId = row["MaDocGia"].ToString();
            ReaderTelnum = row["SoDienThoai"].ToString();
            ReaderName = row["TenDocGia"].ToString();
            ReaderAddress = row["DiaChi"].ToString();
        }

        private string readerId;
        private string readerName;
        private string readerTelnum;
        private string readerAddress;

        public string ReaderId { get => readerId; set => readerId = value; }
        public string ReaderTelnum { get => readerTelnum; set => readerTelnum = value; }
        public string ReaderAddress { get => readerAddress; set => readerAddress = value; }
        public string ReaderName { get => readerName; set => readerName = value; }
    }
}

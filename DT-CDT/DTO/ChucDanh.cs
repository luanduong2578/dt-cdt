using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    public class ChucDanh
    {

        public ChucDanh(int ChucDanhid, string ChucDanhTen, string ChucDanhTenVietTat)
        {
            this.ChucDanhid = ChucDanhid;
            this.ChucDanhTen = ChucDanhTen;
            this.ChucDanhTenVietTat = ChucDanhTenVietTat;
        }

       public ChucDanh(DataRow row)
        {
            this.ChucDanhid = (int)row["ChucDanhid"];
            this.ChucDanhTen = row["ChucDanhTen"].ToString();
            this.ChucDanhTenVietTat = row["ChucDanhTenVietTat"].ToString();
        }
        public ChucDanh()
        {

        }
        private int chucDanhid;
        public int ChucDanhid
        {
            get { return chucDanhid; }
            set { chucDanhid = value; }
        }
        private string chucDanhTen;

        public string ChucDanhTen
        {
            get { return chucDanhTen; }
            set { chucDanhTen = value; }
        }
        private string chucDanhTenVietTat;

        public string ChucDanhTenVietTat
        {
            get { return chucDanhTenVietTat; }
            set { chucDanhTenVietTat = value; }
        }


    }
}

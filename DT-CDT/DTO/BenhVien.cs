using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    public class BenhVien
    {

        public BenhVien(int DonViid, string DonViTen, string DonViTenVietTat)
        {
            this.DonViid = DonViid;
            this.DonViTen = DonViTen;
            this.DonViTenVietTat = DonViTenVietTat;
        }

        public BenhVien(DataRow row)
        {
            this.DonViid = (int)row["DonViid"];
            this.DonViTen = row["DonViTen"].ToString();
            this.DonViTenVietTat = row["DonViTenVietTat"].ToString();

        }

        

        private string donViTenVietTat;

        public string DonViTenVietTat
        {
            get { return donViTenVietTat; }
            set { donViTenVietTat = value; }
        }

        private string donViTen;

        public string DonViTen
        {
            get { return donViTen; }
            set { donViTen = value; }
        }
        private int donViid;

        public int DonViid
        {
            get { return donViid; }
            set { donViid = value; }
        }
        

    }
}

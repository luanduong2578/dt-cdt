using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    public class KhoaPhong
    {
        public KhoaPhong(int KhoaPhongid, int IdDonVi, string KhoaPhongTen, string KhoaPhongVietTat)
        {
            this.KhoaPhongid = KhoaPhongid;
            this.IdDonVi = IdDonVi;
            this.KhoaPhongTen = KhoaPhongTen;
            this.KhoaPhongVietTat = KhoaPhongVietTat;
        }

        public KhoaPhong(DataRow row)
        {
            this.KhoaPhongid = (int)row["KhoaPhongid"];
            this.IdDonVi = (int)row["IdDonVi"];
            this.KhoaPhongTen = row["KhoaPhongTen"].ToString();
            this.KhoaPhongVietTat = row["KhoaPhongVietTat"].ToString();
        }

        private int khoaPhongid;

        public int KhoaPhongid
        {
            get { return khoaPhongid; }
            set { khoaPhongid = value; }
        }
        private int idDonVi;

        public int IdDonVi
        {
            get { return idDonVi; }
            set { idDonVi = value; }
        }
        private string khoaPhongTen;

        public string KhoaPhongTen
        {
            get { return khoaPhongTen; }
            set { khoaPhongTen = value; }
        }
        private string khoaPhongVietTat;

        public string KhoaPhongVietTat
        {
            get { return khoaPhongVietTat; }
            set { khoaPhongVietTat = value; }
        }
        

        
    }
}

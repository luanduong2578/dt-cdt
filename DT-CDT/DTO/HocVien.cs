using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    public  class HocVien
    {
        public HocVien(int HocVienid, int IdChucDanh, int IdDonVi, int IdKhoaPhong, string HocVienHoten, string HocVienNamSinh, int HocVienPhai, string HocVienDienThoai, string HocVienGhiChu, string HocVienEmail)
        {
            this.HocVienid = HocVienid;
            this.IdChucDanh = IdChucDanh;
            this.IdDonVi = IdDonVi;
            this.IdKhoaPhong = IdKhoaPhong;
            this.HocVienHoten = HocVienHoten;
            this.HocVienNamSinh = HocVienNamSinh;
            this.HocVienPhai = HocVienPhai;
            this.HocVienDienThoai = HocVienDienThoai;
            this.HocVienGhiChu = HocVienGhiChu;
            this.HocVienEmail = HocVienEmail;

        }
        public HocVien(DataRow row)
        {
            this.HocVienid = (int)row["HocVienid"];
            this.IdChucDanh = (int)row["IdChucDanh"];
            this.IdDonVi = (int)row["IdDonVi"];
            this.IdKhoaPhong = (int)row["IdKhoaPhong"];
            this.HocVienHoten = row["HocVienHoten"].ToString();
            this.HocVienNamSinh = row["HocVienNamSinh"].ToString();
            this.HocVienPhai = (int)row["HocVienPhai"];
            this.HocVienDienThoai = row["HocVienDienThoai"].ToString();
            this.HocVienGhiChu = row["HocVienGhiChu"].ToString();
            this.HocVienEmail = row["HocVienEmail"].ToString();

        }


        private string hocVienEmail;

        public string HocVienEmail
        {
            get { return hocVienEmail; }
            set { hocVienEmail = value; }
        }
        private string hocVienGhiChu;

        public string HocVienGhiChu
        {
            get { return hocVienGhiChu; }
            set { hocVienGhiChu = value; }
        }
        private string hocVienDienThoai;

        public string HocVienDienThoai
        {
            get { return hocVienDienThoai; }
            set { hocVienDienThoai = value; }
        }
        private int hocVienPhai;

        public int HocVienPhai
        {
            get { return hocVienPhai; }
            set { hocVienPhai = value; }
        }
        private string hocVienNamSinh;

        public string HocVienNamSinh
        {
            get { return hocVienNamSinh; }
            set { hocVienNamSinh = value; }
        }
        private string hocVienHoten;

        public string HocVienHoten
        {
            get { return hocVienHoten; }
            set { hocVienHoten = value; }
        }
        private int idKhoaPhong;

        public int IdKhoaPhong
        {
            get { return idKhoaPhong; }
            set { idKhoaPhong = value; }
        }
        private int idDonVi;

        public int IdDonVi
        {
            get { return idDonVi; }
            set { idDonVi = value; }
        }
        private int idChucDanh;
        public int IdChucDanh
        {
            get { return idChucDanh; }
            set { idChucDanh = value; }
        }
        private int hocVienid;
        public int HocVienid
        {
            get { return hocVienid; }
            set { hocVienid = value; }
        }
    }
}

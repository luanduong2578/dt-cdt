using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    class LopHoc
    {

        public LopHoc(int LopHocid, int NamLopHoc, string NoiDungHoc, int BVToChuc, string KhoaPhong, DateTime NgayBatDauLopHoc, DateTime NgayKetThucLopHoc, string ThoiGianHoc, string ThoiGianHocLyThuy, string ThoiGianHocThcHanh, string DiaDiemHoc, string DoiTuongHoc, string NguoiHuongDan, string KinhPhi, string ChiGiaoVien, string ChiNuocUong, string ChiKhac, string GhiChu)
        {
            this.LopHocid = LopHocid;
            this.NamLopHoc = NamLopHoc;
            this.NoiDungHoc = NoiDungHoc;
            this.BVToChuc = BVToChuc;
            this.KhoaPhong = KhoaPhong;
            this.NgayBatDauLopHoc = NgayBatDauLopHoc;
            this.NgayKetThucLopHoc = NgayKetThucLopHoc;
            this.ThoiGianHoc = ThoiGianHoc;
            this.ThoiGianHocLyThuy = ThoiGianHocLyThuy;
            this.ThoiGianHocThcHanh = ThoiGianHocThcHanh;
            this.DiaDiemHoc = DiaDiemHoc;
            this.DoiTuongHoc = DoiTuongHoc;
            this.NguoiHuongDan = NguoiHuongDan;
            this.KinhPhi = KinhPhi;
            this.ChiGiaoVien = ChiGiaoVien;
            this.ChiNuocUong = ChiNuocUong;
            this.ChiKhac = ChiKhac;
            this.GhiChu = GhiChu;
        }

         public LopHoc(DataRow row)
        {
            this.LopHocid = (int)row["LopHocid"];
            this.NamLopHoc = (int)row["NamLopHoc"];
            this.NoiDungHoc = row["NoiDungHoc"].ToString();
            this.BVToChuc = (int)row["BVToChuc"];
            this.KhoaPhong = row["KhoaPhong"].ToString();
            this.NgayBatDauLopHoc = (DateTime)row["NgayBatDauLopHoc"];
            this.NgayKetThucLopHoc = (DateTime)row["NgayKetThucLopHoc"];
            this.ThoiGianHoc = row["ThoiGianHoc"].ToString();
            this.ThoiGianHocLyThuy = row["ThoiGianHocLyThuy"].ToString();
            this.ThoiGianHocThcHanh = row["ThoiGianHocThcHanh"].ToString();
            this.DiaDiemHoc = row["DiaDiemHoc"].ToString();
            this.DoiTuongHoc = row["DoiTuongHoc"].ToString();
            this.NguoiHuongDan = row["NguoiHuongDan"].ToString();
            this.KinhPhi = row["KinhPhi"].ToString();
            this.ChiGiaoVien = row["ChiGiaoVien"].ToString();
            this.ChiNuocUong = row["ChiNuocUong"].ToString();
            this.ChiKhac = row["ChiKhac"].ToString();
            this.GhiChu = row["GhiChu"].ToString();

           
             

        }
         private string ghiChu;

         public string GhiChu
         {
             get { return ghiChu; }
             set { ghiChu = value; }
         }
         private string chiKhac;

         public string ChiKhac
         {
             get { return chiKhac; }
             set { chiKhac = value; }
         }
         private string chiNuocUong;

         public string ChiNuocUong
         {
             get { return chiNuocUong; }
             set { chiNuocUong = value; }
         }
         private string chiGiaoVien;

         public string ChiGiaoVien
         {
             get { return chiGiaoVien; }
             set { chiGiaoVien = value; }
         }
         private string kinhPhi;

         public string KinhPhi
         {
             get { return kinhPhi; }
             set { kinhPhi = value; }
         }
         private string nguoiHuongDan;

         public string NguoiHuongDan
         {
             get { return nguoiHuongDan; }
             set { nguoiHuongDan = value; }
         }
         private string doiTuongHoc;

         public string DoiTuongHoc
         {
             get { return doiTuongHoc; }
             set { doiTuongHoc = value; }
         }
         private string diaDiemHoc;

         public string DiaDiemHoc
         {
             get { return diaDiemHoc; }
             set { diaDiemHoc = value; }
         }
         private string thoiGianHocThcHanh;

         public string ThoiGianHocThcHanh
         {
             get { return thoiGianHocThcHanh; }
             set { thoiGianHocThcHanh = value; }
         }
         private string thoiGianHocLyThuy;

         public string ThoiGianHocLyThuy
         {
             get { return thoiGianHocLyThuy; }
             set { thoiGianHocLyThuy = value; }
         }
         private string thoiGianHoc;

         public string ThoiGianHoc
         {
             get { return thoiGianHoc; }
             set { thoiGianHoc = value; }
         }
         private DateTime ngayKetThucLopHoc;

         public DateTime NgayKetThucLopHoc
         {
             get { return ngayKetThucLopHoc; }
             set { ngayKetThucLopHoc = value; }
         }
         private DateTime ngayBatDauLopHoc;

         public DateTime NgayBatDauLopHoc
         {
             get { return ngayBatDauLopHoc; }
             set { ngayBatDauLopHoc = value; }
         }

         private string khoaPhong;

         public string KhoaPhong
         {
             get { return khoaPhong; }
             set { khoaPhong = value; }
         }
         private int bVToChuc;

         public int BVToChuc
         {
             get { return bVToChuc; }
             set { bVToChuc = value; }
         }
         private string noiDungHoc;

         public string NoiDungHoc
         {
             get { return noiDungHoc; }
             set { noiDungHoc = value; }
         }
         private int namLopHoc;

         public int NamLopHoc
         {
             get { return namLopHoc; }
             set { namLopHoc = value; }
         }
         private int lopHocid;

         public int LopHocid
         {
             get { return lopHocid; }
             set { lopHocid = value; }
         }
    }
}

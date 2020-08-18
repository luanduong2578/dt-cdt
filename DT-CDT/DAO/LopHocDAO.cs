using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class LopHocDAO
    {
        private static LopHocDAO instance;

        public static LopHocDAO Instance
        {
            get {if(instance == null) instance = new LopHocDAO(); return LopHocDAO.instance; }
            private set { LopHocDAO.instance = value; }
        }
        private LopHocDAO() { }

        public string LoadNamHienTai()
        {
            DateTime now = DateTime.Now;
            return (now.Year).ToString();
        }


        public DataTable LoadLopHoc(int NamLH)
        {
            string query = string.Format("SELECT LopHocid as [MaLop],NamLopHoc as [Năm Học], LoaiDT as [Loại đào tạo], NoiDungHoc as [Tên Lớp],(select dvct.DonViTen from DonVi dvct where dvct.DonViid = lh.BVToChuc)  [BV tổ chức lớp],KhoaPhong as [Khoa phòng tổ chức],NguoiHuongDan as [GV hướng dẫn],DoiTuongHoc as [Đối tượng học],NgayBatDauLopHoc as [Ngày bắt đầu],NgayKetThucLopHoc as [Ngày kết thúc],ThoiGianHoc as [Thời gian học],ThoiGianHocLyThuy as [Thời gian Lý thuyết] ,ThoiGianHocThcHanh as [Thời gian thực hành],DiaDiemHoc as [Địa điểm học],KinhPhi as [Kinh phí],ChiGiaoVien as [Chi GV],ChiNuocUong as [Chi nước uống],ChiKhac as [Chi khác],GhiChu as [Ghi chú] FROM LopHoc lh where NamLopHoc  ={0}", NamLH);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        
        public DataTable SearchLHbyTuNamDenNam(int tunam, int dennam)
        {
            string query = string.Format("SELECT LopHocid as [MaLop],NamLopHoc as [Năm Học],LoaiDT as [Loại đào tạo], NoiDungHoc [Tên Lớp],(select dvct.DonViTen from DonVi dvct where dvct.DonViid = lh.BVToChuc)  [BV tổ chức lớp],KhoaPhong as [Khoa phòng tổ chức],NguoiHuongDan as [GV hướng dẫn],DoiTuongHoc as [Đối tượng học],NgayBatDauLopHoc as [Ngày bắt đầu],NgayKetThucLopHoc as [Ngày kết thúc],ThoiGianHoc as [Thời gian học],ThoiGianHocLyThuy as [Thời gian Lý thuyết] ,ThoiGianHocThcHanh as [Thời gian thực hành],DiaDiemHoc as [Địa điểm học],KinhPhi as [Kinh phí],ChiGiaoVien as [Chi GV],ChiNuocUong as [Chi nước uống],ChiKhac as [Chi khác],GhiChu as [Ghi chú] FROM LopHoc lh where lh.NamLopHoc >= {0} and lh.NamLopHoc <= {1}", tunam, dennam);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchLHbyTenLop(int tunam, int dennam, string tenlop)
        {
            string query = string.Format(" SELECT LopHocid as [MaLop],NamLopHoc as [Năm Học],LoaiDT as [Loại đào tạo], NoiDungHoc [Tên Lớp],(select dvct.DonViTen from DonVi dvct where dvct.DonViid = lh.BVToChuc)  [BV tổ chức lớp],KhoaPhong as [Khoa phòng tổ chức],NguoiHuongDan as [GV hướng dẫn],DoiTuongHoc as [Đối tượng học],NgayBatDauLopHoc as [Ngày bắt đầu],NgayKetThucLopHoc as [Ngày kết thúc],ThoiGianHoc as [Thời gian học],ThoiGianHocLyThuy as [Thời gian Lý thuyết] ,ThoiGianHocThcHanh as [Thời gian thực hành],DiaDiemHoc as [Địa điểm học],KinhPhi as [Kinh phí],ChiGiaoVien as [Chi GV],ChiNuocUong as [Chi nước uống],ChiKhac as [Chi khác],GhiChu as [Ghi chú] FROM LopHoc lh where lh.NamLopHoc >= {0} and lh.NamLopHoc <= {1} and + dbo.fuConvertToUnsign1(NoiDungHoc) LIKE N'%' + dbo.fuConvertToUnsign1(N'{2}') + '%'", tunam, dennam, tenlop);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchLHbyGV(int tunam, int dennam, string GV)
        {
            string query = string.Format(" SELECT LopHocid as [MaLop],NamLopHoc as [Năm Học],LoaiDT as [Loại đào tạo], NoiDungHoc [Tên Lớp],(select dvct.DonViTen from DonVi dvct where dvct.DonViid = lh.BVToChuc)  [BV tổ chức lớp],KhoaPhong as [Khoa phòng tổ chức],NguoiHuongDan as [GV hướng dẫn],DoiTuongHoc as [Đối tượng học],NgayBatDauLopHoc as [Ngày bắt đầu],NgayKetThucLopHoc as [Ngày kết thúc],ThoiGianHoc as [Thời gian học],ThoiGianHocLyThuy as [Thời gian Lý thuyết] ,ThoiGianHocThcHanh as [Thời gian thực hành],DiaDiemHoc as [Địa điểm học],KinhPhi as [Kinh phí],ChiGiaoVien as [Chi GV],ChiNuocUong as [Chi nước uống],ChiKhac as [Chi khác],GhiChu as [Ghi chú] FROM LopHoc lh where lh.NamLopHoc >= {0} and lh.NamLopHoc <= {1} and + dbo.fuConvertToUnsign1(NguoiHuongDan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{2}') + '%'", tunam, dennam, GV);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertLopHoc(int NamLopHoc, string NoiDungHoc, int BVToChuc, string KhoaPhong, string NguoiHuongDan, string DoiTuongHoc, DateTime NgayBatDauLopHoc, DateTime NgayKetThucLopHoc, string ThoiGianHoc, string ThoiGianHocLyThuy, string ThoiGianHocThcHanh, string DiaDiemHoc, string KinhPhi, string ChiGiaoVien, string ChiNuocUong, string ChiKhac, string GhiChu, string LoaiDT)
        {
            string query = string.Format("insert into LopHoc (NamLopHoc, NoiDungHoc ,BVToChuc, KhoaPhong, NguoiHuongDan,  DoiTuongHoc ,  NgayBatDauLopHoc,  NgayKetThucLopHoc ,  ThoiGianHoc ,  ThoiGianHocLyThuy , ThoiGianHocThcHanh,  DiaDiemHoc ,  KinhPhi ,  ChiGiaoVien , ChiNuocUong ,  ChiKhac , GhiChu, LoaiDT) values ({0}, N'{1}', {2}, N'{3}',N'{4}', N'{5}','{6}','{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}',  N'{14}', N'{15}', N'{16}', N'{17}')", NamLopHoc, NoiDungHoc, BVToChuc, KhoaPhong, NguoiHuongDan, DoiTuongHoc, NgayBatDauLopHoc, NgayKetThucLopHoc, ThoiGianHoc, ThoiGianHocLyThuy, ThoiGianHocThcHanh, DiaDiemHoc, KinhPhi, ChiGiaoVien, ChiNuocUong, ChiKhac, GhiChu, LoaiDT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateLopHoc(int NamLopHoc, string NoiDungHoc, int BVToChuc, string KhoaPhong, string NguoiHuongDan, string DoiTuongHoc, DateTime NgayBatDauLopHoc, DateTime NgayKetThucLopHoc, string ThoiGianHoc, string ThoiGianHocLyThuy, string ThoiGianHocThcHanh, string DiaDiemHoc, string KinhPhi, string ChiGiaoVien, string ChiNuocUong, string ChiKhac, string GhiChu, string LoaiDT, int LopHocid)
        {
            string query = string.Format("UPDATE LopHoc SET NamLopHoc = {0}, NoiDungHoc =N'{1}',BVToChuc = {2}, KhoaPhong = N'{3}', NguoiHuongDan =N'{4}',  DoiTuongHoc = N'{5}',  NgayBatDauLopHoc = '{6}',  NgayKetThucLopHoc ='{7}',  ThoiGianHoc = N'{8}',  ThoiGianHocLyThuy =N'{9}', ThoiGianHocThcHanh =N'{10}',  DiaDiemHoc = N'{11}',  KinhPhi =N'{12}',  ChiGiaoVien =N'{13}', ChiNuocUong = N'{14}',  ChiKhac = N'{15}', GhiChu = N'{16}' , LoaiDT = N'{17}' where  LopHocid  = {18}", NamLopHoc, NoiDungHoc ,BVToChuc, KhoaPhong, NguoiHuongDan,  DoiTuongHoc ,  NgayBatDauLopHoc,  NgayKetThucLopHoc ,  ThoiGianHoc ,  ThoiGianHocLyThuy , ThoiGianHocThcHanh,  DiaDiemHoc ,  KinhPhi ,  ChiGiaoVien , ChiNuocUong ,  ChiKhac , GhiChu,LoaiDT, LopHocid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        
        public bool DeleteLopHoc(int LHid)
        {
            string query = string.Format("Delete LopHoc where LopHocid = {0}", LHid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool CheckBV( int id)
        {
            string query = string.Format("select * from DonVi where DonViid = {0}",id);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}





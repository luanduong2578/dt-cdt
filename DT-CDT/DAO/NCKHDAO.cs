using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DT_CDT.DAO
{
    class NCKHDAO
    {
        private static NCKHDAO instance;

        public static NCKHDAO Instance
        {
            get {if(instance == null) instance = new NCKHDAO(); return NCKHDAO.instance; }
            private set { NCKHDAO.instance = value; }
        }
        private NCKHDAO() { }
        
        public DataTable LoadNCKH(int nam)
        {
            string query = string.Format("SELECT MCKHMASO AS MA_NCKH,NAM AS NAM_NC,LDT.LOAIDETAITEN AS LOAI_ĐT,HV.HOCVIENHOTEN AS CHU_NHIEM,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU1) as CONG_SU_1,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU2) as CONG_SU_2,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU3) as CONG_SU_3,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU4) as CONG_SU_4,TENDETAI AS TEN_DE_TAI ,MUCTIEU AS MUC_TIEU_NC,KP.KHOAPHONGTEN AS KHOA_PHONG,LV.LVNCTEN as LINH_VUC_NC,CDT.CAPDTTEN as CAP_DE_TAI, THOIGIANDUKIENTU AS THOI_GIAN_BD,THOIGIANDUKIENDEN AS THOI_GIAN_KT,KINHPHI AS KINH_PHI,TTDT.TTDTTEN as TINH_TRANG_DT,NGHIEMTHUDECUONG AS NGAY_NGHIEM_THU_DC,NGHIEMTHUDETAI AS NGAY_NGHIEM_THU_DT,KETQUANGHIEMTHU AS KET_QUA_NC, GHICHU AS GHI_CHU FROM HSOFTDKBD.DT_NCKH NC left join HSOFTDKBD.DT_HOCVIEN HV on HV.HOCVIENID = NC.CHUNHIEM left join HSOFTDKBD.DT_KHOAPHONG KP on KP.KHOAPHONGID = NC.IDKHOAPHONG left JOIN HSOFTDKBD.DT_LINHVUCNGHIENCUU LV on LV.LVNCID = NC.LINHVUCNGHIENCUU left join HSOFTDKBD.DT_CAPDETAI CDT on CDT.CAPDTID = NC.CAPDETAI left join HSOFTDKBD.DT_TINHTRANGDETAI TTDT on TTDT.TTDTID = NC.TINHTRANGDETAI left join HSOFTDKBD.DT_LOAIDETAI LDT on LDT.IDLOAIDETAI = NC.LOAIDETAI where NAM ={0}", nam);
           return DataProvider.Instance.ExecuteQuery(query);
        }
       public DataTable SearchNCKHbyTuNamDenNam(int tunam, int dennam)
        {
            string query = string.Format("SELECT MCKHMASO AS MA_NCKH,NAM AS NAM_NC,LDT.LOAIDETAITEN AS LOAI_ĐT,HV.HOCVIENHOTEN AS CHU_NHIEM,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU1) as CONG_SU_1,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU2) as CONG_SU_2,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU3) as CONG_SU_3,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU4) as CONG_SU_4,TENDETAI AS TEN_DE_TAI ,MUCTIEU AS MUC_TIEU_NC,KP.KHOAPHONGTEN AS KHOA_PHONG,LV.LVNCTEN as LINH_VUC_NC,CDT.CAPDTTEN as CAP_DE_TAI, THOIGIANDUKIENTU AS THOI_GIAN_BD,THOIGIANDUKIENDEN AS THOI_GIAN_KT,KINHPHI AS KINH_PHI,TTDT.TTDTTEN as TINH_TRANG_DT,NGHIEMTHUDECUONG AS NGAY_NGHIEM_THU_DC,NGHIEMTHUDETAI AS NGAY_NGHIEM_THU_DT,KETQUANGHIEMTHU AS KET_QUA_NC, GHICHU AS GHI_CHU FROM HSOFTDKBD.DT_NCKH NC left join HSOFTDKBD.DT_HOCVIEN HV on HV.HOCVIENID = NC.CHUNHIEM left join HSOFTDKBD.DT_KHOAPHONG KP on KP.KHOAPHONGID = NC.IDKHOAPHONG left JOIN HSOFTDKBD.DT_LINHVUCNGHIENCUU LV on LV.LVNCID = NC.LINHVUCNGHIENCUU left join HSOFTDKBD.DT_CAPDETAI CDT on CDT.CAPDTID = NC.CAPDETAI left join HSOFTDKBD.DT_TINHTRANGDETAI TTDT on TTDT.TTDTID = NC.TINHTRANGDETAI left join HSOFTDKBD.DT_LOAIDETAI LDT on LDT.IDLOAIDETAI = NC.LOAIDETAI where NAM >= {0} and NAM <= {1}", tunam, dennam);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchNCKHbyTenDT(int tunam, int dennam, string tendt)
        {
            string query = string.Format("SELECT MCKHMASO AS MA_NCKH,NAM AS NAM_NC,LDT.LOAIDETAITEN AS LOAI_ĐT,HV.HOCVIENHOTEN AS CHU_NHIEM,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU1) as CONG_SU_1,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU2) as CONG_SU_2,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU3) as CONG_SU_3,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU4) as CONG_SU_4,TENDETAI AS TEN_DE_TAI ,MUCTIEU AS MUC_TIEU_NC,KP.KHOAPHONGTEN AS KHOA_PHONG,LV.LVNCTEN as LINH_VUC_NC,CDT.CAPDTTEN as CAP_DE_TAI, THOIGIANDUKIENTU AS THOI_GIAN_BD,THOIGIANDUKIENDEN AS THOI_GIAN_KT,KINHPHI AS KINH_PHI,TTDT.TTDTTEN as TINH_TRANG_DT,NGHIEMTHUDECUONG AS NGAY_NGHIEM_THU_DC,NGHIEMTHUDETAI AS NGAY_NGHIEM_THU_DT,KETQUANGHIEMTHU AS KET_QUA_NC, GHICHU AS GHI_CHU FROM HSOFTDKBD.DT_NCKH NC left join HSOFTDKBD.DT_HOCVIEN HV on HV.HOCVIENID = NC.CHUNHIEM left join HSOFTDKBD.DT_KHOAPHONG KP on KP.KHOAPHONGID = NC.IDKHOAPHONG left JOIN HSOFTDKBD.DT_LINHVUCNGHIENCUU LV on LV.LVNCID = NC.LINHVUCNGHIENCUU left join HSOFTDKBD.DT_CAPDETAI CDT on CDT.CAPDTID = NC.CAPDETAI left join HSOFTDKBD.DT_TINHTRANGDETAI TTDT on TTDT.TTDTID = NC.TINHTRANGDETAI left join HSOFTDKBD.DT_LOAIDETAI LDT on LDT.IDLOAIDETAI = NC.LOAIDETAI where NAM >= {0} and Nam <= {1} and UPPER(NC.TENDETAI) LIKE UPPER('%{2}%')", tunam, dennam, tendt);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchNCKHbyTenNV(int tunam, int dennam, string tenNV)
        {
            string query = string.Format("SELECT MCKHMASO AS MA_NCKH,NAM AS NAM_NC,LDT.LOAIDETAITEN AS LOAI_ĐT,HV.HOCVIENHOTEN AS CHU_NHIEM,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU1) as CONG_SU_1,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU2) as CONG_SU_2,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU3) as CONG_SU_3,(select HV1.HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN HV1 where HV1.HOCVIENID = NC.CONGSU4) as CONG_SU_4,TENDETAI AS TEN_DE_TAI ,MUCTIEU AS MUC_TIEU_NC,KP.KHOAPHONGTEN AS KHOA_PHONG,LV.LVNCTEN as LINH_VUC_NC,CDT.CAPDTTEN as CAP_DE_TAI, THOIGIANDUKIENTU AS THOI_GIAN_BD,THOIGIANDUKIENDEN AS THOI_GIAN_KT,KINHPHI AS KINH_PHI,TTDT.TTDTTEN as TINH_TRANG_DT,NGHIEMTHUDECUONG AS NGAY_NGHIEM_THU_DC,NGHIEMTHUDETAI AS NGAY_NGHIEM_THU_DT,KETQUANGHIEMTHU AS KET_QUA_NC, GHICHU AS GHI_CHU FROM HSOFTDKBD.DT_NCKH NC left join HSOFTDKBD.DT_HOCVIEN HV on HV.HOCVIENID = NC.CHUNHIEM left join HSOFTDKBD.DT_KHOAPHONG KP on KP.KHOAPHONGID = NC.IDKHOAPHONG left JOIN HSOFTDKBD.DT_LINHVUCNGHIENCUU LV on LV.LVNCID = NC.LINHVUCNGHIENCUU left join HSOFTDKBD.DT_CAPDETAI CDT on CDT.CAPDTID = NC.CAPDETAI left join HSOFTDKBD.DT_TINHTRANGDETAI TTDT on TTDT.TTDTID = NC.TINHTRANGDETAI left join HSOFTDKBD.DT_LOAIDETAI LDT on LDT.IDLOAIDETAI = NC.LOAIDETAI where NAM >= {0} and Nam <= {1} and UPPER(NC.NHANVIEN) LIKE UPPER('%{2}%')", tunam, dennam, tenNV);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public string LoadNamNCKH()
        {
            DateTime now = DateTime.Now;
            return (now.Year).ToString();                       
        }

        public bool InsertNCKH(int Nam, int LoaiDeTai, int ChuNhiem, int? CongSu1, int? CongSu2, int? CongSu3, int? CongSu4, string TenDeTai, string MucTieu, int KhoaPhong, int LinhVucNghienCuu, int CapDeTai, string ThoiGianDuKienTu, string ThoiGianDuKienDen, string KinhPhi, int TinhTrangDeTai, string NghiemThuDeCuong, string NghiemThuDetai, string KetQuaNghiemThu, string GhiChu, string NhanVien)
        {
            
            
            if (Count_NCKH() == 1)
            {
                string query = string.Format("INSERT INTO HSOFTDKBD.DT_NCKH (NCKHID, NAM,LOAIDETAI,CHUNHIEM,CONGSU1,CONGSU2,CONGSU3,CONGSU4,TENDETAI,MUCTIEU,IDKHOAPHONG,LINHVUCNGHIENCUU,CAPDETAI,THOIGIANDUKIENTU,THOIGIANDUKIENDEN,KINHPHI,TINHTRANGDETAI,NGHIEMTHUDECUONG,NGHIEMTHUDETAI,KETQUANGHIEMTHU,GHICHU,NHANVIEN,MCKHMASO) VALUES (1,{0},{1},{2},{3},{4},{5},{6},'{7}','{8}',{9},{10},{11},'{12}','{13}','{14}',{15},'{16}',N'{17}','{18}','{19}','{20}','NCKH0001')", Nam, LoaiDeTai, ChuNhiem, CongSu1, CongSu2, CongSu3, CongSu4, TenDeTai, MucTieu, KhoaPhong, LinhVucNghienCuu, CapDeTai, ThoiGianDuKienTu, ThoiGianDuKienDen, KinhPhi, TinhTrangDeTai, NghiemThuDeCuong, NghiemThuDetai, KetQuaNghiemThu, GhiChu, NhanVien);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            else
            {
                string MCKHMASO = "";
                if (GetHCKId() < 10)
                {
                    MCKHMASO = string.Format("NCKH000{0}", GetHCKId().ToString());
                }
                else if (GetHCKId() < 100)
                {
                    MCKHMASO = string.Format("NCKH00{0}", GetHCKId().ToString());
                }
                else if (GetHCKId() < 1000)
                {
                    MCKHMASO = string.Format("NCKH0{0}", GetHCKId().ToString());
                }
                else
                {
                    MCKHMASO = string.Format("NCKH{0}", GetHCKId().ToString());
                }
                string query = string.Format("INSERT INTO HSOFTDKBD.DT_NCKH (NCKHID, NAM,LOAIDETAI,CHUNHIEM,CONGSU1,CONGSU2,CONGSU3,CONGSU4,TENDETAI,MUCTIEU,IDKHOAPHONG,LINHVUCNGHIENCUU,CAPDETAI,THOIGIANDUKIENTU,THOIGIANDUKIENDEN,KINHPHI,TINHTRANGDETAI,NGHIEMTHUDECUONG,NGHIEMTHUDETAI,KETQUANGHIEMTHU,GHICHU,NHANVIEN, MCKHMASO) VALUES ((SELECT MAX(NCKHID)+1 FROM HSOFTDKBD.DT_NCKH),{0},{1},{2},{3},{4},{5},{6},'{7}','{8}',{9},{10},{11},'{12}','{13}','{14}',{15},'{16}','{17}','{18}','{19}','{20}','{21}')", Nam, LoaiDeTai, ChuNhiem, CongSu1, CongSu2, CongSu3, CongSu4, TenDeTai, MucTieu, KhoaPhong, LinhVucNghienCuu, CapDeTai, ThoiGianDuKienTu, ThoiGianDuKienDen, KinhPhi, TinhTrangDeTai, NghiemThuDeCuong, NghiemThuDetai, KetQuaNghiemThu, GhiChu, NhanVien, MCKHMASO);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
        }        
        
        public bool UpdateNCKH(int Nam, int LoaiDeTai, int ChuNhiem, int? CongSu1, int? CongSu2, int? CongSu3, int? CongSu4, string TenDeTai, string MucTieu, int KhoaPhong, int LinhVucNghienCuu, int CapDeTai, string ThoiGianDuKienTu, string ThoiGianDuKienDen, string KinhPhi, int TinhTrangDeTai, string NghiemThuDeCuong, string NghiemThuDetai, string KetQuaNghiemThu, string GhiChu, string NhanVien,int nckhid)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_NCKH SET NAM = {0},LOAIDETAI= {1},CHUNHIEM = {2},CONGSU1 = {3},CONGSU2 = {4},CONGSU3 = {5},CONGSU4 = {6},TENDETAI ='{7}' ,MUCTIEU ='{8}' ,IDKHOAPHONG = {9},LINHVUCNGHIENCUU = {10},CAPDETAI = {11},THOIGIANDUKIENTU = '{12}',THOIGIANDUKIENDEN = '{13}',KINHPHI = '{14}',TINHTRANGDETAI = {15},NGHIEMTHUDECUONG = '{16}',NGHIEMTHUDETAI = '{17}',KETQUANGHIEMTHU ='{18}' ,GHICHU ='{19}' ,NHANVIEN ='{20}' where NCKHID = {21}", Nam, LoaiDeTai, ChuNhiem, CongSu1, CongSu2, CongSu3, CongSu4, TenDeTai, MucTieu, KhoaPhong, LinhVucNghienCuu, CapDeTai, ThoiGianDuKienTu, ThoiGianDuKienDen, KinhPhi, TinhTrangDeTai, NghiemThuDeCuong, NghiemThuDetai, KetQuaNghiemThu, GhiChu, NhanVien, nckhid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteNCKH(int NCKHid)
        {
            string query = string.Format("Delete HSOFTDKBD.DT_NCKH where NCKHID = {0}", NCKHid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

//kiem tra hoc vien khi insert hoc vien
        public int Count_NCKH()
        {
            string query = string.Format("select COUNT(NCKHID)+1 from HSOFTDKBD.DT_NCKH");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public int GetHCKIdByMANCKH(string MANCKH)
        {
            string query = string.Format("select NCKHID from HSOFTDKBD.DT_NCKH where MCKHMASO = '{0}'", MANCKH);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public int GetHCKId()
        {
            string query = string.Format("select MAX(NCKHID) from HSOFTDKBD.DT_NCKH");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }




    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class DSLopSKHKDAO
    {
        private static DSLopSKHKDAO instance;

        public static DSLopSKHKDAO Instance
        {
            get { if (instance == null) instance = new DSLopSKHKDAO(); return DSLopSKHKDAO.instance; }
            private set { DSLopSKHKDAO.instance = value; }
        }
        private DSLopSKHKDAO() { }

        public string LoadNamHienTai()
        {
            DateTime now = DateTime.Now;
            return (now.Year).ToString();
        }


        public DataTable LoadLopHoc(int NamLH)
        {
            string query = string.Format(" SELECT SHKHMASO as MA_LOP,NAMLOPHOC as NAM_HOC, NOIDUNGHOC as NOI_DUNG_HOC,(select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = lh.BVTOCHUCID)  DV_MO_LOP, (SELECT KHOAPHONGTEN FROM  HSOFTDKBD.DT_KHOAPHONG KP WHERE  KP.KHOAPHONGID = LH.KHOAPHONGID) as KHOA_PHONG_MO_LOP, HV.HOCVIENHOTEN as GV_HUONG_DAN, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = HV.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = HV.HOCVIENID) as KHOA_PHONG_CONG_TAC, TROGIANGPHOIHOP AS TRO_GIANG_PHOI_HOP, DOITUONGHOC as DOI_TUONG_HOC,NGAYBATDAULOPHOC as NGAY_BAT_DAU,NGAYKETTHUCLOPHOC as NGAY_KET_THUC,THOIGIANHOC as THOI_GIAN_HOC,THOIGIANHOCLYTHUYET as THOI_GIAN_LT ,THOIGIANHOCTHUCHANH as THOI_GIAN_TH,(SELECT CNDTTEN FROM hsoftdkbd.DT_CNDAOTAO  LCNDT WHERE LCNDT.CNDTID = LH.LOAICHUNGNHAN) AS LOAI_CHUNG_NHAN, DIADIEMHOC as DIA_DIEM_HOC,KINHPHI as KINH_PHI,CHIGIANGVIEN as CHI_GV,CHINUOCUONG as CHI_NUOC_UONG,CHIKHAC as CHI_KHAC,GHICHU as GHI_CHU FROM HSOFTDKBD.DT_DSLOPSHKH lh LEFT JOIN HSOFTDKBD.DT_HOCVIEN HV ON HV.HOCVIENID = LH.IDNGUOIHUONGDAN where LH.NAMLOPHOC  ={0} ORDER BY  SHKHMASO ASC", NamLH);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchLHbyTuNamDenNam(int tunam, int dennam)
        {
            string query = string.Format(" SELECT SHKHMASO as MA_LOP,NAMLOPHOC as NAM_HOC, NOIDUNGHOC as NOI_DUNG_HOC,(select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = lh.BVTOCHUCID)  DV_MO_LOP, (SELECT KHOAPHONGTEN FROM  HSOFTDKBD.DT_KHOAPHONG KP WHERE  KP.KHOAPHONGID = LH.KHOAPHONGID) as KHOA_PHONG_MO_LOP, HV.HOCVIENHOTEN as GV_HUONG_DAN, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = HV.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = HV.HOCVIENID) as KHOA_PHONG_CONG_TAC, TROGIANGPHOIHOP AS TRO_GIANG_PHOI_HOP, DOITUONGHOC as DOI_TUONG_HOC,NGAYBATDAULOPHOC as NGAY_BAT_DAU,NGAYKETTHUCLOPHOC as NGAY_KET_THUC,THOIGIANHOC as THOI_GIAN_HOC,THOIGIANHOCLYTHUYET as THOI_GIAN_LT ,THOIGIANHOCTHUCHANH as THOI_GIAN_TH,(SELECT CNDTTEN FROM hsoftdkbd.DT_CNDAOTAO  LCNDT WHERE LCNDT.CNDTID = LH.LOAICHUNGNHAN) AS LOAI_CHUNG_NHAN, DIADIEMHOC as DIA_DIEM_HOC,KINHPHI as KINH_PHI,CHIGIANGVIEN as CHI_GV,CHINUOCUONG as CHI_NUOC_UONG,CHIKHAC as CHI_KHAC,GHICHU as GHI_CHU FROM HSOFTDKBD.DT_DSLOPSHKH lh LEFT JOIN HSOFTDKBD.DT_HOCVIEN HV ON HV.HOCVIENID = LH.IDNGUOIHUONGDAN where LH.NAMLOPHOC >= {0} and LH.NAMLOPHOC <= {1} ORDER BY  SHKHMASO ASC", tunam, dennam);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int GetHCKIdByDTTLMASO(string mahck)
        {
            string query = string.Format("select DSLOPSHKHID from HSOFTDKBD.DT_DSLOPSHKH where SHKHMASO = '{0}'", mahck);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }


        public DataTable SearchLHbyTenLop(int tunam, int dennam, string tenlop)
        {
            string query = string.Format(" SELECT SHKHMASO as MA_LOP,NAMLOPHOC as NAM_HOC, NOIDUNGHOC as NOI_DUNG_HOC,(select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = lh.BVTOCHUCID)  DV_MO_LOP, (SELECT KHOAPHONGTEN FROM  HSOFTDKBD.DT_KHOAPHONG KP WHERE  KP.KHOAPHONGID = LH.KHOAPHONGID) as KHOA_PHONG_MO_LOP, HV.HOCVIENHOTEN as GV_HUONG_DAN, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = HV.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = HV.HOCVIENID) as KHOA_PHONG_CONG_TAC, TROGIANGPHOIHOP AS TRO_GIANG_PHOI_HOP, DOITUONGHOC as DOI_TUONG_HOC,NGAYBATDAULOPHOC as NGAY_BAT_DAU,NGAYKETTHUCLOPHOC as NGAY_KET_THUC,THOIGIANHOC as THOI_GIAN_HOC,THOIGIANHOCLYTHUYET as THOI_GIAN_LT ,THOIGIANHOCTHUCHANH as THOI_GIAN_TH,(SELECT CNDTTEN FROM hsoftdkbd.DT_CNDAOTAO  LCNDT WHERE LCNDT.CNDTID = LH.LOAICHUNGNHAN) AS LOAI_CHUNG_NHAN, DIADIEMHOC as DIA_DIEM_HOC,KINHPHI as KINH_PHI,CHIGIANGVIEN as CHI_GV,CHINUOCUONG as CHI_NUOC_UONG,CHIKHAC as CHI_KHAC,GHICHU as GHI_CHU FROM HSOFTDKBD.DT_DSLOPSHKH lh LEFT JOIN HSOFTDKBD.DT_HOCVIEN HV ON HV.HOCVIENID = LH.IDNGUOIHUONGDAN where LH.NAMLOPHOC >= {0} and LH.NAMLOPHOC <= {1} and + UPPER(NOIDUNGHOC) LIKE UPPER('%{2}%') ORDER BY  SHKHMASO ASC", tunam, dennam, tenlop);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchLHbyGV(int tunam, int dennam, string GV)
        {
            string query = string.Format(" SELECT SHKHMASO as MA_LOP,NAMLOPHOC as NAM_HOC, NOIDUNGHOC as NOI_DUNG_HOC,(select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = lh.BVTOCHUCID)  DV_MO_LOP, (SELECT KHOAPHONGTEN FROM  HSOFTDKBD.DT_KHOAPHONG KP WHERE  KP.KHOAPHONGID = LH.KHOAPHONGID) as KHOA_PHONG_MO_LOP, HV.HOCVIENHOTEN as GV_HUONG_DAN, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = HV.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = HV.HOCVIENID) as KHOA_PHONG_CONG_TAC, TROGIANGPHOIHOP AS TRO_GIANG_PHOI_HOP, DOITUONGHOC as DOI_TUONG_HOC,NGAYBATDAULOPHOC as NGAY_BAT_DAU,NGAYKETTHUCLOPHOC as NGAY_KET_THUC,THOIGIANHOC as THOI_GIAN_HOC,THOIGIANHOCLYTHUYET as THOI_GIAN_LT ,THOIGIANHOCTHUCHANH as THOI_GIAN_TH,(SELECT CNDTTEN FROM hsoftdkbd.DT_CNDAOTAO  LCNDT WHERE LCNDT.CNDTID = LH.LOAICHUNGNHAN) AS LOAI_CHUNG_NHAN, DIADIEMHOC as DIA_DIEM_HOC,KINHPHI as KINH_PHI,CHIGIANGVIEN as CHI_GV,CHINUOCUONG as CHI_NUOC_UONG,CHIKHAC as CHI_KHAC,GHICHU as GHI_CHU FROM HSOFTDKBD.DT_DSLOPSHKH lh LEFT JOIN HSOFTDKBD.DT_HOCVIEN HV ON HV.HOCVIENID = LH.IDNGUOIHUONGDAN lh where LH.NAMLOPHOC >= {0} and LH.NAMLOPHOC <= {1} and + UPPER(NGUOIHUONGDAN) LIKE  UPPER('%{2}%') ORDER BY  SHKHMASO ASC", tunam, dennam, GV);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertLopHoc(int NamLopHoc, string NoiDungHoc, int BVToChuc, int KhoaPhong, string TROGIANGPHOIHOP, string DoiTuongHoc, string NgayBatDauLopHoc, string NgayKetThucLopHoc, string ThoiGianHoc, string ThoiGianHocLyThuy, string ThoiGianHocThcHanh, string DiaDiemHoc, string KinhPhi, string ChiGiaoVien, string ChiNuocUong, string ChiKhac, string GhiChu, int LOAIDTID, int IDNGUOIHUONGDAN, int LOAICHUNGNHAN)

        {
            if (Count_LopHoc() == 0)
            {
                string query = string.Format("insert into  HSOFTDKBD.DT_DSLOPSHKH (DSLOPSHKHID, NAMLOPHOC, NOIDUNGHOC ,BVTOCHUCID, KHOAPHONGID, TROGIANGPHOIHOP,  DOITUONGHOC ,  NGAYBATDAULOPHOC,  NGAYKETTHUCLOPHOC ,  THOIGIANHOC ,  THOIGIANHOCLYTHUYET , THOIGIANHOCTHUCHANH,  DIADIEMHOC ,  KINHPHI ,  CHIGIANGVIEN , CHINUOCUONG ,  CHIKHAC , GHICHU, LOAIDTID, IDNGUOIHUONGDAN, LOAICHUNGNHAN, SHKHMASO) values (1, {0}, '{1}', {2}, {3},'{4}', '{5}',to_date('{6}','dd/MM/yyyy'),to_date('{7}','dd/MM/yyyy'), '{8}', '{9}', '{10}', '{11}', '{12}', '{13}',  '{14}', '{15}', '{16}', {17},{18},{19},'SHKH0001')", NamLopHoc, NoiDungHoc, BVToChuc, KhoaPhong, TROGIANGPHOIHOP, DoiTuongHoc, NgayBatDauLopHoc, NgayKetThucLopHoc, ThoiGianHoc, ThoiGianHocLyThuy, ThoiGianHocThcHanh, DiaDiemHoc, KinhPhi, ChiGiaoVien, ChiNuocUong, ChiKhac, GhiChu, LOAIDTID, IDNGUOIHUONGDAN, LOAICHUNGNHAN);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            else
            {
                string SHKHMASO = "";
                if (MAX_LHID() < 10)
                {
                    SHKHMASO = string.Format("SHKH000{0}", MAX_LHID().ToString());
                }
                else if (MAX_LHID() < 100)
                {
                    SHKHMASO = string.Format("SHKH00{0}", MAX_LHID().ToString());
                }
                else if (MAX_LHID() < 1000)
                {
                    SHKHMASO = string.Format("SHKH0{0}", MAX_LHID().ToString());
                }
                else
                {
                    SHKHMASO = string.Format("SHKH{0}", MAX_LHID().ToString());
                }

                string query = string.Format("insert into  HSOFTDKBD.DT_DSLOPSHKH (  DSLOPSHKHID, NAMLOPHOC, NOIDUNGHOC ,BVTOCHUCID, KHOAPHONGID, TROGIANGPHOIHOP,  DOITUONGHOC ,              NGAYBATDAULOPHOC,          NGAYKETTHUCLOPHOC ,  THOIGIANHOC ,  THOIGIANHOCLYTHUYET , THOIGIANHOCTHUCHANH,  DIADIEMHOC ,  KINHPHI ,  CHIGIANGVIEN , CHINUOCUONG ,  CHIKHAC , GHICHU, LOAIDTID,IDNGUOIHUONGDAN, LOAICHUNGNHAN, SHKHMASO) values ((select max(DSLOPSHKHID) + 1 from HSOFTDKBD.DT_DSLOPSHKH),       {0},    '{1}',         {2},         {3},            '{4}',        '{5}',    to_date('{6}','dd/MM/yyyy'), to_date('{7}','dd/MM/yyyy'),          '{8}',               '{9}',               '{10}',       '{11}',    '{12}',         '{13}',       '{14}',   '{15}',   '{16}',    {17},           {18},          {19},   '{20}')", NamLopHoc, NoiDungHoc, BVToChuc, KhoaPhong, TROGIANGPHOIHOP, DoiTuongHoc, NgayBatDauLopHoc, NgayKetThucLopHoc, ThoiGianHoc, ThoiGianHocLyThuy, ThoiGianHocThcHanh, DiaDiemHoc, KinhPhi, ChiGiaoVien, ChiNuocUong, ChiKhac, GhiChu, LOAIDTID, IDNGUOIHUONGDAN, LOAICHUNGNHAN, SHKHMASO);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
        }

        public bool UpdateLopHoc(int NamLopHoc, string NoiDungHoc, int BVToChuc, int KhoaPhong, string TROGIANGPHOIHOP, string DoiTuongHoc, string NgayBatDauLopHoc, string NgayKetThucLopHoc, string ThoiGianHoc, string ThoiGianHocLyThuy, string ThoiGianHocThcHanh, string DiaDiemHoc, string KinhPhi, string ChiGiaoVien, string ChiNuocUong, string ChiKhac, string GhiChu, int IDNGUOIHUONGDAN, int LOAICHUNGNHAN, int DSLOPSHKHID)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_DSLOPSHKH SET NAMLOPHOC = {0}, NOIDUNGHOC ='{1}',BVTOCHUCID = {2}, KHOAPHONGID = '{3}', TROGIANGPHOIHOP ='{4}',  DOITUONGHOC = '{5}',  NGAYBATDAULOPHOC = to_date('{6}','dd/MM/yyyy'),  NGAYKETTHUCLOPHOC =to_date('{7}','dd/MM/yyyy'),  THOIGIANHOC = '{8}',  THOIGIANHOCLYTHUYET ='{9}', THOIGIANHOCTHUCHANH ='{10}',  DIADIEMHOC = '{11}',  KINHPHI ='{12}',  CHIGIANGVIEN ='{13}', CHINUOCUONG = '{14}',  CHIKHAC = '{15}', GHICHU = '{16}' , LOAIDTID = 'Đào tạo theo lớp',IDNGUOIHUONGDAN = {17}, LOAICHUNGNHAN = {18}  where  DSLOPSHKHID  = {19}", NamLopHoc, NoiDungHoc, BVToChuc, KhoaPhong, TROGIANGPHOIHOP, DoiTuongHoc, NgayBatDauLopHoc, NgayKetThucLopHoc, ThoiGianHoc, ThoiGianHocLyThuy, ThoiGianHocThcHanh, DiaDiemHoc, KinhPhi, ChiGiaoVien, ChiNuocUong, ChiKhac, GhiChu, IDNGUOIHUONGDAN, LOAICHUNGNHAN, DSLOPSHKHID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteLopHoc(int LHid)
        {
            string query = string.Format("Delete HSOFTDKBD.DT_DSLOPSHKH where DSLOPSHKHID = {0}", LHid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool CountHocVienByLop(int LHID)
        {
            string query = string.Format("SELECT COUNT(IDLOPHOC) FROM HSOFTDKBD.DT_DSHOCVIENSHKH where IDLOPHOC = {0}", LHID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int Count_LopHoc()
        {
            string query = string.Format("select count(DSLOPSHKHID) from HSOFTDKBD.DT_DSLOPSHKH");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }

        public bool CheckBV(int id)
        {
            string query = string.Format("select * from DonVi where DonViid = {0}", id);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public int MAX_LHID()
        {
            string query = string.Format("select MAX(DSLOPSHKHID) + 1  from HSOFTDKBD.DT_DSLOPSHKH");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public int getIdByMALOP(string malop)
        {
            string query = string.Format("select DSLOPSHKHID  from HSOFTDKBD.DT_DSLOPSHKH where SHKHMASO= '{0}'", malop);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
    }
}





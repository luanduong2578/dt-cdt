using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DT_CDT.DAO
{
    class HocChuyenKhoaDAO
    {private static HocChuyenKhoaDAO instance;

        public static HocChuyenKhoaDAO Instance
        {
            get {if(instance == null) instance = new HocChuyenKhoaDAO(); return HocChuyenKhoaDAO.instance; }
            private set { HocChuyenKhoaDAO.instance = value; }
        }
        private HocChuyenKhoaDAO() { }

        public string LoadNamHienTai()
        {
            DateTime now = DateTime.Now;
            return (now.Year).ToString();
        }
        
  
        public DataTable LoadHCK(int namDT)
        {
            string query = string.Format("SELECT hck.HCKID as MA_HCK,hck.HCKNAM as NAM_DT, hv.HOCVIENHOTEN as HO_TEN_HV,(select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAITEN = hv.HOCVIENPHAI) as PHAI, hv.HOCVIENNAMSINH, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = hv.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) as KHOA_PHONG,(select kpdt.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kpdt where kpdt.KHOAPHONGID = hck.KPDAOTAOID) as KHOA_PHONG_DAO_TAO,HCKNOIDUNGDAOTAO as NOI_DUNG_DAO_TAO, (select ttdt.TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO ttdt where ttdt.TTDTID = hck.HCKTINHTRANGDTID) as TINH_TRANG_DAO_TAO, HCKKINHPHI as KINH_PHI,HCKTHOIGIANDAOTAO  as SO_THANG_HOC,HCKTHOIGIANBATDAU as THOI_GIAN_BD,HCKTHOIGIANKETTHUC as THOI_GIAN_KT,HCKKETQUATB as KET_QUA_TB,HCKKETQUALT as KET_QUA_LT,HCKKETQUATH as KET_QUA_TH,(select cn.CNDTTEN from hsoftdkbd.DT_CNDAOTAO cn where cn.CNDTID = hck.HCKCHUNGNHANID) as LOAI_CHUNG_NHAN, HCKGHICHU as GHI_CHU FROM HSOFTDKBD.DT_HOCCHUYENKHOA hck left join HSOFTDKBD.DT_HOCVIEN hv on hck.HCKHOCVIENID = hv.HOCVIENID where hck.HCKNAM ={0}", namDT);
           return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchHCKbyTuNamDenNam(int tunam, int dennam)
        {
            string query = string.Format("SELECT hck.HCKID as MA_HCK,hck.HCKNAM as NAM_DT, hv.HOCVIENHOTEN as HO_TEN_HV,(select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAITEN = hv.HOCVIENPHAI) as PHAI, hv.HOCVIENNAMSINH, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = hv.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) as KHOA_PHONG,(select kpdt.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kpdt where kpdt.KHOAPHONGID = hck.KPDAOTAOID) as KHOA_PHONG_DAO_TAO,HCKNOIDUNGDAOTAO as NOI_DUNG_DAO_TAO, (select ttdt.TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO ttdt where ttdt.TTDTID = hck.HCKTINHTRANGDTID) as TINH_TRANG_DAO_TAO, HCKKINHPHI as KINH_PHI,HCKTHOIGIANDAOTAO  as SO_THANG_HOC,HCKTHOIGIANBATDAU as THOI_GIAN_BD,HCKTHOIGIANKETTHUC as THOI_GIAN_KT,HCKKETQUATB as KET_QUA_TB,HCKKETQUALT as KET_QUA_LT,HCKKETQUATH as KET_QUA_TH,(select cn.CNDTTEN from hsoftdkbd.DT_CNDAOTAO cn where cn.CNDTID = hck.HCKCHUNGNHANID) as LOAI_CHUNG_NHAN, HCKGHICHU as GHI_CHU FROM HSOFTDKBD.DT_HOCCHUYENKHOA hck left join HSOFTDKBD.DT_HOCVIEN hv on hck.HCKHOCVIENID = hv.HOCVIENID where hck.HCKNAM >= {0} and hck.HCKNAM <= {1}", tunam, dennam);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchHCKbyNoiDungDT(int tunam, int dennam, string Noidungdt)
        {
            string query = string.Format("SELECT hck.HCKID as MA_HCK,hck.HCKNAM as NAM_DT, hv.HOCVIENHOTEN as HO_TEN_HV,(select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAITEN = hv.HOCVIENPHAI) as PHAI, hv.HOCVIENNAMSINH, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = hv.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) as KHOA_PHONG,(select kpdt.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kpdt where kpdt.KHOAPHONGID = hck.KPDAOTAOID) as KHOA_PHONG_DAO_TAO,HCKNOIDUNGDAOTAO as NOI_DUNG_DAO_TAO, (select ttdt.TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO ttdt where ttdt.TTDTID = hck.HCKTINHTRANGDTID) as TINH_TRANG_DAO_TAO, HCKKINHPHI as KINH_PHI,HCKTHOIGIANDAOTAO  as SO_THANG_HOC,HCKTHOIGIANBATDAU as THOI_GIAN_BD,HCKTHOIGIANKETTHUC as THOI_GIAN_KT,HCKKETQUATB as KET_QUA_TB,HCKKETQUALT as KET_QUA_LT,HCKKETQUATH as KET_QUA_TH,(select cn.CNDTTEN from hsoftdkbd.DT_CNDAOTAO cn where cn.CNDTID = hck.HCKCHUNGNHANID) as LOAI_CHUNG_NHAN, HCKGHICHU as GHI_CHU FROM HSOFTDKBD.DT_HOCCHUYENKHOA hck left join HSOFTDKBD.DT_HOCVIEN hv on hck.HCKHOCVIENID = hv.HOCVIENID where hck.HCKNAM >= {0} and hck.HCKNAM <= {1} and UPPER(HCKNoiDungDaoTao) LIKE UPPER('%{2}%')", tunam, dennam, Noidungdt);
            return DataProvider.Instance.ExecuteQuery(query);
        }
               
        public DataTable SearchHCKbyTenHV(int tunam, int dennam, string tenHV)
        {
            string query = string.Format("SELECT hck.HCKID as MA_HCK,hck.HCKNAM as NAM_DT, hv.HOCVIENHOTEN as HO_TEN_HV,(select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAITEN = hv.HOCVIENPHAI) as PHAI, hv.HOCVIENNAMSINH, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = hv.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) as KHOA_PHONG,(select kpdt.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kpdt where kpdt.KHOAPHONGID = hck.KPDAOTAOID) as KHOA_PHONG_DAO_TAO,HCKNOIDUNGDAOTAO as NOI_DUNG_DAO_TAO, (select ttdt.TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO ttdt where ttdt.TTDTID = hck.HCKTINHTRANGDTID) as TINH_TRANG_DAO_TAO, HCKKINHPHI as KINH_PHI,HCKTHOIGIANDAOTAO  as SO_THANG_HOC,HCKTHOIGIANBATDAU as THOI_GIAN_BD,HCKTHOIGIANKETTHUC as THOI_GIAN_KT,HCKKETQUATB as KET_QUA_TB,HCKKETQUALT as KET_QUA_LT,HCKKETQUATH as KET_QUA_TH,(select cn.CNDTTEN from hsoftdkbd.DT_CNDAOTAO cn where cn.CNDTID = hck.HCKCHUNGNHANID) as LOAI_CHUNG_NHAN, HCKGHICHU as GHI_CHU FROM HSOFTDKBD.DT_HOCCHUYENKHOA hck left join HSOFTDKBD.DT_HOCVIEN hv on hck.HCKHOCVIENID = hv.HOCVIENID where hck.HCKNAM >= {0} and hck.HCKNAM <= {1} and UPPER(HocVien) LIKE UPPER('%{2}%')", tunam, dennam, tenHV);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertHCK(int HCKNam, int HCKHocVien, int KPDaoTao, string HCKNoiDungDaoTao, int HCKThoiGianDaoTao, string HCKThoiGianBatDau, string HCKThoiGianKetThuc, string HCKKinhPhi, string HCKKetQuaTB, string HCKKetQuaLT, string HCKKetQuaTH, int HCKChungNhan, int HCKTinhTrangDT, string GhiChu, string HocVien)
        {
            if (Count_HCK() == 0)
            {
                string query = string.Format("insert into HSOFTDKBD.DT_HOCCHUYENKHOA (HCKID,HCKNAM,HCKHOCVIENID,KPDAOTAOID,HCKNOIDUNGDAOTAO,HCKTHOIGIANDAOTAO,HCKTHOIGIANBATDAU,HCKTHOIGIANKETTHUC,HCKKINHPHI,HCKKETQUATB,HCKKETQUALT,HCKKETQUATH,HCKCHUNGNHANID,HCKTINHTRANGDTID,HCKGHICHU,HCKHOCVIEN) values (1,{0},{1},{2},'{3}',{4},to_date('{5}','dd/MM/yyyy'),to_date('{6}','dd/MM/yyyy'),'{7}','{8}','{9}','{10}',{11},{12},'{13}','{14}')", HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;

            }
            else
            {
                string query = string.Format("insert into HSOFTDKBD.DT_HOCCHUYENKHOA (HCKID,HCKNAM,HCKHOCVIENID,KPDAOTAOID,HCKNOIDUNGDAOTAO,HCKTHOIGIANDAOTAO,HCKTHOIGIANBATDAU,HCKTHOIGIANKETTHUC,HCKKINHPHI,HCKKETQUATB,HCKKETQUALT,HCKKETQUATH,HCKCHUNGNHANID,HCKTINHTRANGDTID,HCKGHICHU,HCKHOCVIEN) values ((select max(HCKID)+1 from HSOFTDKBD.DT_HOCCHUYENKHOA),{0},{1},{2},'{3}',{4},to_date('{5}','dd/MM/yyyy'),to_date('{6}','dd/MM/yyyy'),'{7}','{8}','{9}','{10}',{11},{12},'{13}','{14}')", HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;

            }
        }
        public bool UpdateHCK(int HCKNam, int HCKHocVien, int KPDaoTao, string HCKNoiDungDaoTao, int HCKThoiGianDaoTao, string HCKThoiGianBatDau, string HCKThoiGianKetThuc, string HCKKinhPhi, string HCKKetQuaTB, string HCKKetQuaLT, string HCKKetQuaTH, int HCKChungNhan, int HCKTinhTrangDT, string GhiChu, string HocVien, int HCKID)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_HOCCHUYENKHOA SET HCKNAM = {0},HCKHOCVIENID= {1},KPDAOTAOID = {2}, HCKNOIDUNGDAOTAO = '{3}',HCKTHOIGIANDAOTAO = {4},HCKTHOIGIANBATDAU = to_date('{5}','dd/MM/yyyy'),HCKTHOIGIANKETTHUC = to_date('{6}','dd/MM/yyyy'),HCKKINHPHI ='{7}' ,HCKKETQUATB ='{8}' ,HCKKETQUALT = '{9}',HCKKETQUATH = '{10}',HCKCHUNGNHANID = {11},HCKTINHTRANGDTID = {12},HCKGHICHU = '{13}',HCKHOCVIEN = '{14}' WHERE HCKID = {15}", HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien, HCKID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        
        public bool DeleteHCK(int HCKid)
        {
            string query = string.Format("Delete HSOFTDKBD.DT_HOCCHUYENKHOA where HCKID = {0}", HCKid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public int Count_HCK()
        {
            string query = string.Format("select COUNT(HCKID) from HSOFTDKBD.DT_HOCCHUYENKHOA");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public DataTable getPhaibyHVid(int phai)
        {
            string query = string.Format("select (select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAIID = hv.HOCVIENPHAI) as PHAI from HSOFTDKBD.DT_HOCVIEN hv where hv.HOCVIENID = {0}", phai);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        
       
        
    }
}
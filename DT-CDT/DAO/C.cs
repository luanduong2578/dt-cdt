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
    {
        private static HocChuyenKhoaDAO instance;

        public static HocChuyenKhoaDAO Instance
        {
            get { if (instance == null) instance = new HocChuyenKhoaDAO(); return HocChuyenKhoaDAO.instance; }
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
            string query = string.Format("SELECT hck.HCKMASO as MA_HCK,hck.HCKNAM as NAM_DT, hv.HOCVIENHOTEN as HO_TEN_HV,(select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAITEN = hv.HOCVIENPHAI) as PHAI, hv.HOCVIENNAMSINH, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = hv.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) as KHOA_PHONG_CONG_TAC,(select kpdt.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kpdt where kpdt.KHOAPHONGID = hck.KPDAOTAOID) as KHOA_PHONG_DAO_TAO,HCKNOIDUNGDAOTAO as NOI_DUNG_DAO_TAO, (select ttdt.TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO ttdt where ttdt.TTDTID = hck.HCKTINHTRANGDTID) as TINH_TRANG_DAO_TAO, HCK.HCKLOAIKINHPHI AS LOAI_KINH_PHI, HCKKINHPHI as KINH_PHI,HCKTHOIGIANDAOTAO  as SO_THANG_HOC, HCK.HCKTONGSOTIET AS TONG_TO_TIET, HCKTHOIGIANBATDAU as THOI_GIAN_BD,HCKTHOIGIANKETTHUC as THOI_GIAN_KT,  HCK.HCKSOTIETHOC AS SO_TIET_HOC, HCK.HCKSOTIETNGHI AS SO_TIET_NGHI, HCKKETQUATB as KET_QUA_TB,HCKKETQUALT as KET_QUA_LT,HCKKETQUATH as KET_QUA_TH,HCK.HCKHINHTHUCHOC AS HINH_THUC_HOC, (select cn.CNDTTEN from hsoftdkbd.DT_CNDAOTAO cn where cn.CNDTID = hck.HCKCHUNGNHANID) as LOAI_CHUNG_NHAN,HCK.HCKCHUNGNHANSO AS SO_CHUNG_NHAN,  HCK.HCKGOIKT AS GOI_KT, HCKGHICHU as GHI_CHU FROM HSOFTDKBD.DT_HOCCHUYENKHOA hck left join HSOFTDKBD.DT_HOCVIEN hv on hck.HCKHOCVIENID = hv.HOCVIENID where hck.HCKNAM ={0} ORDER BY hck.HCKMASO ASC", namDT);
            // string query = string.Format("SELECT hck.HCKID as MA_HCK,hck.HCKNAM as NAM_DT, hv.HOCVIENHOTEN as HO_TEN_HV,(select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAITEN = hv.HOCVIENPHAI) as PHAI, hv.HOCVIENNAMSINH, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = hv.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) as KHOA_PHONG,(select kpdt.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kpdt where kpdt.KHOAPHONGID = hck.KPDAOTAOID) as KHOA_PHONG_DAO_TAO,HCKNOIDUNGDAOTAO as NOI_DUNG_DAO_TAO, (select ttdt.TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO ttdt where ttdt.TTDTID = hck.HCKTINHTRANGDTID) as TINH_TRANG_DAO_TAO, HCKKINHPHI as KINH_PHI,HCKTHOIGIANDAOTAO  as SO_THANG_HOC,HCKTHOIGIANBATDAU as THOI_GIAN_BD,HCKTHOIGIANKETTHUC as THOI_GIAN_KT,HCKKETQUATB as KET_QUA_TB,HCKKETQUALT as KET_QUA_LT,HCKKETQUATH as KET_QUA_TH,(select cn.CNDTTEN from hsoftdkbd.DT_CNDAOTAO cn where cn.CNDTID = hck.HCKCHUNGNHANID) as LOAI_CHUNG_NHAN, HCKGHICHU as GHI_CHU FROM HSOFTDKBD.DT_HOCCHUYENKHOA hck left join HSOFTDKBD.DT_HOCVIEN hv on hck.HCKHOCVIENID = hv.HOCVIENID", namDT);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchHCKbyTuNamDenNam(int tunam, int dennam)
        {
            string query = string.Format("SELECT hck.HCKMASO as MA_HCK, hck.HCKNAM as NAM_DT, hv.HOCVIENHOTEN as HO_TEN_HV,(select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAITEN = hv.HOCVIENPHAI) as PHAI, hv.HOCVIENNAMSINH, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = hv.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) as KHOA_PHONG_CONG_TAC,(select kpdt.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kpdt where kpdt.KHOAPHONGID = hck.KPDAOTAOID) as KHOA_PHONG_DAO_TAO,HCKNOIDUNGDAOTAO as NOI_DUNG_DAO_TAO, (select ttdt.TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO ttdt where ttdt.TTDTID = hck.HCKTINHTRANGDTID) as TINH_TRANG_DAO_TAO, HCK.HCKLOAIKINHPHI AS LOAI_KINH_PHI, HCKKINHPHI as KINH_PHI,HCKTHOIGIANDAOTAO  as SO_THANG_HOC, HCK.HCKTONGSOTIET AS TONG_TO_TIET, HCKTHOIGIANBATDAU as THOI_GIAN_BD,HCKTHOIGIANKETTHUC as THOI_GIAN_KT,  HCK.HCKSOTIETHOC AS SO_TIET_HOC, HCK.HCKSOTIETNGHI AS SO_TIET_NGHI, HCKKETQUATB as KET_QUA_TB,HCKKETQUALT as KET_QUA_LT,HCKKETQUATH as KET_QUA_TH,HCK.HCKHINHTHUCHOC AS HINH_THUC_HOC, (select cn.CNDTTEN from hsoftdkbd.DT_CNDAOTAO cn where cn.CNDTID = hck.HCKCHUNGNHANID) as LOAI_CHUNG_NHAN,HCK.HCKCHUNGNHANSO AS SO_CHUNG_NHAN,  HCK.HCKGOIKT AS GOI_KT, HCKGHICHU as GHI_CHU FROM HSOFTDKBD.DT_HOCCHUYENKHOA hck left join HSOFTDKBD.DT_HOCVIEN hv on hck.HCKHOCVIENID = hv.HOCVIENID where hck.HCKNAM >= {0} and hck.HCKNAM <= {1} ORDER BY hck.HCKMASO ASC", tunam, dennam);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchHCKbyNoiDungDT(int tunam, int dennam, string Noidungdt)
        {
            string query = string.Format("SELECT hck.HCKMASO as MA_HCK,hck.HCKNAM as NAM_DT, hv.HOCVIENHOTEN as HO_TEN_HV,(select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAITEN = hv.HOCVIENPHAI) as PHAI, hv.HOCVIENNAMSINH, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = hv.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) as KHOA_PHONG_CONG_TAC,(select kpdt.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kpdt where kpdt.KHOAPHONGID = hck.KPDAOTAOID) as KHOA_PHONG_DAO_TAO,HCKNOIDUNGDAOTAO as NOI_DUNG_DAO_TAO, (select ttdt.TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO ttdt where ttdt.TTDTID = hck.HCKTINHTRANGDTID) as TINH_TRANG_DAO_TAO, HCK.HCKLOAIKINHPHI AS LOAI_KINH_PHI, HCKKINHPHI as KINH_PHI,HCKTHOIGIANDAOTAO  as SO_THANG_HOC, HCK.HCKTONGSOTIET AS TONG_TO_TIET, HCKTHOIGIANBATDAU as THOI_GIAN_BD,HCKTHOIGIANKETTHUC as THOI_GIAN_KT,  HCK.HCKSOTIETHOC AS SO_TIET_HOC, HCK.HCKSOTIETNGHI AS SO_TIET_NGHI, HCKKETQUATB as KET_QUA_TB,HCKKETQUALT as KET_QUA_LT,HCKKETQUATH as KET_QUA_TH,HCK.HCKHINHTHUCHOC AS HINH_THUC_HOC, (select cn.CNDTTEN from hsoftdkbd.DT_CNDAOTAO cn where cn.CNDTID = hck.HCKCHUNGNHANID) as LOAI_CHUNG_NHAN,HCK.HCKCHUNGNHANSO AS SO_CHUNG_NHAN,  HCK.HCKGOIKT AS GOI_KT, HCKGHICHU as GHI_CHU FROM HSOFTDKBD.DT_HOCCHUYENKHOA hck left join HSOFTDKBD.DT_HOCVIEN hv on hck.HCKHOCVIENID = hv.HOCVIENID where hck.HCKNAM >= {0} and hck.HCKNAM <= {1} and UPPER(HCKNoiDungDaoTao) LIKE UPPER('%{2}%') ORDER BY hck.HCKMASO ASC", tunam, dennam, Noidungdt);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchHCKbyTenHV(int tunam, int dennam, string tenHV)
        {
            string query = string.Format("SELECT hck.HCKMASO as MA_HCK,hck.HCKNAM as NAM_DT, hv.HOCVIENHOTEN as HO_TEN_HV,(select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAITEN = hv.HOCVIENPHAI) as PHAI, hv.HOCVIENNAMSINH, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = hv.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) as KHOA_PHONG_CONG_TAC,(select kpdt.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kpdt where kpdt.KHOAPHONGID = hck.KPDAOTAOID) as KHOA_PHONG_DAO_TAO,HCKNOIDUNGDAOTAO as NOI_DUNG_DAO_TAO, (select ttdt.TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO ttdt where ttdt.TTDTID = hck.HCKTINHTRANGDTID) as TINH_TRANG_DAO_TAO, HCK.HCKLOAIKINHPHI AS LOAI_KINH_PHI, HCKKINHPHI as KINH_PHI,HCKTHOIGIANDAOTAO  as SO_THANG_HOC, HCK.HCKTONGSOTIET AS TONG_TO_TIET, HCKTHOIGIANBATDAU as THOI_GIAN_BD,HCKTHOIGIANKETTHUC as THOI_GIAN_KT,  HCK.HCKSOTIETHOC AS SO_TIET_HOC, HCK.HCKSOTIETNGHI AS SO_TIET_NGHI, HCKKETQUATB as KET_QUA_TB,HCKKETQUALT as KET_QUA_LT,HCKKETQUATH as KET_QUA_TH,HCK.HCKHINHTHUCHOC AS HINH_THUC_HOC, (select cn.CNDTTEN from hsoftdkbd.DT_CNDAOTAO cn where cn.CNDTID = hck.HCKCHUNGNHANID) as LOAI_CHUNG_NHAN,HCK.HCKCHUNGNHANSO AS SO_CHUNG_NHAN,  HCK.HCKGOIKT AS GOI_KT, HCKGHICHU as GHI_CHU FROM HSOFTDKBD.DT_HOCCHUYENKHOA hck left join HSOFTDKBD.DT_HOCVIEN hv on hck.HCKHOCVIENID = hv.HOCVIENID where hck.HCKNAM >= {0} and hck.HCKNAM <= {1} and UPPER(HOCVIENHOTEN) LIKE UPPER('%{2}%') ORDER BY hck.HCKMASO ASC", tunam, dennam, tenHV);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertHCK(int HCKNam, int HCKHocVien, int KPDaoTao, string HCKNoiDungDaoTao, int HCKThoiGianDaoTao, string HCKThoiGianBatDau, string HCKThoiGianKetThuc, string HCKKinhPhi, string HCKKetQuaTB, string HCKKetQuaLT, string HCKKetQuaTH, int HCKChungNhan, int HCKTinhTrangDT, string GhiChu, string HocVien, string HCKHinhThucHoc, string HCKGoiKT, string HCKLoaiKinhPhi, string HCKTongSoTiet, string HCKSoChungNhan, string HCKSoTietHoc, string HCKSoTietNghi)
        {
            if (Count_HCK() == 0)
            {
                string query = string.Format("insert into HSOFTDKBD.DT_HOCCHUYENKHOA (HCKID,HCKNAM,HCKHOCVIENID,KPDAOTAOID,HCKNOIDUNGDAOTAO,HCKTHOIGIANDAOTAO,HCKTHOIGIANBATDAU,HCKTHOIGIANKETTHUC,HCKKINHPHI,HCKKETQUATB,HCKKETQUALT,HCKKETQUATH,HCKCHUNGNHANID,HCKTINHTRANGDTID,HCKGHICHU,HCKHOCVIEN,HCKHINHTHUCHOC,HCKGOIKT,HCKLOAIKINHPHI,HCKTONGSOTIET,HCKCHUNGNHANSO,HCKSOTIETHOC,HCKSOTIETNGHI,HCKMASO) values (1,{0},{1},{2},'{3}',{4},to_date('{5}','dd/MM/yyyy'),to_date('{6}','dd/MM/yyyy'),'{7}','{8}','{9}','{10}',{11},{12},'{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','HCK00001')", HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien, HCKHinhThucHoc, HCKGoiKT, HCKLoaiKinhPhi, HCKTongSoTiet, HCKSoChungNhan, HCKSoTietHoc, HCKSoTietNghi);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;

            }
            else
            {
                string MAHCK = "";
                if (MAX_HCKID() < 10)
                {
                    MAHCK = string.Format("HCK0000{0}", MAX_HCKID().ToString());
                }
                else if (MAX_HCKID() < 100)
                {
                    MAHCK = string.Format("HCK000{0}", MAX_HCKID().ToString());
                }
                else if (MAX_HCKID() < 1000)
                {
                    MAHCK = string.Format("HCK00{0}", MAX_HCKID().ToString());
                }
                else
                {
                    MAHCK = string.Format("HCK0{0}", MAX_HCKID().ToString());
                }

                string query = string.Format("insert into HSOFTDKBD.DT_HOCCHUYENKHOA (HCKID,HCKNAM,HCKHOCVIENID,KPDAOTAOID,HCKNOIDUNGDAOTAO,HCKTHOIGIANDAOTAO,HCKTHOIGIANBATDAU,HCKTHOIGIANKETTHUC,HCKKINHPHI,HCKKETQUATB,HCKKETQUALT,HCKKETQUATH,HCKCHUNGNHANID,HCKTINHTRANGDTID,HCKGHICHU,HCKHOCVIEN,HCKHINHTHUCHOC,HCKGOIKT,HCKLOAIKINHPHI,HCKTONGSOTIET,HCKCHUNGNHANSO,HCKSOTIETHOC,HCKSOTIETNGHI,HCKMASO) values ((select max(HCKID)+1 from HSOFTDKBD.DT_HOCCHUYENKHOA),{0},{1},{2},'{3}',{4},to_date('{5}','dd/MM/yyyy'),to_date('{6}','dd/MM/yyyy'),'{7}','{8}','{9}','{10}',{11},{12},'{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}')", HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien, HCKHinhThucHoc, HCKGoiKT, HCKLoaiKinhPhi, HCKTongSoTiet, HCKSoChungNhan, HCKSoTietHoc, HCKSoTietNghi, MAHCK);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
        }
        public bool UpdateHCK(int HCKNam, int HCKHocVien, int KPDaoTao, string HCKNoiDungDaoTao, int HCKThoiGianDaoTao, string HCKThoiGianBatDau, string HCKThoiGianKetThuc, string HCKKinhPhi, string HCKKetQuaTB, string HCKKetQuaLT, string HCKKetQuaTH, int HCKChungNhan, int HCKTinhTrangDT, string GhiChu, string HocVien, int HCKID, string HCKHinhThucHoc, string HCKGoiKT, string HCKLoaiKinhPhi, string HCKTongSoTiet, string HCKSoChungNhan, string HCKSoTietHoc, string HCKSoTietNghi, string MAHCK)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_HOCCHUYENKHOA SET HCKNAM = {0},HCKHOCVIENID= {1},KPDAOTAOID = {2}, HCKNOIDUNGDAOTAO = '{3}',HCKTHOIGIANDAOTAO = {4},HCKTHOIGIANBATDAU = to_date('{5}','dd/MM/yyyy'),HCKTHOIGIANKETTHUC = to_date('{6}','dd/MM/yyyy'),HCKKINHPHI ='{7}' ,HCKKETQUATB ='{8}' ,HCKKETQUALT = '{9}',HCKKETQUATH = '{10}',HCKCHUNGNHANID = {11},HCKTINHTRANGDTID = {12},HCKGHICHU = '{13}',HCKHOCVIEN = '{14}', HCKHINHTHUCHOC ='{15}' , HCKGOIKT='{16}',HCKLOAIKINHPHI='{17}',HCKTONGSOTIET='{18}',HCKCHUNGNHANSO='{19}',HCKSOTIETHOC='{20}',HCKSOTIETNGHI='{21}',HCKMASO='{22}' WHERE HCKID = {23}", HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien, HCKHinhThucHoc, HCKGoiKT, HCKLoaiKinhPhi, HCKTongSoTiet, HCKSoChungNhan, HCKSoTietHoc, HCKSoTietNghi, MAHCK, HCKID);
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
        public int MAX_HCKID()
        {
            string query = string.Format("select MAX(HCKID) +1  from HSOFTDKBD.DT_HOCCHUYENKHOA");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public int MAX_IDHCK()
        {
            string query = string.Format("select MAX(HCKID)  from HSOFTDKBD.DT_HOCCHUYENKHOA");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public DataTable getPhaibyHVid(int phai)
        {
            string query = string.Format("select (select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAIID = hv.HOCVIENPHAI) as PHAI from HSOFTDKBD.DT_HOCVIEN hv where hv.HOCVIENID = {0}", phai);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int GetHCKIdByMAHCK(string mahck)
        {
            string query = string.Format("select HCKID from HSOFTDKBD.DT_HOCCHUYENKHOA where HCKMASO = '{0}'", mahck);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public bool Kiemtra_CapChungNhan(string CCNMASOLop1)
        {
            string query = string.Format("select count(SOCHUNGNHAN) from HSOFTDKBD.DT_CAPCHUNGNHAN where CCNMASO ='{0}'", CCNMASOLop1);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data > 0;
        }
        public string GetSOCN_By_CCMASO_from_CCN(string CCNMASOLop)
        {
            string data = "Chưa cấp";
            if (Kiemtra_CapChungNhan(CCNMASOLop))
            {
                //string query = string.Format("select SOCHUNGNHAN from HSOFTDKBD.DT_CAPCHUNGNHAN where CCNMASO ='{0}'",CCNMASOLop);
                string query = string.Format("select SOCHUNGNHAN from HSOFTDKBD.DT_CAPCHUNGNHAN where CCNMASO = 'HCK00001'");
                data =DataProvider.Instance.ExecuteScalar(query).ToString();
            }
            return data;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class HocVienDAO
    {
        private static HocVienDAO instance;
        internal static HocVienDAO Instance
        {
            get { if (instance == null) instance = new HocVienDAO(); return HocVienDAO.instance; }
            private set { HocVienDAO.instance = value; }
        }

        private HocVienDAO() { }

        public DataTable LoadHocVien()
        {
            string query = "SELECT HOCVIENID as MA, HOCVIENHOTEN as HO_TEN, HOCVIENNAMSINH as NGAY_SINH, PHAITEN as PHAI, DONVITEN as BENH_VIEN ,KHOAPHONGTEN as KHOA_PHONG, CHUCDANHTEN  as CHUC_DANH,HOCVIENDIENTHOAI  as DIEN_THOAI,HOCVIENEMAIL as EMAIL,HOCVIENGHICHU as GHI_CHU from HSOFTDKBD.DT_HOCVIEN hv inner join HSOFTDKBD.DT_BENHVIEN  dv on hv.IDDONVI = dv.DONVIID	inner join HSOFTDKBD.DT_CHUCDANH cd on cd.CHUCDANHID = hv.IDCHUCDANH left join HSOFTDKBD.DT_KHOAPHONG kp on kp.KHOAPHONGID = hv.IDKHOAPHONG inner join HSOFTDKBD.DT_PHAI p on p.PHAITEN = hv.HOCVIENPHAI ORDER BY HOCVIENID ASC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchHVbyTenHV(string tenhv)
        {
            string query = string.Format("SELECT HOCVIENID as MA, HOCVIENHOTEN as HO_TEN, HOCVIENNAMSINH as NGAY_SINH, PHAITEN as PHAI, DONVITEN as BENH_VIEN ,KHOAPHONGTEN as KHOA_PHONG, CHUCDANHTEN  as CHUC_DANH,HOCVIENDIENTHOAI  as DIEN_THOAI,HOCVIENEMAIL as EMAIL,HOCVIENGHICHU as GHI_CHU from HSOFTDKBD.DT_HOCVIEN hv inner join HSOFTDKBD.DT_BENHVIEN  dv on hv.IDDONVI = dv.DONVIID	inner join HSOFTDKBD.DT_CHUCDANH cd on cd.CHUCDANHID = hv.IDCHUCDANH left join HSOFTDKBD.DT_KHOAPHONG kp on kp.KHOAPHONGID = hv.IDKHOAPHONG inner join HSOFTDKBD.DT_PHAI p on p.PHAITEN = hv.HOCVIENPHAI where UPPER(HOCVIENHOTEN) LIKE UPPER('%{0}%') ORDER BY HOCVIENID ASC", tenhv);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertHocVien(int IdChucDanh, int IdDonVi, int IdKhoaPhong, string HocVienHoten, string HocVienNamSinh, string HocVienPhai, string HocVienDienThoai, string HocVienGhiChu, string HocVienEmail)
        {
            if (Count_HV() == 0)
            {
                string query = string.Format("INSERT into HSOFTDKBD.DT_HOCVIEN (HOCVIENID,IDCHUCDANH,IDDONVI,IDKHOAPHONG,HOCVIENHOTEN,HOCVIENNAMSINH,HOCVIENPHAI,HOCVIENDIENTHOAI,HOCVIENGHICHU, HOCVIENEMAIL) values (1,{0},{1},{2},'{3}','{4}','{5}','{6}','{7}', '{8}')", IdChucDanh, IdDonVi, IdKhoaPhong, HocVienHoten, HocVienNamSinh, HocVienPhai, HocVienDienThoai, HocVienGhiChu, HocVienEmail);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            else
            {
                string query = string.Format("INSERT into HSOFTDKBD.DT_HOCVIEN (HOCVIENID,IDCHUCDANH,IDDONVI,IDKHOAPHONG,HOCVIENHOTEN,HOCVIENNAMSINH,HOCVIENPHAI,HOCVIENDIENTHOAI,HOCVIENGHICHU, HOCVIENEMAIL) values ((SELECT MAX(HOCVIENID)+ 1 FROM HSOFTDKBD.DT_HOCVIEN),{0},{1},{2},'{3}','{4}','{5}','{6}','{7}', '{8}')", IdChucDanh, IdDonVi, IdKhoaPhong, HocVienHoten, HocVienNamSinh, HocVienPhai, HocVienDienThoai, HocVienGhiChu, HocVienEmail);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
        }

        public bool UpdateHocVien(int IdChucDanh, int IdDonVi, int IdKhoaPhong, string HocVienHoten, string HocVienNamSinh, string HocVienPhai, string HocVienDienThoai, string HocVienGhiChu, string HocVienEmail, int HocVienid)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_HOCVIEN set IDCHUCDANH = {0}, IDDONVI = {1}, IDKHOAPHONG = {2}, HOCVIENHOTEN = '{3}', HOCVIENNAMSINH = '{4}', HOCVIENPHAI = '{5}', HOCVIENDIENTHOAI = '{6}', HOCVIENGHICHU = '{7}', HOCVIENEMAIL = '{8}' where HOCVIENID = {9}", IdChucDanh, IdDonVi, IdKhoaPhong, HocVienHoten, HocVienNamSinh, HocVienPhai, HocVienDienThoai, HocVienGhiChu, HocVienEmail, HocVienid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteHocVien(int HocVienid)
        {
            string query = string.Format("DELETE HSOFTDKBD.DT_HOCVIEN where HOCVIENID = {0}", HocVienid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool count_IDHV_in_fNCKH(int idhv)
        {
            string query = string.Format("select count(*) from  HSOFTDKBD.DT_NCKH   where  CONGSU1 = {0} OR CONGSU2 = {1} OR CONGSU3 = {2} OR CONGSU4 = {3}",idhv,idhv,idhv,idhv);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data >0;
        }
        public bool count_IDHV_in_fHOCCHUYENKHOA(int idhv)
        {
            string query = string.Format("select count(*) from HSOFTDKBD.DT_HOCCHUYENKHOA   where HCKHOCVIENID = {0}", idhv);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data > 0;
        }
        public bool count_IDHV_in_fDSHOCVIENDTLT(int idhv)
        {
            string query = string.Format("select count(*) from HSOFTDKBD.DT_DSHOCVIENDTTL where IDHOCVIEN = {0}", idhv);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data > 0;
        }
        public bool count_IDHV_in_fDSHOCVIENSHKH(int idhv)
        {
            string query = string.Format("select count(*) from HSOFTDKBD.DT_DSHOCVIENSHKH where IDHOCVIEN = {0}", idhv);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data > 0;
        }
        
        public bool count_IDHV_in_fCAPCHUNGNHAN(int idhv)
        {
            string query = string.Format("select count(*) from HSOFTDKBD.DT_CAPCHUNGNHAN where IDHOCVIEN = {0}", idhv);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data > 0;
        }
        public int KiemTraHVDaTonTai(string HOCVIENHOTEN,string HOCVIENPHAI,string HOCVIENNAMSINH, int IDCHUCDANH, int IDDONVI, int IDKHOAPHONG)
        {
            string query = string.Format("select count(*) from HSOFTDKBD.DT_HOCVIEN where HOCVIENHOTEN = '{0}' and HOCVIENPHAI = '{1}' and HOCVIENNAMSINH = '{2}' and IDCHUCDANH = {3} and IDDONVI = {4} and IDKHOAPHONG = {5}", HOCVIENHOTEN, HOCVIENPHAI, HOCVIENNAMSINH, IDCHUCDANH, IDDONVI, IDKHOAPHONG);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }


        public DataTable LoadHocVienAndKhoaPhong()
        {
            string query = "SELECT HV.HOCVIENID, HV.HOCVIENHOTEN AS HOTENHV from HSOFTDKBD.DT_HOCVIEN HV ORDER BY HOCVIENHOTEN ASC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

//        public DataTable LoadHocVienAndKhoaPhong()
//        {
//            string query = "SELECT HV.HOCVIENID, HV.HOCVIENHOTEN  ||' - '|| (select KP.KHOAPHONGVIETTAT from HSOFTDKBD.DT_KHOAPHONG KP where KP.KHOAPHONGID = HV.IDKHOAPHONG) AS HOTENHV from HSOFTDKBD.DT_HOCVIEN HV";
//            return DataProvider.Instance.ExecuteQuery(query);
//        }

        public DataTable loadHVandKPanDVCT()
        {
            string query = "SELECT HOCVIENID, HOCVIENHOTEN as HV from HSOFTDKBD.DT_HOCVIEN hv ORDER BY HOCVIENHOTEN ASC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

//        public DataTable loadHVandKPanDVCT()
//        {
//            string query = "SELECT HOCVIENID, HOCVIENHOTEN  ||' - '|| (select KHOAPHONGVIETTAT from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) + ' - ' + (select dv.DONVITEN from HSOFTDKBD.DT_BENHVIEN dv where dv.DONVIID = hv.IDDONVI) as [HV] from HSOFTDKBD.DT_HOCVIEN hv";
//            return DataProvider.Instance.ExecuteQuery(query);
//        }

        public string GetPhaibyHocVienID(int id)
        {           
            string query = string.Format("select HOCVIENPHAI from HSOFTDKBD.DT_HOCVIEN where HOCVIENID = {0}", id);
            string data = DataProvider.Instance.ExecuteScalar(query).ToString();
            return data;
        }

        public string GetNgaySinhbyHocVienID(int id)
        {
            string query = string.Format("select HOCVIENNAMSINH from HSOFTDKBD.DT_HOCVIEN where HOCVIENID = {0}", id);
            string data = DataProvider.Instance.ExecuteScalar(query).ToString();
            return data;
        }
        public string GetChucDanhbyHocVienID(int id)
        {
            string query = string.Format("select (select cd.CHUCDANHTEN from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) from  HSOFTDKBD.DT_HOCVIEN hv where hv.HOCVIENID = {0}", id);
            string data = DataProvider.Instance.ExecuteScalar(query).ToString();
            return data;
        }
        public string GetDVCTbyHocVienID(int id)
        {
            string query = string.Format("select (select BV.DONVITEN from HSOFTDKBD.DT_BENHVIEN BV where BV.DONVIID = hv.IDDONVI) from  HSOFTDKBD.DT_HOCVIEN hv where hv.HOCVIENID = {0}", id);
            string data = DataProvider.Instance.ExecuteScalar(query).ToString();
            return data;
        }
        public string GetKhoaPhongbyHocVienID(int id)
        {
            string query = string.Format("select (select KP.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG KP where KP.KHOAPHONGID = hv.IDKHOAPHONG) from  HSOFTDKBD.DT_HOCVIEN hv where hv.HOCVIENID = {0}", id);
            string data = DataProvider.Instance.ExecuteScalar(query).ToString() ;
            return data;
        }
        //kiem tra hoc vien khi insert hoc vien
        public int Count_HV()
        {
            string query = string.Format("select COUNT(HOCVIENID) from HSOFTDKBD.DT_HOCVIEN");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }


        public DataTable LoadListHVbyID()
        {
            string query = "SELECT hv.HOCVIENID, HOCVIENHOTEN as HOC_VIEN from HSOFTDKBD.DT_HOCVIEN hv ORDER BY HOCVIENHOTEN ASC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
//        public DataTable LoadListHVbyID1()
//        {
//            string query = "SELECT hv.HOCVIENID, HOCVIENHOTEN  ||' - '|| (SELECT KHOAPHONGVIETTAT from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) ||' - '|| (SELECT dv.DONVITEN from HSOFTDKBD.DT_BENHVIEN dv where dv.DONVIID = hv.IDDONVI) as HOC_VIEN from HSOFTDKBD.DT_HOCVIEN hv";
//            return DataProvider.Instance.ExecuteQuery(query);
//        }

        public DataTable LoadListHocVien()
        {
            string query = "SELECT HOCVIENID,HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN ORDER BY HOCVIENHOTEN ASC ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadListHocVientoTextBox()
        {
            string query = "SELECT HOCVIENHOTEN from HSOFTDKBD.DT_HOCVIEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}

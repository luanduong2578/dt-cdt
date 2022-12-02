using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class BenhVienDAO
    {
        private static BenhVienDAO instance;

        public static BenhVienDAO Instance
        {
            get { if (instance == null) instance = new BenhVienDAO(); return BenhVienDAO.instance; }
            private set { BenhVienDAO.instance = value; }
        }
        private BenhVienDAO() { }

        public DataTable LoadBenhvien()
        {
            string query = "SELECT DONVIID as Ma_BV ,DONVITEN as BV_TEN, DONVIVIETTAT as VIET_TA FROM HSOFTDKBD.DT_BENHVIEN ORDER BY DONVIID ASC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadBenhvienbyTenBV(string tenbv)
        {
            string query = string.Format("SELECT DONVIID as Ma_BV, DONVITEN as BV_TEN, DONVIVIETTAT as VIET_TAT FROM HSOFTDKBD.DT_BENHVIEN where UPPER(DONVITEN) LIKE UPPER('%{0}%') ORDER BY DONVIID ASC", tenbv);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertBenhVien(string BenhVienTen, string BenhVienTenVietTat)
        {
            string query = string.Format("INSERT INTO HSOFTDKBD.DT_BENHVIEN (DONVIID, DONVITEN, DONVIVIETTAT) VALUES ((SELECT MAX(DONVIID) + 1 FROM HSOFTDKBD.DT_BENHVIEN), '{0}', '{1}')", BenhVienTen, BenhVienTenVietTat);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateBenhVien(string BenhVienTen, string BenhVienTenVietTat, int BenhVienId)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_BENHVIEN  SET DONVITEN = '{0}', DONVIVIETTAT = '{1}' WHERE DONVIID = {2}", BenhVienTen, BenhVienTenVietTat, BenhVienId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteDonVi(int DonViid)
        {
            string query = string.Format("DELETE HSOFTDKBD.DT_BENHVIEN WHERE DONVIID = {0}", DonViid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        //kiểm tra khoa phong su dung idDonVi
        public int Count_idDonVi_in_KHoaPhong(int idDonVi)
        {
            string query = string.Format("select COUNT(IDDONVI) from HSOFTDKBD.DT_KHOAPHONG where IDDONVI = {0}", idDonVi);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }

        //kiểm tra khoa phong su dung idDonVi
        public int Count_idDonVi_in_HocVien(int idDonVi)
        {
            string query = string.Format("select COUNT(IDDONVI) from HSOFTDKBD.DT_HOCVIEN where IDDONVI = {0}", idDonVi);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public int Count_idDonVi_in_LopHoc(int idDonVi)
        {
            string query = string.Format("select COUNT(DONVIID) from HSOFTDKBD.DT_BENHVIEN where DONVIID = {0}", idDonVi);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }

        public DataTable LoadListBenhVien()
        {
            string query = "select DONVIID, DONVITEN from HSOFTDKBD.DT_BENHVIEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }

}

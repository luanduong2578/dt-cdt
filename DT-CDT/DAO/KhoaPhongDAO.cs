using DT_CDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class KhoaPhongDAO
    {
        private static KhoaPhongDAO instance;

        public static KhoaPhongDAO Instance
        {
            get { if(instance == null) instance = new KhoaPhongDAO(); return KhoaPhongDAO.instance; }
            private set { KhoaPhongDAO.instance = value; }
        }
        private KhoaPhongDAO() { }

        public DataTable LoadKhoaPhong()
        {
            string query = "SELECT KHOAPHONGID as MA_KP ,IDDONVI as MA_BV, DONVITEN as TEN_BV,KHOAPHONGTEN as TEN_KP, KHOAPHONGVIETTAT as VIET_TAT_KP  FROM HSOFTDKBD.DT_KHOAPHONG K, HSOFTDKBD.DT_BENHVIEN D  where K.IDDONVI = d.DONVIID ORDER BY K.KHOAPHONGID ASC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertKhoaPhong(int IdDonVi, string KhoaPhongTen, string KhoaPhongVietTat)
        {
            string query = string.Format("insert into HSOFTDKBD.DT_KHOAPHONG (KHOAPHONGID, IDDONVI, KHOAPHONGTEN,KHOAPHONGVIETTAT) values ((SELECT MAX(KHOAPHONGID)+ 1 FROM HSOFTDKBD.DT_KHOAPHONG), {0}, '{1}', '{2}')", IdDonVi, KhoaPhongTen, KhoaPhongVietTat);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateKhoaPhong(int IdDonVi, string KhoaPhongTen, string KhoaPhongVietTat, int KhoaPhongid)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_KHOAPHONG SET IDDONVI = '{0}', KHOAPHONGTEN = '{1}', KHOAPHONGVIETTAT= '{2}' WHERE KHOAPHONGID = {3}", IdDonVi, KhoaPhongTen, KhoaPhongVietTat, KhoaPhongid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteKhoaPHong(int KhoaPhongid)
        {
            string query = string.Format("DELETE HSOFTDKBD.DT_KHOAPHONG where KHOAPHONGID = {0}", KhoaPhongid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

//kiểm tra khoa phong Xoa khoa phong trong hocvien
        public int Count_idKhoaPhong_in_HocVien(int idKhoaPhong)
        {
            string query = string.Format("select COUNT(IDKHOAPHONG) from HSOFTDKBD.DT_HOCVIEN where IDKHOAPHONG = {0}", idKhoaPhong);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }

//kiểm tra khoa phong Xoa khoa phong trong NCKH
        public int Count_idKhoaPhong_in_NCKH(int idKhoaPhong)
        {
            string query = string.Format("select COUNT(IDKHOAPHONG) from HSOFTDKBD.DT_NCKH where IDKHOAPHONG = {0}", idKhoaPhong);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }

        public DataTable LoadListBenhVien()
        {
            string query = "select DONVIID, DONVITEN, DONVIVIETTAT from HSOFTDKBD.DT_BENHVIEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        
        public DataTable loadKPandKPanBV()
           {
               string query = "select KhoaPhongid, KhoaPhongTen ||' - '|| (select dv.DonViTen from HSOFTDKBD.DT_BENHVIEN dv where dv.DonViid = KP.IdDonVi) as KHOA_PHONG_DAO_TAO from HSOFTDKBD.DT_KHOAPHONG KP";
               return DataProvider.Instance.ExecuteQuery(query);
           }

        public DataTable LoadListKhoaPhong()
        {
            string query = "select KHOAPHONGID, IDDONVI, KHOAPHONGTEN, KHOAPHONGVIETTAT FROM HSOFTDKBD.DT_KHOAPHONG";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //
        public List<KhoaPhong> GetDSKhoaPhong()
        {
            List<KhoaPhong> list = new List<KhoaPhong>();
            string query = "select * from HSOFTDKBD.DT_KHOAPHONG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhoaPhong kp = new KhoaPhong(item);
                list.Add(kp);
            }
            return list;
        }

    }
}

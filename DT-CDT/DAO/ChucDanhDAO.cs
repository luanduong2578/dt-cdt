using DT_CDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DT_CDT.DAO
{
    class ChucDanhDAO
    {
        private static ChucDanhDAO instance;

        public static ChucDanhDAO Instance
        {
            get { if (instance == null) instance = new ChucDanhDAO(); return ChucDanhDAO.instance; }
            private set { ChucDanhDAO.instance = value; }
        }
        private ChucDanhDAO() { }

        public DataTable LoadChucDanh()
        {
            string query = "SELECT CHUCDANHID as MA_CD,CHUCDANHTEN as CHUC_DANH,CHUCDANHVIETTAT as VIET_TAT FROM HSOFTDKBD.DT_CHUCDANH ORDER BY CHUCDANHID ASC";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public bool InsertChucDanh(string CDTen, string CDVietTat)
        {
            string query = string.Format("INSERT INTO HSOFTDKBD.DT_CHUCDANH (CHUCDANHID,CHUCDANHTEN,CHUCDANHVIETTAT) VALUES ((select max(CHUCDANHID)+1 from HSOFTDKBD.DT_CHUCDANH),'{0}','{1}')", CDTen, CDVietTat);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateChucDanh(string CDTen, string CDVietTat, int id)
        {
            string query = string.Format("update HSOFTDKBD.DT_CHUCDANH set CHUCDANHTEN = '{0}', CHUCDANHVIETTAT = '{1}' WHERE ChucDanhid = {2}", CDTen, CDVietTat, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteChucDanh(int id)
        {

            string query = string.Format("Delete HSOFTDKBD.DT_CHUCDANH where CHUCDANHID = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
//kiểm tra khi hoc vien da su dung chuc danh
        public int Count_idChucDanhinHocVien(int idChucDanh)
        {
            string query = string.Format("select COUNT(IDCHUCDANH) from HSOFTDKBD.DT_HOCVIEN where IDCHUCDANH = {0}", idChucDanh);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }



        public DataTable LoadListChucDanh()
        {
            string query = "select CHUCDANHID,CHUCDANHTEN,CHUCDANHVIETTAT from HSOFTDKBD.DT_CHUCDANH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

//
        public List<ChucDanh> GetDSChucDanh()
        {
            List<ChucDanh> list = new List<ChucDanh>();
            string query = "select * from HSOFTDKBD.DT_CHUCDANH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChucDanh CD = new ChucDanh(item);
                list.Add(CD);
            }
            return list;
        }


    }
}

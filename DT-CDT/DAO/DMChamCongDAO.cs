using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class DMChamCongDAO
    {
        private static DMChamCongDAO instance;

        public static DMChamCongDAO Instance
        {
            get { if (instance == null) instance = new DMChamCongDAO(); return DMChamCongDAO.instance; }
            private set { DMChamCongDAO.instance = value; }
        }
        private DMChamCongDAO() { }

        public DataTable LoadDMChamCong()
        {
            string query = "SELECT  DMCDID AS ID, DMCDTEN AS TEN, DMCDVIETTAT AS KY_HIEU, SONGAYCONG AS SO_NGAY_CONG, SOTIETHOC AS SO_TIET, GHICHU AS GHI_CHU FROM HSOFTDKBD.DT_DMCHAMCONG ORDER BY DMCDID ASC";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }

        public bool InsertDMChamCong(string DMCDTEN, string DMCDVIETTAT, int SONGAYCONG, int SOTIETHOC, string GHICHU)
        {
            int result = 0;
            if (Count_ID() == 0)
            {
                string query = string.Format("INSERT INTO HSOFTDKBD.DT_DMCHAMCONG (DMCDID, DMCDTEN,DMCDVIETTAT,SONGAYCONG,SOTIETHOC,GHICHU) VALUES (1,'{0}','{1}',{2},{3},'{4}')", DMCDTEN, DMCDVIETTAT, SONGAYCONG, SOTIETHOC, GHICHU);
                result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            else
            {
                string query = string.Format("INSERT INTO HSOFTDKBD.DT_DMCHAMCONG (DMCDID, DMCDTEN,DMCDVIETTAT,SONGAYCONG,SOTIETHOC,GHICHU) VALUES ((select max(DMCDID) + 1 from HSOFTDKBD.DT_DMCHAMCONG),'{0}','{1}',{2},{3},'{4}')", DMCDTEN, DMCDVIETTAT, SONGAYCONG, SOTIETHOC, GHICHU);
                result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
        }
        public bool UpdateDMChamCong(string DMCDTEN, string DMCDVIETTAT, int SONGAYCONG, int SOTIETHOC, string GHICHU, int DMCDID)
        {
            string query = string.Format("update HSOFTDKBD.DT_DMCHAMCONG set DMCDTEN = '{0}', DMCDVIETTAT = '{1}', SONGAYCONG = {2},SOTIETHOC= {3}, GHICHU ='{4}' WHERE DMCDID = {5}",  DMCDTEN, DMCDVIETTAT, SONGAYCONG, SOTIETHOC, GHICHU, DMCDID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDMChamCong(int id)
        {
            string query = string.Format("Delete HSOFTDKBD.DT_DMCHAMCONG where DMCDID = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //kiểm tra khi hoc vien da su dung chuc danh

        public int Count_ID()
        {
            string query = string.Format("select COUNT(DMCDID) from HSOFTDKBD.DT_DMCHAMCONG");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public bool Kiem_Tra_KyHieu(string DMCDVIETTAT)
        {
            string query = string.Format("select COUNT(DMCDVIETTAT) from HSOFTDKBD.DT_DMCHAMCONG");
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result > 0;
        }

        public DataTable Load_DMChamCong_to_CBB()
        {
            string query = "SELECT  ('(' || DMCDVIETTAT || ')  ' || DMCDTEN) AS DMCDTEN, DMCDVIETTAT FROM HSOFTDKBD.DT_DMCHAMCONG ORDER BY DMCDTEN ASC";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class CGKTCTDAO
    {
        private static CGKTCTDAO instance;

        public static CGKTCTDAO Instance
        {
            get { if (instance == null) instance = new CGKTCTDAO(); return CGKTCTDAO.instance; }
            private set { CGKTCTDAO.instance = value; }
        }
        private CGKTCTDAO() { }

        public string LoadNamHienTai()
        {
            DateTime now = DateTime.Now;
            return (now.Year).ToString();
        }


        public DataTable Load_Goi_CGKT(int NAMCGKT)
        {
            string query = string.Format("SELECT  CGKTID AS ID, CGKTTENGOI AS GOIKT FROM HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL CGKT INNER JOIN HSOFTDKBD.DT_BENHVIEN DVNCGKT ON DVNCGKT.DONVIID = CGKT.IDDVNHANCGKTLL WHERE CGKT.CGKTNAM = {0}",NAMCGKT);
            return DataProvider.Instance.ExecuteQuery(query);
        }


    }
}

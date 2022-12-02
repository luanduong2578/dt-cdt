using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class TinhTrangDeTaiDAO
   {
        private static TinhTrangDeTaiDAO instance;

        public static TinhTrangDeTaiDAO Instance
        {
            get {if(instance == null) instance = new TinhTrangDeTaiDAO(); return TinhTrangDeTaiDAO.instance; }
            private set { TinhTrangDeTaiDAO.instance = value; }
        }
        private TinhTrangDeTaiDAO() { }


        public DataTable LoadListTinhTrangDeTai()
        {
            string query = "select TTDTID, TTDTTEN from HSOFTDKBD.DT_TINHTRANGDETAI";
            return DataProvider.Instance.ExecuteQuery(query);
        }


    }
}

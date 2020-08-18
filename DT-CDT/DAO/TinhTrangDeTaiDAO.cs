using DT_CDT.DTO;
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

//
        public List<TinhTrangDeTai> GetDSTinhTrangDeTai()
        {
            List<TinhTrangDeTai> list = new List<TinhTrangDeTai>();

            string query = "select * from TinhTrangDeTai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TinhTrangDeTai ttdt = new TinhTrangDeTai(item);
                list.Add(ttdt);
            }

            return list;
        }
    }
}

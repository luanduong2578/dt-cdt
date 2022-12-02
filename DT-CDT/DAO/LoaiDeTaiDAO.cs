using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class LoaiDeTaiDAO
   {
        private static LoaiDeTaiDAO instance;

        public static LoaiDeTaiDAO Instance
        {
            get {if(instance == null) instance = new LoaiDeTaiDAO(); return LoaiDeTaiDAO.instance; }
            private set { LoaiDeTaiDAO.instance = value; }
        }
        private LoaiDeTaiDAO() { }

        public DataTable LoadListLoaiDeTai()
        {
            string query = "select IDLOAIDETAI,LOAIDETAITEN from HSOFTDKBD.DT_LOAIDETAI";
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
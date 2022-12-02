
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    public class CapDeTaiDAO
    {
        private static CapDeTaiDAO instance;

        public static CapDeTaiDAO Instance
        {
            get {if(instance == null) instance = new CapDeTaiDAO(); return CapDeTaiDAO.instance; }
            private set { CapDeTaiDAO.instance = value; }
        }
        private CapDeTaiDAO() { }



        public DataTable LoatListCapDeTai()
        {
            string query = "select CAPDTID, CAPDTTEN from HSOFTDKBD.DT_CAPDETAI";
            return DataProvider.Instance.ExecuteQuery(query);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class NamNCDAO
    {
        private static NamNCDAO instance;

        public static NamNCDAO Instance
        {
            get {if(instance == null) instance = new NamNCDAO(); return NamNCDAO.instance; }
            private set { NamNCDAO.instance = value; }
        }
        private NamNCDAO() { }


        public DataTable LoadListNamNC()
        {
            string query = "select NAMID,NAMTEN from HSOFTDKBD.DT_NAMNC";
            return DataProvider.Instance.ExecuteQuery(query);
        }


    }
}

using DT_CDT.DTO;
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

        //
        public List<NamNC> GetDSNamNC()
        {
            List<NamNC> list = new List<NamNC>();

            string query = "select * from NamNC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NamNC nam = new NamNC(item);
                list.Add(nam);
            }

            return list;
        }
        public List<NamNC> GetDSNamHCK()
        {
            List<NamNC> list = new List<NamNC>();

            string query = "select * from NamNC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NamNC nam = new NamNC(item);
                list.Add(nam);
            }

            return list;
        }
    }
}

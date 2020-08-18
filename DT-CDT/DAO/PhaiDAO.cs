using DT_CDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class PhaiDAO
    {
        private static PhaiDAO instance;

        public static PhaiDAO Instance
        {
            get {if(instance == null) instance = new PhaiDAO(); return PhaiDAO.instance; }
            private set { PhaiDAO.instance = value; }
        }
        private PhaiDAO() { }

        public DataTable LoadListPhai()
        {
            string query = "SELECT PHAIID, PHAITEN from HSOFTDKBD.DT_PHAI";
            return DataProvider.Instance.ExecuteQuery(query);
        }


//
        public List<Phai> GetDSPhai()
        {
            List<Phai> list = new List<Phai>();

            string query = "select * from Phai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phai phai = new Phai(item);
                list.Add(phai);
            }

            return list;
        }
     
    }
}

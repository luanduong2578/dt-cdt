using DT_CDT.DTO;
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

        //
        public List<CapDeTai> GetDSCapDeTai()
        {
            List<CapDeTai> list = new List<CapDeTai>();

            string query = "select * from CapDeTai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CapDeTai lvnc = new CapDeTai(item);
                list.Add(lvnc);
            }

            return list;
        }
    }
}
using DT_CDT.DTO;
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
//
        public List<LoaiDeTai> GetDSLoaiDeTai()
        {
            List<LoaiDeTai> list = new List<LoaiDeTai>();

            string query = "select * from LoaiDeTai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiDeTai lvnc = new LoaiDeTai(item);
                list.Add(lvnc);
            }

            return list;
        }
    }
}
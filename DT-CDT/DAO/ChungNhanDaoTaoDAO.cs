using DT_CDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class ChungNhanDaoTaoDAO
    {
        private static ChungNhanDaoTaoDAO instance;

        public static ChungNhanDaoTaoDAO Instance
        {
            get {if(instance == null) instance = new ChungNhanDaoTaoDAO(); return ChungNhanDaoTaoDAO.instance; }
            private set { ChungNhanDaoTaoDAO.instance = value; }
        }
        private ChungNhanDaoTaoDAO() { }


        public DataTable LoadListCNDAOTAO()
        {
            string query = "select CNDTID, CNDTTEN from HSOFTDKBD.DT_CNDAOTAO";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        //
        public List<ChungNhanDaoTao> GetDSChungNhanDaoTao()
        {
            List<ChungNhanDaoTao> list = new List<ChungNhanDaoTao>();

            string query = "select * from ChungNhanDaoTao";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChungNhanDaoTao ttdt = new ChungNhanDaoTao(item);
                list.Add(ttdt);
            }

            return list;
        }
    }
}

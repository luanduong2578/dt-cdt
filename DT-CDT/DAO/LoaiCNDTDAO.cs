
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class LoaiCNDTDAO
    {
        private static LoaiCNDTDAO instance;

        public static LoaiCNDTDAO Instance
        {
            get {if(instance == null) instance = new LoaiCNDTDAO(); return LoaiCNDTDAO.instance; }
            private set { LoaiCNDTDAO.instance = value; }
        }
        private LoaiCNDTDAO() { }


        public DataTable LoadListCNDAOTAO()
        {
            string query = "select CNDTID, CNDTTEN from HSOFTDKBD.DT_CNDAOTAO ORDER BY CNDTID ASC";
            return DataProvider.Instance.ExecuteQuery(query);
        }



    }
}

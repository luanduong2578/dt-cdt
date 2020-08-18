using DT_CDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class TinhTrangDaoTaoDAO
    {
        private static TinhTrangDaoTaoDAO instance;

        public static TinhTrangDaoTaoDAO Instance
        {
            get {if(instance == null) instance = new TinhTrangDaoTaoDAO(); return TinhTrangDaoTaoDAO.instance; }
            private set { TinhTrangDaoTaoDAO.instance = value; }
        }
        private TinhTrangDaoTaoDAO() { }

                
        public DataTable LoadListTinhTrangDaoTao()
        {
            string query = "select TTDTID, TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //
        public List<TinhTrangDaoTao> GetDSTinhTrangDaoTao()
        {
            List<TinhTrangDaoTao> list = new List<TinhTrangDaoTao>();

            string query = "select * from TinhTrangDaoTao";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TinhTrangDaoTao ttdt = new TinhTrangDaoTao(item);
                list.Add(ttdt);
            }

            return list;
        }
    }
}

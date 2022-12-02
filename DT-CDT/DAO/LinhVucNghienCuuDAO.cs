
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class LinhVucNghienCuuDAO
    {
        private static LinhVucNghienCuuDAO instance;

        public static LinhVucNghienCuuDAO Instance
        {
            get {if(instance == null) instance = new LinhVucNghienCuuDAO(); return LinhVucNghienCuuDAO.instance; }
            private set { LinhVucNghienCuuDAO.instance = value; }
        }
        private LinhVucNghienCuuDAO() { }

        public DataTable LoatListLinhVucNghienCuu()
        {
            string query = "select LVNCID, LVNCTEN from HSOFTDKBD.DT_LINHVUCNGHIENCUU";
            return DataProvider.Instance.ExecuteQuery(query);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class TaiKhoanDAO
    {
        public static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { TaiKhoanDAO.instance = value; }
        }
        private TaiKhoanDAO() { }
        public bool Login(string username, string password)
        {
            string query = string.Format("select * from hsoftdkbd.dt_login where userid = {0} and userpass = {1}", username, password);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

    }
}

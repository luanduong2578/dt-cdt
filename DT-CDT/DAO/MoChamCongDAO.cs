using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class MoChamCongDAO
    {
        private static MoChamCongDAO instance;

        public static MoChamCongDAO Instance
        {
            get { if (instance == null) instance = new MoChamCongDAO(); return MoChamCongDAO.instance; }
            private set { MoChamCongDAO.instance = value; }
        }
        private MoChamCongDAO() { }
        
        public bool UpdateMoChamCongHV(string HCKTHOIGIANBATDAU,string HCKTHOIGIANKETTHUC)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_MOCHAMCONG SET HCKTHOIGIANBATDAU = to_date('{0}','dd/MM/yyyy'),HCKTHOIGIANKETTHUC = to_date('{1}','dd/MM/yyyy')", HCKTHOIGIANBATDAU, HCKTHOIGIANKETTHUC);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public string GetMoCC_NGAYBATDAU()
        {
            string query = string.Format("select to_char(HCKTHOIGIANBATDAU,'MM/dd/yyyy') from HSOFTDKBD.DT_MOCHAMCONG");
            string data =DataProvider.Instance.ExecuteScalar(query).ToString();
            return data;
        }
        public string GetMoCC_NGAYKETTHUC()
        {
            string query = string.Format("select to_char(HCKTHOIGIANKETTHUC,'MM/dd/yyyy') from HSOFTDKBD.DT_MOCHAMCONG");
            string data = DataProvider.Instance.ExecuteScalar(query).ToString();
            return data;
        }
    }
}

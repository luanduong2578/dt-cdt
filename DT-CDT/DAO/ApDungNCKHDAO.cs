using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class ApDungNCKHDAO
    {
        private static ApDungNCKHDAO instance;

        public static ApDungNCKHDAO Instance
        {
            get { if (instance == null) instance = new ApDungNCKHDAO(); return ApDungNCKHDAO.instance; }
            private set { ApDungNCKHDAO.instance = value; }
        }
        private ApDungNCKHDAO() { }

        public DataTable LoadADNCKH(int nam)
        {
            string query = string.Format("SELECT ADKHMASO AS MA_ADKH, ADKHNAM AS NAM_AD,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = ad.IDKHOAPHONG) AS KHOA_PHONG_AD,NOIDUNGAPDUNG as NOI_DUNG_AP_DUNG,NGUONKH as NGUON_AD, NGAYBATDAUAPDUNG as NGAY_BAT_DAU, NGAYKETTHUCAPDUNG AS NGAY_KET_THUC, TIENDOAPDUNG TIEN_DO, ADKHKETQUA as KET_QUA_AD, ADKHGHICHU AS GHI_CHU from HSOFTDKBD.DT_APDUNGNCKH ad where ad.ADKHNAM ={0} ORDER BY ADKHMASO ASC", nam);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchADNCKHbyTuNamDenNam(int tunam, int dennam)
        {
            string query = string.Format("SELECT ADKHMASO AS MA_ADKH, ADKHNAM AS NAM_AD,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = ad.IDKHOAPHONG) AS KHOA_PHONG_AD,NOIDUNGAPDUNG as NOI_DUNG_AP_DUNG,NGUONKH as NGUON_AD, NGAYBATDAUAPDUNG as NGAY_BAT_DAU, NGAYKETTHUCAPDUNG AS NGAY_KET_THUC, TIENDOAPDUNG TIEN_DO, ADKHKETQUA as KET_QUA_AD, ADKHGHICHU AS GHI_CHU from HSOFTDKBD.DT_APDUNGNCKH ad where ad.ADKHNAM >= {0} and ADKHNAM <= {1} ORDER BY ADKHMASO ASC", tunam, dennam);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchADNCKHbyNoiDungAD(int tunam, int dennam, string tendt)
        {
            string query = string.Format("SELECT ADKHMASO AS MA_ADKH, ADKHNAM AS NAM_AD,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = ad.IDKHOAPHONG) AS KHOA_PHONG_AD,NOIDUNGAPDUNG as NOI_DUNG_AP_DUNG,NGUONKH as NGUON_AD, NGAYBATDAUAPDUNG as NGAY_BAT_DAU, NGAYKETTHUCAPDUNG AS NGAY_KET_THUC, TIENDOAPDUNG TIEN_DO, ADKHKETQUA as KET_QUA_AD, ADKHGHICHU AS GHI_CHU from HSOFTDKBD.DT_APDUNGNCKH ad where ad.ADKHNAM >= {0} and ADKHNAM <= {1} and UPPER(ad.NOIDUNGAPDUNG) LIKE UPPER('%{2}%') ORDER BY ADKHMASO ASC", tunam, dennam, tendt);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        
        public bool InsertADKH(int ADKHNAM, string NOIDUNGAPDUNG,string NGUONKH,int IDKHOAPHONG,string NGAYBATDAUAPDUNG, string NGAYKETTHUCAPDUNG,string TIENDOAPDUNG, string ADKHKETQUA, string ADKHGHICHU)
        {
            if (Count_ADKH() == 0)
            {
                string query = string.Format("INSERT INTO HSOFTDKBD.DT_APDUNGNCKH (ADKHID,ADKHMASO ,ADKHNAM, NOIDUNGAPDUNG,NGUONKH,IDKHOAPHONG,NGAYBATDAUAPDUNG, NGAYKETTHUCAPDUNG, TIENDOAPDUNG,ADKHKETQUA, ADKHGHICHU, UPD) VALUES (1,'ADKH0001',{0},'{1}','{2}',{3},to_date('{4}','dd/MM/yyyy'),to_date('{5}','dd/MM/yyyy'), '{6}','{7}', '{8}',sysdate)", ADKHNAM, NOIDUNGAPDUNG, NGUONKH, IDKHOAPHONG, NGAYBATDAUAPDUNG, NGAYKETTHUCAPDUNG, TIENDOAPDUNG, ADKHKETQUA,  ADKHGHICHU);
                                                                                                                                                                                                                                               
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            else
            {
                string MCKHMASO = "";
                if (GetADKHId() < 10)
                {
                    MCKHMASO = string.Format("ADKH000{0}", GetADKHId().ToString());
                }
                else if (GetADKHId() < 100)
                {
                    MCKHMASO = string.Format("ADKH00{0}", GetADKHId().ToString());
                }
                else if (GetADKHId() < 1000)
                {
                    MCKHMASO = string.Format("ADKH0{0}", GetADKHId().ToString());
                }
                else
                {
                    MCKHMASO = string.Format("NCKH{0}", GetADKHId().ToString());
                }
                string query = string.Format("INSERT INTO HSOFTDKBD.DT_APDUNGNCKH (ADKHID,ADKHNAM, NOIDUNGAPDUNG,NGUONKH,IDKHOAPHONG,NGAYBATDAUAPDUNG, NGAYKETTHUCAPDUNG, TIENDOAPDUNG,  ADKHKETQUA, ADKHGHICHU, ADKHMASO ,UPD) VALUES ((select MAX(ADKHID)+1 from HSOFTDKBD.DT_APDUNGNCKH),{0},'{1}','{2}',{3},to_date('{4}','dd/MM/yyyy'),to_date('{5}','dd/MM/yyyy'), '{6}','{7}','{8}','{9}',sysdate)", ADKHNAM, NOIDUNGAPDUNG, NGUONKH, IDKHOAPHONG, NGAYBATDAUAPDUNG, NGAYKETTHUCAPDUNG, TIENDOAPDUNG, ADKHKETQUA, ADKHGHICHU, MCKHMASO);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
        }

        public bool UpdateADKH(int ADKHNAM, string NOIDUNGAPDUNG, string NGUONKH, int IDKHOAPHONG, string NGAYBATDAUAPDUNG, string NGAYKETTHUCAPDUNG, string TIENDOAPDUNG, string ADKHKETQUA,string  ADKHGHICHU, int ADKHID)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_APDUNGNCKH SET ADKHNAM = {0}, NOIDUNGAPDUNG = '{1}', NGUONKH = '{2}', IDKHOAPHONG = {3}, NGAYBATDAUAPDUNG = to_date('{4}','dd/MM/yyyy'), NGAYKETTHUCAPDUNG = to_date('{5}','dd/MM/yyyy'), TIENDOAPDUNG = '{6}',ADKHKETQUA = '{7}', ADKHGHICHU = '{8}' , UPD = sysdate  where ADKHID = {9}", ADKHNAM, NOIDUNGAPDUNG, NGUONKH, IDKHOAPHONG, NGAYBATDAUAPDUNG, NGAYKETTHUCAPDUNG, TIENDOAPDUNG, ADKHKETQUA,ADKHGHICHU, ADKHID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteADKH(int NCKHid)
        {
            string query = string.Format("Delete HSOFTDKBD.DT_APDUNGNCKH where ADKHID = {0}", NCKHid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public string LoadNamNCKH()
        {
            DateTime now = DateTime.Now;
            return (now.Year).ToString();
        }
        //kiem tra hoc vien khi insert hoc vien
        public int Count_ADKH()
        {
            string query = string.Format("select COUNT(ADKHID) from HSOFTDKBD.DT_APDUNGNCKH");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public int GetHCKIdByMAADKH(string MANCKH)
        {
            string query = string.Format("select ADKHID from HSOFTDKBD.DT_APDUNGNCKH where ADKHMASO = '{0}'", MANCKH);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public int GetADKHId()
        {
            string query = string.Format("select MAX(ADKHID)+1 from HSOFTDKBD.DT_APDUNGNCKH");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }




    }
}
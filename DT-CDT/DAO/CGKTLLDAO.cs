using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class CGKTLLDAO
    {
        private static CGKTLLDAO instance;

        public static CGKTLLDAO Instance
        {
            get { if (instance == null) instance = new CGKTLLDAO(); return CGKTLLDAO.instance; }
            private set { CGKTLLDAO.instance = value; }
        }
        private CGKTLLDAO() { }

        public string LoadNamHienTai()
        {
            DateTime now = DateTime.Now;
            return (now.Year).ToString();
            
        }


        public DataTable Load_Goi_CGKT(int NamHH)
        {
            string query = string.Format(" SELECT  CGKTMASO AS CGKT_MA, CGKTNAM  AS NAM,CGKTTENGOI AS TEN_GOI_CGKT,DVNCGKT.DONVITEN AS DON_VI_NHAN_CGKT,CGKTBATDAU AS TU_NGAY,CGKTKETTHUC AS DEN_NGAY,(SELECT KPCG.KHOAPHONGTEN FROM HSOFTDKBD.DT_KHOAPHONG KPCG WHERE KPCG.KHOAPHONGID = IDKHOAPHONGCGKT ) AS KHOA_PHONG_CGKT, HV.HOCVIENHOTEN AS CAN_BO_DAU_MOI,HV.HOCVIENPHAI AS PHAI,HV.HOCVIENNAMSINH AS NGAY_SINH, (SELECT CD.CHUCDANHTEN FROM HSOFTDKBD.DT_CHUCDANH CD WHERE CD.CHUCDANHID = HV.IDCHUCDANH) AS CHUC_DANH,(SELECT BV.DONVITEN FROM HSOFTDKBD.DT_BENHVIEN BV WHERE BV.DONVIID = HV.IDDONVI) AS DON_VI_CONG_TAC, (SELECT KP.KHOAPHONGTEN FROM HSOFTDKBD.DT_KHOAPHONG KP WHERE KP.KHOAPHONGID = HV.IDKHOAPHONG) AS KHOA_PHONG,        GHICHU AS GHI_CHU                FROM HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL CGKT        INNER JOIN HSOFTDKBD.DT_BENHVIEN DVNCGKT ON DVNCGKT.DONVIID = CGKT.IDDVNHANCGKTLL        LEFT JOIN HSOFTDKBD.DT_HOCVIEN HV ON HV.HOCVIENID = CGKT.IDCBDMCGKT where CGKT.CGKTNAM  ={0} ORDER BY CGKTMASO ASC", NamHH);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable Search_Goi_CGKT_TuNamDenNam(int tunam, int dennam)
        {
            string query = string.Format(" SELECT  CGKTMASO AS CGKT_MA, CGKTNAM  AS NAM,CGKTTENGOI AS TEN_GOI_CGKT,DVNCGKT.DONVITEN AS DON_VI_NHAN_CGKT,CGKTBATDAU AS TU_NGAY,CGKTKETTHUC AS DEN_NGAY,(SELECT KPCG.KHOAPHONGTEN FROM HSOFTDKBD.DT_KHOAPHONG KPCG WHERE KPCG.KHOAPHONGID = IDKHOAPHONGCGKT ) AS KHOA_PHONG_CGKT, HV.HOCVIENHOTEN AS CAN_BO_DAU_MOI,HV.HOCVIENPHAI AS PHAI,HV.HOCVIENNAMSINH AS NGAY_SINH, (SELECT CD.CHUCDANHTEN FROM HSOFTDKBD.DT_CHUCDANH CD WHERE CD.CHUCDANHID = HV.IDCHUCDANH) AS CHUC_DANH,(SELECT BV.DONVITEN FROM HSOFTDKBD.DT_BENHVIEN BV WHERE BV.DONVIID = HV.IDDONVI) AS DON_VI_CONG_TAC, (SELECT KP.KHOAPHONGTEN FROM HSOFTDKBD.DT_KHOAPHONG KP WHERE KP.KHOAPHONGID = HV.IDKHOAPHONG) AS KHOA_PHONG,        GHICHU AS GHI_CHU                FROM HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL CGKT        INNER JOIN HSOFTDKBD.DT_BENHVIEN DVNCGKT ON DVNCGKT.DONVIID = CGKT.IDDVNHANCGKTLL        LEFT JOIN HSOFTDKBD.DT_HOCVIEN HV ON HV.HOCVIENID = CGKT.IDCBDMCGKT where CGKT.CGKTNAM >= {0} and CGKT.CGKTNAM <= {1} ORDER BY CGKTMASO ASC", tunam, dennam);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable Search_Goi_CGKT_TuNamDenNam_TenGoi(int tunam, int dennam, string TenGoi)
        {
            string query = string.Format(" SELECT  CGKTMASO AS CGKT_MA, CGKTNAM  AS NAM,CGKTTENGOI AS TEN_GOI_CGKT,DVNCGKT.DONVITEN AS DON_VI_NHAN_CGKT,CGKTBATDAU AS TU_NGAY,CGKTKETTHUC AS DEN_NGAY,(SELECT KPCG.KHOAPHONGTEN FROM HSOFTDKBD.DT_KHOAPHONG KPCG WHERE KPCG.KHOAPHONGID = IDKHOAPHONGCGKT ) AS KHOA_PHONG_CGKT, HV.HOCVIENHOTEN AS CAN_BO_DAU_MOI,HV.HOCVIENPHAI AS PHAI,HV.HOCVIENNAMSINH AS NGAY_SINH, (SELECT CD.CHUCDANHTEN FROM HSOFTDKBD.DT_CHUCDANH CD WHERE CD.CHUCDANHID = HV.IDCHUCDANH) AS CHUC_DANH,(SELECT BV.DONVITEN FROM HSOFTDKBD.DT_BENHVIEN BV WHERE BV.DONVIID = HV.IDDONVI) AS DON_VI_CONG_TAC, (SELECT KP.KHOAPHONGTEN FROM HSOFTDKBD.DT_KHOAPHONG KP WHERE KP.KHOAPHONGID = HV.IDKHOAPHONG) AS KHOA_PHONG,        GHICHU AS GHI_CHU                FROM HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL CGKT        INNER JOIN HSOFTDKBD.DT_BENHVIEN DVNCGKT ON DVNCGKT.DONVIID = CGKT.IDDVNHANCGKTLL        LEFT JOIN HSOFTDKBD.DT_HOCVIEN HV ON HV.HOCVIENID = CGKT.IDCBDMCGKT where CGKT.CGKTNAM >= {0} and CGKT.CGKTNAM <= {1} and + UPPER(CGKTTENGOI) LIKE UPPER('%{2}%') ORDER BY CGKTMASO ASC", tunam, dennam, TenGoi);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        
        public DataTable LoadListCGKT()
        {
            string query = "select CGKTID,CGKTTENGOI from HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool DeleteCGKT(int id)
        {
            string query = string.Format("Delete HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL where CGKTID = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Count_GOI_CGKT_In_CGKTCT(int ID)
        {
            string query = string.Format("SELECT COUNT(CGKTID) FROM HSOFTDKBD.DT_CHUYENGIAOKYTHUATCT where CGKTID = {0}", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public int Count_CGKT()
        {
            string query = string.Format("select COUNT(*) from HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public int getID_By_CGKTMASO(string maso)
        {
            string query = string.Format("select CGKTID from HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL where  CGKTMASO = '{0}'", maso);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }

        public int MAX_ID()
        {
            string query = string.Format("select MAX(CGKTID) +1  from HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }

        public bool InsertCGKT(int CGKTNAM ,string CGKTTENGOI,int IDDVNHANCGKTLL,string CGKTBATDAU,string CGKTKETTHUC, int IDKHOAPHONGCGKT, int IDCBDMCGKT,string GHICHU)
        {
            if (Count_CGKT() == 0)
            {
                string query = string.Format("INSERT INTO HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL(CGKTID, CGKTNAM, CGKTTENGOI, IDDVNHANCGKTLL, CGKTBATDAU, CGKTKETTHUC,IDKHOAPHONGCGKT, IDCBDMCGKT, GHICHU, UPD, CGKTMASO) VALUES (1,{0},'{1}',{2},to_date('{3}','dd/MM/yyyy'),to_date('{4}','dd/MM/yyyy'),{5},{6},'{7}',sysdate, 'CGKT0001')", CGKTNAM, CGKTTENGOI,IDDVNHANCGKTLL, CGKTBATDAU, CGKTKETTHUC, IDKHOAPHONGCGKT, IDCBDMCGKT, GHICHU);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            else
            {
                string MACGKT = "";
                if (MAX_ID() < 10)
                {
                    MACGKT = string.Format("CGKT000{0}", MAX_ID().ToString());
                }
                else if (MAX_ID() < 100)
                {
                    MACGKT = string.Format("CGKT00{0}", MAX_ID().ToString());
                }
                else if (MAX_ID() < 1000)
                {
                    MACGKT = string.Format("CGKT0{0}", MAX_ID().ToString());
                }
                else
                {
                    MACGKT = string.Format("CGKT{0}", MAX_ID().ToString());
                }

                string query = string.Format("INSERT INTO HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL (CGKTID, CGKTNAM, CGKTTENGOI, IDDVNHANCGKTLL, CGKTBATDAU, CGKTKETTHUC, IDKHOAPHONGCGKT, IDCBDMCGKT, GHICHU, CGKTMASO, UPD) VALUES ((select MAX(CGKTID) +1  from HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL),{0},'{1}',{2},to_date('{3}','dd/MM/yyyy'),to_date('{4}','dd/MM/yyyy'),{5}, {6},'{7}','{8}',sysdate)", CGKTNAM, CGKTTENGOI, IDDVNHANCGKTLL, CGKTBATDAU, CGKTKETTHUC, IDKHOAPHONGCGKT,IDCBDMCGKT, GHICHU, MACGKT);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
        }
        public bool UpdateCGKT(int CGKTNAM, string CGKTTENGOI, int IDDVNHANCGKTLL, string CGKTBATDAU, string CGKTKETTHUC, int IDKHOAPHONGCGKT, int IDCBDMCGKT, string GHICHU, int CGKTID)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_CHUYENGIAOKYTHUATLL SET CGKTNAM = {0},CGKTTENGOI= '{1}',IDDVNHANCGKTLL = {2}, CGKTBATDAU = to_date('{3}','dd/MM/yyyy'),CGKTKETTHUC = to_date('{4}','dd/MM/yyyy'), IDKHOAPHONGCGKT = {5}, IDCBDMCGKT = {6}, GHICHU = '{7}', UPD = sysdate WHERE CGKTID = {8}", CGKTNAM, CGKTTENGOI, IDDVNHANCGKTLL, CGKTBATDAU, CGKTKETTHUC, IDKHOAPHONGCGKT,IDCBDMCGKT, GHICHU, CGKTID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
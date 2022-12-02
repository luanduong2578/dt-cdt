using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class ChamCongDTTLDAO
    {
        private static ChamCongDTTLDAO instance;

        public static ChamCongDTTLDAO Instance
        {
            get { if (instance == null) instance = new ChamCongDTTLDAO(); return ChamCongDTTLDAO.instance; }
            private set { ChamCongDTTLDAO.instance = value; }
        }
        private ChamCongDTTLDAO() { }

        public int Count_idChamCong()
        {
            string query = string.Format("select COUNT(CCDTTLID) from HSOFTDKBD.DT_CHAMCONGDTTL");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public string LoadNamHienTai()
        {
            DateTime now = DateTime.Now;
            return (now.Year).ToString();
        }

        public bool Kiemtra_IDLOPHOC_MMYY_IDHOCVIEN(int IDLOPHOC, string MMYY, int IDHOCVIEN)
        {
            string query = string.Format("select COUNT(*) from HSOFTDKBD.DT_CHAMCONGDTTL WHERE MALOP = {0}  AND MMYY = '{1}' AND IDHOCVIEN = {2}", IDLOPHOC, MMYY, IDHOCVIEN);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result > 0;
        }
        

        public bool InsertChamCongHV_DTTL(string MMYY, int IDHOCVIEN, int MALOP, int IDKHOAPHONG, string HCKTHOIGIANBATDAU, string HCKTHOIGIANKETTHUC, int TINHTRANG_CHAMCONG)
        {
            if (Count_idChamCong() == 0)
            {
                string query = string.Format("insert into HSOFTDKBD.DT_CHAMCONGDTTL  (CCDTTLID, MMYY, IDHOCVIEN, MALOP, IDKHOAPHONG,HCKTHOIGIANBATDAU,HCKTHOIGIANKETTHUC, TINHTRANG) values (1,'{0}',{1},{2},{3},to_date('{4}','MM/dd/yyyy'),to_date('{5}','MM/dd/yyyy'),{6})", MMYY, IDHOCVIEN, MALOP, IDKHOAPHONG, HCKTHOIGIANBATDAU, HCKTHOIGIANKETTHUC, TINHTRANG_CHAMCONG);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            else
            {
                string query = string.Format("insert into HSOFTDKBD.DT_CHAMCONGDTTL  (CCDTTLID, MMYY, IDHOCVIEN, MALOP, IDKHOAPHONG,HCKTHOIGIANBATDAU,HCKTHOIGIANKETTHUC, TINHTRANG) values ((select max(CCDTTLID) +1  from HSOFTDKBD.DT_CHAMCONGDTTL) ,'{0}',{1},{2},{3},to_date('{4}','MM/dd/yyyy'),to_date('{5}','MM/dd/yyyy'),{6})", MMYY, IDHOCVIEN, MALOP, IDKHOAPHONG, HCKTHOIGIANBATDAU, HCKTHOIGIANKETTHUC, TINHTRANG_CHAMCONG);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
        }

        public bool UpdateChamCongHV_DTTL(string MMYY, int IDHOCVIEN, int MALOP, int IDKHOAPHONG, string HCKTHOIGIANBATDAU, string HCKTHOIGIANKETTHUC)
        {
                string query = string.Format("update HSOFTDKBD.DT_CHAMCONGDTTL set IDKHOAPHONG = {0}, HCKTHOIGIANBATDAU = to_date('{1}','MM/dd/yyyy'),HCKTHOIGIANKETTHUC = to_date('{2}','MM/dd/yyyy'), TINHTRANG = 1 where MMYY = '{3}' and  IDHOCVIEN = {4}  and MALOP = {5}", IDKHOAPHONG, HCKTHOIGIANBATDAU, HCKTHOIGIANKETTHUC, MMYY, IDHOCVIEN, MALOP);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
           
        }



        public bool DeleteChamCongHV_DTTL(int IDHOCVIEN, int MALOP)
        {
            string query = string.Format("DELETE HSOFTDKBD.DT_CHAMCONGDTTL where IDHOCVIEN = {0} and MALOP = {1}", IDHOCVIEN, MALOP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // set về 0
        public bool Update_TinhTrang_ChamCongHV_by_TaoDuLieuChamCong(int IDLOPHOC, int IDHOCVIEN)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_CHAMCONGDTTL SET  TINHTRANG = 0  where MALOP = {0} and IDHOCVIEN ={1}", IDLOPHOC, IDHOCVIEN);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        
        public bool KIEMTRA_CHAMCONG_TONTAI(string MMYY,int IDHOCVIEN, int IDLOPHOC)
        {
            string query = string.Format("select COUNT(*) from HSOFTDKBD.DT_CHAMCONGDTTL WHERE MMYY = '{0}'  AND MALOP = {1} AND IDHOCVIEN = {2}", MMYY, IDLOPHOC, IDHOCVIEN);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result > 0;
        }
         
        public bool UpdateChamCongHV(string MMYY, int MALOP,int IDHOCVIEN, int IDKHOAPHONG, string HCKTHOIGIANBATDAU, string HCKTHOIGIANKETTHUC, int TINHTRANG)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_CHAMCONGDTTL SET  IDKHOAPHONG = {0} , HCKTHOIGIANBATDAU = to_date('{1}','MM/dd/yyyy'),HCKTHOIGIANKETTHUC = to_date('{2}','MM/dd/yyyy'), TINHTRANG = 1 WHERE MALOP = {3} AND MMYY = '{4}' AND IDHOCVIEN = {5}", IDKHOAPHONG, HCKTHOIGIANBATDAU, HCKTHOIGIANKETTHUC, MALOP, MMYY, IDHOCVIEN);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public DataTable LoadChamCong_DTTL(string MMYY)
        {
            string query = string.Format("SELECT CC.MMYY AS MMYY,LOPDTTL.DTTLMASO AS MA_LOP,HV.HOCVIENHOTEN AS HOC_VIEN,(SELECT KP.KHOAPHONGTEN FROM HSOFTDKBD.DT_KHOAPHONG KP WHERE KP.KHOAPHONGID = CC.IDKHOAPHONG) AS KHOA_DAO_TAO, LOPDTTL.NOIDUNGHOC AS TEN_LOP,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,N31, CC.GHICHU, LOPDTTL.DSLOPDTTLID, CC.IDHOCVIEN         FROM HSOFTDKBD.DT_CHAMCONGDTTL CC   INNER JOIN HSOFTDKBD.DT_DSLOPDTTL LOPDTTL ON LOPDTTL.DSLOPDTTLID = CC.MALOP   INNER JOIN HSOFTDKBD.DT_HOCVIEN HV ON HV.HOCVIENID = CC.IDHOCVIEN      WHERE CC.TINHTRANG > 0 AND MMYY ='{0}'", MMYY);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LoadChamCong_DTTL_TIMLOP(string MMYY, string TIMLOP)
        {
            string query = string.Format("SELECT CC.MMYY AS MMYY,LOPDTTL.DTTLMASO AS MA_LOP,HV.HOCVIENHOTEN AS HOC_VIEN,(SELECT KP.KHOAPHONGTEN FROM HSOFTDKBD.DT_KHOAPHONG KP WHERE KP.KHOAPHONGID = CC.IDKHOAPHONG) AS KHOA_DAO_TAO, LOPDTTL.NOIDUNGHOC AS TEN_LOP,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,N31, CC.GHICHU, LOPDTTL.DSLOPDTTLID, CC.IDHOCVIEN         FROM HSOFTDKBD.DT_CHAMCONGDTTL CC   INNER JOIN HSOFTDKBD.DT_DSLOPDTTL LOPDTTL ON LOPDTTL.DSLOPDTTLID = CC.MALOP   INNER JOIN HSOFTDKBD.DT_HOCVIEN HV ON HV.HOCVIENID = CC.IDHOCVIEN      WHERE CC.TINHTRANG > 0 AND MMYY ='{0}' AND + UPPER(LOPDTTL.NOIDUNGHOC) LIKE UPPER('%{1}%')", MMYY, TIMLOP);
            return DataProvider.Instance.ExecuteQuery(query);
        }




        public DataTable Load_TENLOP()
        {
            string query = "SELECT DSLOPDTTLID, NOIDUNGHOC from HSOFTDKBD.DT_DSLOPDTTL WHERE TRANGTHAILOP = 0 ORDER BY NOIDUNGHOC ASC";
            return DataProvider.Instance.ExecuteQuery(query);
        }



        public bool UpdateChamCong_DTTL(string COT_NGAY, string LOAI_CC, int IDLOP,int IDHOCVIEN, string MMYY, string GHICHU)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_CHAMCONGDTTL SET  {0} = '{1}', GHICHU ='{2}' WHERE MALOP = {3} AND MMYY = {4} AND IDHOCVIEN ={5}", COT_NGAY, LOAI_CC, GHICHU, IDLOP, MMYY,IDHOCVIEN);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool Kiemtra_IDHCK_MMYY_DTTL(int MALOP, string MMYY,int IDHOCVIEN)
        {
            string query = string.Format("select COUNT(*) from HSOFTDKBD.DT_CHAMCONGDTTL WHERE MALOP = {0}  AND MMYY = '{1}' AND IDHOCVIEN = {2}", MALOP, MMYY, IDHOCVIEN);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result > 0;
        }




















        public DataTable LoadChamCong_Search_Lop(string TENLOP)
        {
            string query = string.Format("SELECT MMYY AS MMYY,HCK.HCKMASO AS MA_LOP,HV.HOCVIENHOTEN AS HOC_VIEN,(SELECT KP.KHOAPHONGTEN FROM HSOFTDKBD.DT_KHOAPHONG KP WHERE KP.KHOAPHONGID = CC.IDKHOAPHONG) AS KHOA_DAO_TAO, HCK.HCKNOIDUNGDAOTAO AS TEN_LOP,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,N31, GHICHU FROM HSOFTDKBD.DT_CHAMCONG CC INNER JOIN HSOFTDKBD.DT_HOCCHUYENKHOA HCK ON HCK.HCKID = CC.IDHCK INNER JOIN HSOFTDKBD.DT_HOCVIEN HV ON HV.HOCVIENID = CC.IDHOCVIEN  WHERE CC.TINHTRANG > 0 AND + UPPER(HCK.HCKNOIDUNGDAOTAO) LIKE UPPER('%{0}%') ORDER BY HV.HOCVIENHOTEN ASC ", TENLOP);
            // string query = string.Format("SELECT hck.HCKID as MA_HCK,hck.HCKNAM as NAM_DT, hv.HOCVIENHOTEN as HO_TEN_HV,(select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAITEN = hv.HOCVIENPHAI) as PHAI, hv.HOCVIENNAMSINH, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = hv.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) as KHOA_PHONG,(select kpdt.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kpdt where kpdt.KHOAPHONGID = hck.KPDAOTAOID) as KHOA_PHONG_DAO_TAO,HCKNOIDUNGDAOTAO as NOI_DUNG_DAO_TAO, (select ttdt.TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO ttdt where ttdt.TTDTID = hck.HCKTINHTRANGDTID) as TINH_TRANG_DAO_TAO, HCKKINHPHI as KINH_PHI,HCKTHOIGIANDAOTAO  as SO_THANG_HOC,HCKTHOIGIANBATDAU as THOI_GIAN_BD,HCKTHOIGIANKETTHUC as THOI_GIAN_KT,HCKKETQUATB as KET_QUA_TB,HCKKETQUALT as KET_QUA_LT,HCKKETQUATH as KET_QUA_TH,(select cn.CNDTTEN from hsoftdkbd.DT_CNDAOTAO cn where cn.CNDTID = hck.HCKCHUNGNHANID) as LOAI_CHUNG_NHAN, HCKGHICHU as GHI_CHU FROM HSOFTDKBD.DT_HOCCHUYENKHOA hck left join HSOFTDKBD.DT_HOCVIEN hv on hck.HCKHOCVIENID = hv.HOCVIENID", namDT);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LoadChamCong_Search_HOCVIEN(string HOCVIEN)
        {
            string query = string.Format("SELECT MMYY AS MMYY,HCK.HCKMASO AS MA_LOP,HV.HOCVIENHOTEN AS HOC_VIEN,(SELECT KP.KHOAPHONGTEN FROM HSOFTDKBD.DT_KHOAPHONG KP WHERE KP.KHOAPHONGID = CC.IDKHOAPHONG) AS KHOA_DAO_TAO, HCK.HCKNOIDUNGDAOTAO AS TEN_LOP,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,N31, GHICHU FROM HSOFTDKBD.DT_CHAMCONG CC INNER JOIN HSOFTDKBD.DT_HOCCHUYENKHOA HCK ON HCK.HCKID = CC.IDHCK INNER JOIN HSOFTDKBD.DT_HOCVIEN HV ON HV.HOCVIENID = CC.IDHOCVIEN  WHERE CC.TINHTRANG > 0 AND + UPPER(HV.HOCVIENHOTEN) LIKE UPPER('%{0}%') ORDER BY HV.HOCVIENHOTEN ASC ", HOCVIEN);
            // string query = string.Format("SELECT hck.HCKID as MA_HCK,hck.HCKNAM as NAM_DT, hv.HOCVIENHOTEN as HO_TEN_HV,(select p.PHAITEN from HSOFTDKBD.DT_PHAI p where p.PHAITEN = hv.HOCVIENPHAI) as PHAI, hv.HOCVIENNAMSINH, (select cd.ChucDanhTen from HSOFTDKBD.DT_CHUCDANH cd where cd.CHUCDANHID = hv.IDCHUCDANH) as CHUC_DANH, (select dvct.DONVITEN from HSOFTDKBD.DT_BENHVIEN dvct where dvct.DONVIID = hv.IDDONVI) as DON_VI_CONG_TAC,(select kp.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kp where kp.KHOAPHONGID = hv.IDKHOAPHONG) as KHOA_PHONG,(select kpdt.KHOAPHONGTEN from HSOFTDKBD.DT_KHOAPHONG kpdt where kpdt.KHOAPHONGID = hck.KPDAOTAOID) as KHOA_PHONG_DAO_TAO,HCKNOIDUNGDAOTAO as NOI_DUNG_DAO_TAO, (select ttdt.TTDTTEN from HSOFTDKBD.DT_TINHTRANGDAOTAO ttdt where ttdt.TTDTID = hck.HCKTINHTRANGDTID) as TINH_TRANG_DAO_TAO, HCKKINHPHI as KINH_PHI,HCKTHOIGIANDAOTAO  as SO_THANG_HOC,HCKTHOIGIANBATDAU as THOI_GIAN_BD,HCKTHOIGIANKETTHUC as THOI_GIAN_KT,HCKKETQUATB as KET_QUA_TB,HCKKETQUALT as KET_QUA_LT,HCKKETQUATH as KET_QUA_TH,(select cn.CNDTTEN from hsoftdkbd.DT_CNDAOTAO cn where cn.CNDTID = hck.HCKCHUNGNHANID) as LOAI_CHUNG_NHAN, HCKGHICHU as GHI_CHU FROM HSOFTDKBD.DT_HOCCHUYENKHOA hck left join HSOFTDKBD.DT_HOCVIEN hv on hck.HCKHOCVIENID = hv.HOCVIENID", namDT);
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public int max_IDChamCong()
        {
            string query = string.Format("select max(CCHCKID) from HSOFTDKBD.DT_CHAMCONG");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }



        public bool UpdateChamCongHV_TINHTRANG(int IDHCK)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_CHAMCONG SET TINHTRANG= 0 WHERE IDHCK = {0}", IDHCK);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateChamCong(string COT_NGAY, string LOAI_CC, int IDLOP, string MMYY, string GHICHU)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_CHAMCONG SET  {0} = '{1}', GHICHU ='{2}' WHERE IDHCK = {3} AND MMYY = {4}", COT_NGAY, LOAI_CC, GHICHU, IDLOP, MMYY);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Kiemtra_IDHCK_MMYY(int IDHCK, string MMYY)
        {
            string query = string.Format("select COUNT(*) from HSOFTDKBD.DT_CHAMCONG WHERE IDHCK = {0}  AND MMYY = '{1}'", IDHCK, MMYY);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result > 0;
        }
        public int get_IDLOP_By_MALOP(string MALOP)
        {
            string query = string.Format("select HCKID from HSOFTDKBD.DT_HOCCHUYENKHOA where HCKMASO = '{0}'", MALOP);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class DSHocVienSHKHDAO
    {
        private static DSHocVienSHKHDAO instance;

        public static DSHocVienSHKHDAO Instance
        {
            get { if (instance == null) instance = new DSHocVienSHKHDAO(); return DSHocVienSHKHDAO.instance; }
            private set { DSHocVienSHKHDAO.instance = value; }
        }
        private DSHocVienSHKHDAO() { }

        public string LoadNamHienTai()
        {
            DateTime now = DateTime.Now;
            return (now.Year).ToString();
        }


        public DataTable LoadDSLop(int NamLH)
        {
            string query = string.Format("select dt.IDHOCVIEN  as MA_NVHV,  hv.HOCVIENHOTEN as HO_TEN_HV,p.PHAITEN as PHAI, hv.HOCVIENNAMSINH as NGAY_SINH,cd.CHUCDANHTEN as CHUC_DANH , dv.DONVITEN as DON_VI_CONG_TAC,kp.KHOAPHONGTEN as KHOA_PHONG, lh.SHKHMASO as MA_LOP,lh.NOIDUNGHOC as TEN_LOP, dt.SOTIETHOC as SO_TIET_HOC, dt.SOTIETNGHI as SO_TIET_NGHI,dt.GOICHUYENGIAOKT as GOI_KT, cndt.CNDTTEN AS LOAI_CHUNG_NHAN, dt.GHICHU as GHI_CHU from HSOFTDKBD.DT_DSHOCVIENSHKH dt inner join HSOFTDKBD.DT_HOCVIEN hv on dt.IDHOCVIEN = hv.HOCVIENID inner join HSOFTDKBD.DT_DSLOPSHKH lh on lh.DSLOPSHKHID = dt.IDLOPHOC left join HSOFTDKBD.DT_PHAI p on p.PHAITEN = hv.HOCVIENPHAI left join HSOFTDKBD.DT_CHUCDANH cd on cd.CHUCDANHID = hv.IDCHUCDANH left join HSOFTDKBD.DT_BENHVIEN dv on dv.DONVIID = hv.IDDONVI left join HSOFTDKBD.DT_KHOAPHONG kp on kp.KHOAPHONGID = hv.IDKHOAPHONG left join hsoftdkbd.DT_CNDAOTAO  cndt on cndt.CNDTID = dt.IDLOAICN WHERE LH.NAMLOPHOC = {0} ORDER BY dt.IDHOCVIEN", NamLH);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchDSHVbyTuNamDenNam(int tunam, int dennam)
        {
            string query = string.Format("select dt.IDHOCVIEN  as MA_NVHV,  hv.HOCVIENHOTEN as HO_TEN_HV,p.PHAITEN as PHAI, hv.HOCVIENNAMSINH as NGAY_SINH,cd.CHUCDANHTEN as CHUC_DANH , dv.DONVITEN as DON_VI_CONG_TAC,kp.KHOAPHONGTEN as KHOA_PHONG, lh.SHKHMASO as MA_LOP,lh.NOIDUNGHOC as TEN_LOP, dt.SOTIETHOC as SO_TIET_HOC, dt.SOTIETNGHI as SO_TIET_NGHI,dt.GOICHUYENGIAOKT as GOI_KT, cndt.CNDTTEN AS LOAI_CHUNG_NHAN, dt.GHICHU as GHI_CHU from HSOFTDKBD.DT_DSHOCVIENSHKH dt inner join HSOFTDKBD.DT_HOCVIEN hv on dt.IDHOCVIEN = hv.HOCVIENID inner join HSOFTDKBD.DT_DSLOPSHKH lh on lh.DSLOPSHKHID = dt.IDLOPHOC left join HSOFTDKBD.DT_PHAI p on p.PHAITEN = hv.HOCVIENPHAI left join HSOFTDKBD.DT_CHUCDANH cd on cd.CHUCDANHID = hv.IDCHUCDANH left join HSOFTDKBD.DT_BENHVIEN dv on dv.DONVIID = hv.IDDONVI left join HSOFTDKBD.DT_KHOAPHONG kp on kp.KHOAPHONGID = hv.IDKHOAPHONG left join hsoftdkbd.DT_CNDAOTAO  cndt on cndt.CNDTID = dt.IDLOAICN  where lh.NAMLOPHOC >= {0} and lh.NAMLOPHOC <= {1} ORDER BY dt.IDHOCVIEN", tunam, dennam);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchDSHVbyTenLop(int tunam, int dennam, string tenlop)
        {
            string query = string.Format("select dt.IDHOCVIEN  as MA_NVHV,  hv.HOCVIENHOTEN as HO_TEN_HV,p.PHAITEN as PHAI, hv.HOCVIENNAMSINH as NGAY_SINH,cd.CHUCDANHTEN as CHUC_DANH , dv.DONVITEN as DON_VI_CONG_TAC,kp.KHOAPHONGTEN as KHOA_PHONG, lh.SHKHMASO as MA_LOP,lh.NOIDUNGHOC as TEN_LOP, dt.SOTIETHOC as SO_TIET_HOC, dt.SOTIETNGHI as SO_TIET_NGHI,dt.GOICHUYENGIAOKT as GOI_KT, cndt.CNDTTEN AS LOAI_CHUNG_NHAN, dt.GHICHU as GHI_CHU from HSOFTDKBD.DT_DSHOCVIENSHKH dt inner join HSOFTDKBD.DT_HOCVIEN hv on dt.IDHOCVIEN = hv.HOCVIENID inner join HSOFTDKBD.DT_DSLOPSHKH lh on lh.DSLOPSHKHID = dt.IDLOPHOC left join HSOFTDKBD.DT_PHAI p on p.PHAITEN = hv.HOCVIENPHAI left join HSOFTDKBD.DT_CHUCDANH cd on cd.CHUCDANHID = hv.IDCHUCDANH left join HSOFTDKBD.DT_BENHVIEN dv on dv.DONVIID = hv.IDDONVI left join HSOFTDKBD.DT_KHOAPHONG kp on kp.KHOAPHONGID = hv.IDKHOAPHONG left join hsoftdkbd.DT_CNDAOTAO  cndt on cndt.CNDTID = dt.IDLOAICN  where lh.NAMLOPHOC >= {0} and lh.NAMLOPHOC <= {1} and + UPPER(lh.NOIDUNGHOC) LIKE UPPER('%{2}%') ORDER BY dt.IDHOCVIEN", tunam, dennam, tenlop);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchDSHVbyHV(int tunam, int dennam, string HV)
        {
            string query = string.Format("select dt.IDHOCVIEN  as MA_NVHV,  hv.HOCVIENHOTEN as HO_TEN_HV,p.PHAITEN as PHAI, hv.HOCVIENNAMSINH as NGAY_SINH,cd.CHUCDANHTEN as CHUC_DANH , dv.DONVITEN as DON_VI_CONG_TAC,kp.KHOAPHONGTEN as KHOA_PHONG, lh.SHKHMASO as MA_LOP,lh.NOIDUNGHOC as TEN_LOP, dt.SOTIETHOC as SO_TIET_HOC, dt.SOTIETNGHI as SO_TIET_NGHI,dt.GOICHUYENGIAOKT as GOI_KT, cndt.CNDTTEN AS LOAI_CHUNG_NHAN, dt.GHICHU as GHI_CHU from HSOFTDKBD.DT_DSHOCVIENSHKH dt inner join HSOFTDKBD.DT_HOCVIEN hv on dt.IDHOCVIEN = hv.HOCVIENID inner join HSOFTDKBD.DT_DSLOPSHKH lh on lh.DSLOPSHKHID = dt.IDLOPHOC left join HSOFTDKBD.DT_PHAI p on p.PHAITEN = hv.HOCVIENPHAI left join HSOFTDKBD.DT_CHUCDANH cd on cd.CHUCDANHID = hv.IDCHUCDANH left join HSOFTDKBD.DT_BENHVIEN dv on dv.DONVIID = hv.IDDONVI left join HSOFTDKBD.DT_KHOAPHONG kp on kp.KHOAPHONGID = hv.IDKHOAPHONG left join hsoftdkbd.DT_CNDAOTAO  cndt on cndt.CNDTID = dt.IDLOAICN  where lh.NAMLOPHOC >= {0} and lh.NAMLOPHOC <= {1} and + UPPER(hv.HOCVIENHOTEN) LIKE UPPER('%{2}%') ORDER BY dt.IDHOCVIEN", tunam, dennam, HV);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchDSHVbyIDMaLop(int malop)
        {
            string query = string.Format("select dt.IDHOCVIEN  as MA_NVHV,  hv.HOCVIENHOTEN as HO_TEN_HV,p.PHAITEN as PHAI, hv.HOCVIENNAMSINH as NGAY_SINH,cd.CHUCDANHTEN as CHUC_DANH , dv.DONVITEN as DON_VI_CONG_TAC,kp.KHOAPHONGTEN as KHOA_PHONG, lh.SHKHMASO as MA_LOP,lh.NOIDUNGHOC as TEN_LOP, dt.SOTIETHOC as SO_TIET_HOC, dt.SOTIETNGHI as SO_TIET_NGHI,dt.GOICHUYENGIAOKT as GOI_KT, cndt.CNDTTEN AS LOAI_CHUNG_NHAN, dt.GHICHU as GHI_CHU from HSOFTDKBD.DT_DSHOCVIENSHKH dt inner join HSOFTDKBD.DT_HOCVIEN hv on dt.IDHOCVIEN = hv.HOCVIENID inner join HSOFTDKBD.DT_DSLOPSHKH lh on lh.DSLOPSHKHID = dt.IDLOPHOC left join HSOFTDKBD.DT_PHAI p on p.PHAITEN = hv.HOCVIENPHAI left join HSOFTDKBD.DT_CHUCDANH cd on cd.CHUCDANHID = hv.IDCHUCDANH left join HSOFTDKBD.DT_BENHVIEN dv on dv.DONVIID = hv.IDDONVI left join HSOFTDKBD.DT_KHOAPHONG kp on kp.KHOAPHONGID = hv.IDKHOAPHONG left join hsoftdkbd.DT_CNDAOTAO  cndt on cndt.CNDTID = dt.IDLOAICN  where lh.DSLOPSHKHID= {0} ORDER BY dt.IDHOCVIEN", malop);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int Count_DTSHKH()
        {
            string query = string.Format("select COUNT(HVSHKHID) from HSOFTDKBD.DT_DSHOCVIENSHKH");
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }

        public int count_HV_by_IDHV_IDLOP(int IDHOCVIEN, int IDLOPHOC)
        {
            string query = string.Format("select count(IDHOCVIEN) from HSOFTDKBD.DT_DSHOCVIENSHKH where IDHOCVIEN = {0} and IDLOPHOC = {1}", IDHOCVIEN, IDLOPHOC);
            int data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return data;
        }


        public bool InsertHVTL(int IDHOCVIEN, int IDLOPHOC, int SOTIETHOC, int SOTIETNGHI, string GOICHUYENGIAOKT, int IDLOAICN, string GHICHU)
        {
            int result = 0;
            string query = "";
            if (Count_DTSHKH() == 0)
            {

                query = string.Format("insert into HSOFTDKBD.DT_DSHOCVIENSHKH (HVSHKHID,IDHOCVIEN,IDLOPHOC,SOTIETHOC,SOTIETNGHI,GOICHUYENGIAOKT,IDLOAICN, GHICHU, upd) values (1,{0},{1},{2},{3},'{4}',{5},'{6}', sysdate)", IDHOCVIEN, IDLOPHOC, SOTIETHOC, SOTIETNGHI, GOICHUYENGIAOKT, IDLOAICN, GHICHU);
                result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            else
            {
                query = string.Format("insert into HSOFTDKBD.DT_DSHOCVIENSHKH (HVSHKHID,IDHOCVIEN,IDLOPHOC,SOTIETHOC,SOTIETNGHI,GOICHUYENGIAOKT,IDLOAICN, GHICHU, upd) values ((select MAX(HVSHKHID) + 1 from HSOFTDKBD.DT_DSHOCVIENSHKH),{0},{1},{2},{3},'{4}',{5},'{6}', sysdate)", IDHOCVIEN, IDLOPHOC, SOTIETHOC, SOTIETNGHI, GOICHUYENGIAOKT, IDLOAICN, GHICHU);
                result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
        }

        public bool UpdateHVTL(int IDHOCVIEN, int IDLOPHOC, int SOTIETHOC, int SOTIETNGHI, string GOICHUYENGIAOKT, int IDLOAICN, string GHICHU, int DTSHKHID)
        {
            string query = string.Format("UPDATE HSOFTDKBD.DT_DSHOCVIENSHKH SET IDHOCVIEN = {0}, IDLOPHOC ={1},SOTIETHOC = {2}, SOTIETNGHI = {3}, GOICHUYENGIAOKT ='{4}', IDLOAICN ={5},  GHICHU = '{6}', upd = sysdate where  HVSHKHID  = {7}", IDHOCVIEN, IDLOPHOC, SOTIETHOC, SOTIETNGHI, GOICHUYENGIAOKT, IDLOAICN, GHICHU, DTSHKHID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteHVTL(int HVSHKHID)
        {
            string query = string.Format("Delete HSOFTDKBD.DT_DSHOCVIENSHKH where HVSHKHID = {0}", HVSHKHID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public string get_HVDTTLID_By_IDHV_IDLOP(int IDHOCVIEN, int IDLOPHOC)
        {
            string query = string.Format("select HVSHKHID from HSOFTDKBD.DT_DSHOCVIENSHKH where IDHOCVIEN = {0} and IDLOPHOC = {1}", IDHOCVIEN, IDLOPHOC);
            string data = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query)).ToString();
            return data;
        }

    }
}

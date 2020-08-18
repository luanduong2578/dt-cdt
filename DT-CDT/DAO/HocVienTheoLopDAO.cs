using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DAO
{
    class HocVienTheoLopDAO
    {
private static HocVienTheoLopDAO instance;

        public static HocVienTheoLopDAO Instance
        {
            get {if(instance == null) instance = new HocVienTheoLopDAO(); return HocVienTheoLopDAO.instance; }
            private set { HocVienTheoLopDAO.instance = value; }
        }
        private HocVienTheoLopDAO() { }

        public string LoadNamHienTai()
        {
            DateTime now = DateTime.Now;
            return (now.Year).ToString();
        }


        public DataTable LoadDSLop(int NamLH)
        {
            string query = string.Format("select dt.DTid  as [MA],lh.LoaiDT as [Loại ĐT], lh.NoiDungHoc as [Tên lớp], hv.HocVienHoten as [Tên HV],p.PhaiTen as [Phái], hv.HocVienNamSinh as [Năm sinh],cd.ChucDanhTen as [Chức danh] , dv.DonViTen as [Đơn vị công tác], kp.KhoaPhongTen as [Khoa phòng],lh.ThoiGianHoc as [Tổng tiết học], dt.SoTietHoc as [Số tiết học], dt.SoTietNghi as [Số tiết nghỉ],dt.ChuyenGiaoKT as [Theo gói đt],dt.Ghichu as [Ghi chú] from DSDaoTaoSinhHoatKhoaHoc dt inner join HocVien hv on dt.mahv = hv.HocVienid inner join LopHoc lh on lh.LopHocid = dt.MaLop left join Phai p on p.Phaiid = hv.HocVienPhai left join ChucDanh cd on cd.ChucDanhid = hv.IdChucDanh left join DonVi dv on dv.DonViid = hv.IdDonVi left join KhoaPhong kp on kp.KhoaPhongid = hv.IdKhoaPhong  where lh.NamLopHoc  ={0}", NamLH);
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public DataTable SearchDSHVbyTuNamDenNam(int tunam, int dennam)
        {
            string query = string.Format("select dt.DTid  as [MA],lh.LoaiDT as [Loại ĐT], lh.NoiDungHoc as [Tên lớp], hv.HocVienHoten as [Tên HV],p.PhaiTen as [Phái], hv.HocVienNamSinh as [Năm sinh],cd.ChucDanhTen as [Chức danh] , dv.DonViTen as [Đơn vị công tác], kp.KhoaPhongTen as [Khoa phòng],lh.ThoiGianHoc as [Tổng tiết học], dt.SoTietHoc as [Số tiết học], dt.SoTietNghi as [Số tiết nghỉ],dt.ChuyenGiaoKT as [Theo gói đt],dt.Ghichu as [Ghi chú] from DSDaoTaoSinhHoatKhoaHoc dt inner join HocVien hv on dt.mahv = hv.HocVienid inner join LopHoc lh on lh.LopHocid = dt.MaLop left join Phai p on p.Phaiid = hv.HocVienPhai left join ChucDanh cd on cd.ChucDanhid = hv.IdChucDanh left join DonVi dv on dv.DonViid = hv.IdDonVi left join KhoaPhong kp on kp.KhoaPhongid = hv.IdKhoaPhong where lh.NamLopHoc >= {0} and lh.NamLopHoc <= {1}", tunam, dennam);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchDSHVbyTenLop(int tunam, int dennam, string tenlop)
        {
            string query = string.Format("select dt.DTid  as [MA],lh.LoaiDT as [Loại ĐT], lh.NoiDungHoc as [Tên lớp], hv.HocVienHoten as [Tên HV],p.PhaiTen as [Phái], hv.HocVienNamSinh as [Năm sinh],cd.ChucDanhTen as [Chức danh] , dv.DonViTen as [Đơn vị công tác], kp.KhoaPhongTen as [Khoa phòng],lh.ThoiGianHoc as [Tổng tiết học], dt.SoTietHoc as [Số tiết học], dt.SoTietNghi as [Số tiết nghỉ],dt.ChuyenGiaoKT as [Theo gói đt],dt.Ghichu as [Ghi chú] from DSDaoTaoSinhHoatKhoaHoc dt inner join HocVien hv on dt.mahv = hv.HocVienid inner join LopHoc lh on lh.LopHocid = dt.MaLop left join Phai p on p.Phaiid = hv.HocVienPhai left join ChucDanh cd on cd.ChucDanhid = hv.IdChucDanh left join DonVi dv on dv.DonViid = hv.IdDonVi left join KhoaPhong kp on kp.KhoaPhongid = hv.IdKhoaPhong where lh.NamLopHoc >= {0} and lh.NamLopHoc <= {1} and + dbo.fuConvertToUnsign1(lh.NoiDungHoc) LIKE N'%' + dbo.fuConvertToUnsign1(N'{2}') + '%'", tunam, dennam, tenlop);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchDSHVbyHV(int tunam, int dennam, string HV)
        {
            string query = string.Format("select dt.DTid  as [MA],lh.LoaiDT as [Loại ĐT], lh.NoiDungHoc as [Tên lớp], hv.HocVienHoten as [Tên HV],p.PhaiTen as [Phái], hv.HocVienNamSinh as [Năm sinh],cd.ChucDanhTen as [Chức danh] , dv.DonViTen as [Đơn vị công tác], kp.KhoaPhongTen as [Khoa phòng],lh.ThoiGianHoc as [Tổng tiết học], dt.SoTietHoc as [Số tiết học], dt.SoTietNghi as [Số tiết nghỉ],dt.ChuyenGiaoKT as [Theo gói đt],dt.Ghichu as [Ghi chú] from DSDaoTaoSinhHoatKhoaHoc dt inner join HocVien hv on dt.mahv = hv.HocVienid inner join LopHoc lh on lh.LopHocid = dt.MaLop left join Phai p on p.Phaiid = hv.HocVienPhai left join ChucDanh cd on cd.ChucDanhid = hv.IdChucDanh left join DonVi dv on dv.DonViid = hv.IdDonVi left join KhoaPhong kp on kp.KhoaPhongid = hv.IdKhoaPhong where lh.NamLopHoc >= {0} and lh.NamLopHoc <= {1} and + dbo.fuConvertToUnsign1(hv.HocVienHoten) LIKE N'%' + dbo.fuConvertToUnsign1(N'{2}') + '%'", tunam, dennam, HV);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchDSHVbyIDMaLop(int malop)
        {
            string query = string.Format("select dt.DTid  as [MA],lh.LoaiDT as [Loại ĐT], lh.NoiDungHoc as [Tên lớp], hv.HocVienHoten as [Tên HV],p.PhaiTen as [Phái], hv.HocVienNamSinh as [Năm sinh],cd.ChucDanhTen as [Chức danh] , dv.DonViTen as [Đơn vị công tác], kp.KhoaPhongTen as [Khoa phòng],lh.ThoiGianHoc as [Tổng tiết học], dt.SoTietHoc as [Số tiết học], dt.SoTietNghi as [Số tiết nghỉ],dt.ChuyenGiaoKT as [Theo gói đt],dt.Ghichu as [Ghi chú] from DSDaoTaoSinhHoatKhoaHoc dt inner join HocVien hv on dt.mahv = hv.HocVienid inner join LopHoc lh on lh.LopHocid = dt.MaLop left join Phai p on p.Phaiid = hv.HocVienPhai left join ChucDanh cd on cd.ChucDanhid = hv.IdChucDanh left join DonVi dv on dv.DonViid = hv.IdDonVi left join KhoaPhong kp on kp.KhoaPhongid = hv.IdKhoaPhong where lh.LopHocid= {0}", malop);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertHVTL(int MaHV, int MaLop, int SoTietHoc, int SoTietNghi, string ChuyenGiaoKT, string Ghichu)
        {
            string query = string.Format("insert into DSDaoTaoSinhHoatKhoaHoc (MaHV, MaLop ,SoTietHoc, SoTietNghi, ChuyenGiaoKT,  Ghichu) values ({0}, {1}, {2}, {3}, N'{4}',N'{5}')", MaHV, MaLop, SoTietHoc, SoTietNghi, ChuyenGiaoKT, Ghichu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateHVTL(int MaHV, int MaLop, int SoTietHoc, int SoTietNghi, string ChuyenGiaoKT, string Ghichu, int DTid)
        {
            string query = string.Format("UPDATE DSDaoTaoSinhHoatKhoaHoc SET MaHV = {0}, MaLop ={1},SoTietHoc = {2}, SoTietNghi = {3}, ChuyenGiaoKT =N'{4}',  Ghichu = N'{5}' where  DTid  = {6}", MaHV, MaLop, SoTietHoc, SoTietNghi, ChuyenGiaoKT, Ghichu, DTid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteHVTL(int DTid)
        {
            string query = string.Format("Delete DSDaoTaoSinhHoatKhoaHoc where DTid = {0}", DTid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

using DT_CDT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DT_CDT
{
    public partial class fDSHocChuyenKhoa : Form
    {

        public fDSHocChuyenKhoa()
        {
            InitializeComponent();
            LoadHCKData();
            LoadButton();
            loadHCKTuNam();
            loadHCKDenNam();
            loadHCKNAMDT();
            loadKPAndDV(cbbKPDT);
            LoadTinhTrangDaoTao();
            LoadChungNhanDaoTao();
            LoadNamHCK(cbbSearchTuNam);
            LoadNamHCK(cbbSearchDenNam);
            LoadNamHCK(cbbHCKNam);
            loadHVandKPanDVCT();
            Load_Goi_CGKT();
        }

        void loadKPAndDV(ComboBox cbb)
        {
            cbb.DataSource = KhoaPhongDAO.Instance.loadKPandKPanBV();
            cbb.ValueMember = "KhoaPhongid";
            cbb.DisplayMember = "KHOA_PHONG_DAO_TAO";
        }

        void Load_Goi_CGKT()
        {
            cbbGoiKyThuat.DataSource = CGKTLLDAO.Instance.LoadListCGKT();
            cbbGoiKyThuat.ValueMember = "CGKTID";
            cbbGoiKyThuat.DisplayMember = "CGKTTENGOI";
        }

        void LoadButton()
        {
            cbbHCKNam.Enabled = false;
            cbbHCKHV.Enabled = false;
            txbHCKPhai.Enabled = false;
            txbHCKNgaySinh.Enabled = false;
            txbChucDanh.Enabled = false;
            txbHCKDVCT.Enabled = false;
            txbHCKKhoaPhong.Enabled = false;
            cbbKPDT.Enabled = false;
            txbHCKNoiDungDT.Enabled = false;
            cbbHCKTinhTrangDT.Enabled = false;
            txbHCKKinhPhi.Enabled = false;
            txbHCKThoiGianHoc.Enabled = false;
            mktxbHCKBatDau.Enabled = false;
            mktxbHCKKetThuc.Enabled = false;
            txbHCKKetQuaTB.Enabled = false;
            txbKetQuaLT.Enabled = false;
            txbKetQuaTH.Enabled = false;
            cbbChungNhanDT.Enabled = false;
            txbHCKGhichu.Enabled = false;
            cbbLoaiKinhPhi.Enabled = false;
            txbTongSoTiet.Enabled = false;
            txbSoTietHoc.Enabled = false;
            txbSoTietNghi.Enabled = false;
            cbbHinhThucHoc.Enabled = false;
            txbSoChungNhan.Enabled = false;
            cbbGoiKyThuat.Enabled = false;
            btnBVMoi.Enabled = true;
            btnBVLuu.Enabled = false;
            btnBVSua.Enabled = true;
            btnBVXoa.Enabled = true;
            btnBVBoQua.Enabled = false;
            btnBVKetthuc.Enabled = true;
        }

        void moiButton()
        {
            cbbHCKNam.Enabled = true;
            cbbHCKHV.Enabled = true;
            txbHCKPhai.Enabled = false;
            txbHCKNgaySinh.Enabled = false;
            txbChucDanh.Enabled = false;
            txbHCKDVCT.Enabled = false;
            txbHCKKhoaPhong.Enabled = false;
            cbbKPDT.Enabled = true;
            txbHCKNoiDungDT.Enabled = true;
            cbbHCKTinhTrangDT.Enabled = true;
            txbHCKKinhPhi.Enabled = true;
            txbHCKThoiGianHoc.Enabled = true;
            mktxbHCKBatDau.Enabled = true;
            mktxbHCKKetThuc.Enabled = true;
            txbHCKKetQuaTB.Enabled = true;
            txbKetQuaLT.Enabled = true;
            txbKetQuaTH.Enabled = true;
            cbbChungNhanDT.Enabled = true;
            txbHCKGhichu.Enabled = true;
            cbbLoaiKinhPhi.Enabled = true;
            txbTongSoTiet.Enabled = true;
            txbSoTietHoc.Enabled = true;
            txbSoTietNghi.Enabled = true;
            cbbHinhThucHoc.Enabled = true;
            txbSoChungNhan.Enabled = false;
            cbbGoiKyThuat.Enabled = true;
            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVXoa.Enabled = false;
            btnBVBoQua.Enabled = true;
            btnBVKetthuc.Enabled = false;
            txbHCKid.Text = "";
            LoadNamHCK(cbbHCKNam);
            cbbHCKHV.Text = "";
            cbbKPDT.Text = "";
            cbbKPDT.Text = "";
            txbHCKNoiDungDT.Text = "";
            txbHCKKinhPhi.Text = "";
            txbHCKThoiGianHoc.Text = "";
            txbHCKKetQuaTB.Text = "";
            txbKetQuaLT.Text = "";
            txbKetQuaTH.Text = "";
            txbHCKGhichu.Text = "";
            cbbLoaiKinhPhi.Text = "";
            txbTongSoTiet.Text = "";
            txbSoTietHoc.Text = "";
            txbSoTietNghi.Text = "";
            cbbHinhThucHoc.Text = "";
            txbSoChungNhan.Text = "";
            cbbGoiKyThuat.Text = "";

        }
        void suaButton()
        {
            cbbHCKNam.Enabled = true;
            cbbHCKHV.Enabled = true;
            txbHCKPhai.Enabled = false;
            txbHCKNgaySinh.Enabled = false;
            txbChucDanh.Enabled = false;
            txbHCKDVCT.Enabled = false;
            txbHCKKhoaPhong.Enabled = false;
            cbbKPDT.Enabled = true;
            txbHCKNoiDungDT.Enabled = true;
            cbbHCKTinhTrangDT.Enabled = true;
            txbHCKKinhPhi.Enabled = true;
            txbHCKThoiGianHoc.Enabled = true;
            mktxbHCKBatDau.Enabled = true;
            mktxbHCKKetThuc.Enabled = true;
            txbHCKKetQuaTB.Enabled = true;
            txbKetQuaLT.Enabled = true;
            txbKetQuaTH.Enabled = true;
            cbbChungNhanDT.Enabled = true;
            txbHCKGhichu.Enabled = true;
            cbbLoaiKinhPhi.Enabled = true;
            txbTongSoTiet.Enabled = true;
            txbSoTietHoc.Enabled = true;
            txbSoTietNghi.Enabled = true;
            cbbHinhThucHoc.Enabled = true;
            txbSoChungNhan.Enabled = false;
            cbbGoiKyThuat.Enabled = true;
            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVXoa.Enabled = false;
            btnBVBoQua.Enabled = true;
            btnBVKetthuc.Enabled = false;
        }

        void LoadChungNhanDaoTao()
        {
            cbbChungNhanDT.DataSource = LoaiCNDTDAO.Instance.LoadListCNDAOTAO();
            cbbChungNhanDT.ValueMember = "CNDTID";
            cbbChungNhanDT.DisplayMember = "CNDTTEN";
        }

        void LoadTinhTrangDaoTao()
        {
            cbbHCKTinhTrangDT.DataSource = TinhTrangDaoTaoDAO.Instance.LoadListTinhTrangDaoTao();
            cbbHCKTinhTrangDT.ValueMember = "TTDTID";
            cbbHCKTinhTrangDT.DisplayMember = "TTDTTEN";
        }

        void loadHVandKPanDVCT()
        {
            cbbHCKHV.DataSource = HocVienDAO.Instance.LoadListHVbyID();
            cbbHCKHV.ValueMember = "HOCVIENID";
            cbbHCKHV.DisplayMember = "HOC_VIEN";
        }

        void LoadHCKData()
        {

            int namHienTai = Convert.ToInt32(HocChuyenKhoaDAO.Instance.LoadNamHienTai());
            dtgvHCK.DataSource = HocChuyenKhoaDAO.Instance.LoadHCK(namHienTai);
        }

        void LoadNamHCK(ComboBox cbb)
        {
            cbb.Text = HocChuyenKhoaDAO.Instance.LoadNamHienTai();
        }

        void loadHCKTuNam()
        {
            cbbSearchTuNam.DataSource = NamNCDAO.Instance.LoadListNamNC();
            cbbSearchTuNam.ValueMember = "NAMID";
            cbbSearchTuNam.DisplayMember = "NAMTEN";
        }

        void loadHCKDenNam()
        {
            cbbSearchDenNam.DataSource = NamNCDAO.Instance.LoadListNamNC();
            cbbSearchDenNam.ValueMember = "NAMID";
            cbbSearchDenNam.DisplayMember = "NAMTEN";
        }

        void loadHCKNAMDT()
        {
            cbbHCKNam.DataSource = NamNCDAO.Instance.LoadListNamNC();
            cbbHCKNam.ValueMember = "NAMID";
            cbbHCKNam.DisplayMember = "NAMTEN";
        }

        private void btnBVKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHCKTim_Click(object sender, EventArgs e)
        {
            dtgvHCK.DataSource = HocChuyenKhoaDAO.Instance.SearchHCKbyTuNamDenNam(Convert.ToInt32(cbbSearchTuNam.Text), Convert.ToInt32(cbbSearchDenNam.Text));
        }

        private void txbSearchND_TextChanged(object sender, EventArgs e)
        {
            dtgvHCK.DataSource = HocChuyenKhoaDAO.Instance.SearchHCKbyNoiDungDT(Convert.ToInt32(cbbSearchTuNam.Text), Convert.ToInt32(cbbSearchDenNam.Text), txbSearchND.Text);

        }

        private void txbSearchHV_TextChanged(object sender, EventArgs e)
        {
            dtgvHCK.DataSource = HocChuyenKhoaDAO.Instance.SearchHCKbyTenHV(Convert.ToInt32(cbbSearchTuNam.Text), Convert.ToInt32(cbbSearchDenNam.Text), txbSearchHV.Text);
        }

        private void dtgvHCK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnBVMoi.Enabled == false)
            {
                cbbHCKHV.Focus();
            }
            else
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = this.dtgvHCK.Rows[e.RowIndex];
                        txbMaHCK.Text = row.Cells[0].Value.ToString();
                        cbbHCKNam.Text = row.Cells[1].Value.ToString();
                        cbbHCKHV.Text = row.Cells[2].Value.ToString();
                        txbHCKPhai.Text = row.Cells[3].Value.ToString();
                        txbHCKNgaySinh.Text = row.Cells[4].Value.ToString();
                        txbChucDanh.Text = row.Cells[5].Value.ToString();
                        txbHCKDVCT.Text = row.Cells[6].Value.ToString();
                        txbHCKKhoaPhong.Text = row.Cells[7].Value.ToString();
                        cbbKPDT.Text = row.Cells[8].Value.ToString();
                        txbHCKNoiDungDT.Text = row.Cells[9].Value.ToString();
                        cbbHCKTinhTrangDT.Text = row.Cells[10].Value.ToString();
                        cbbLoaiKinhPhi.Text = row.Cells[11].Value.ToString();
                        txbHCKKinhPhi.Text = row.Cells[12].Value.ToString();
                        txbHCKThoiGianHoc.Text = row.Cells[13].Value.ToString();
                        txbTongSoTiet.Text = row.Cells[14].Value.ToString();
                        mktxbHCKBatDau.Value = Convert.ToDateTime(row.Cells[15].Value);
                        mktxbHCKKetThuc.Value = Convert.ToDateTime(row.Cells[16].Value);
                        txbSoTietHoc.Text = row.Cells[17].Value.ToString();
                        txbSoTietNghi.Text = row.Cells[18].Value.ToString();
                        txbHCKKetQuaTB.Text = row.Cells[19].Value.ToString();
                        txbKetQuaLT.Text = row.Cells[20].Value.ToString();
                        txbKetQuaTH.Text = row.Cells[21].Value.ToString();
                        cbbHinhThucHoc.Text = row.Cells[22].Value.ToString();
                        cbbChungNhanDT.Text = row.Cells[23].Value.ToString();
                        txbSoChungNhan.Text = row.Cells[24].Value.ToString();
                        cbbGoiKyThuat.Text = row.Cells[25].Value.ToString();
                        txbHCKGhichu.Text = row.Cells[26].Value.ToString();
                        txbHCKid.Text = HocChuyenKhoaDAO.Instance.GetHCKIdByMAHCK(txbMaHCK.Text).ToString();
                        txbSoChungNhan.Text = HocChuyenKhoaDAO.Instance.GetSOCN_By_CCMASO_from_CCN(txbMaHCK.Text);
                    }
                }
                catch (Exception ae)
                {
                    MessageBox.Show(ae.ToString());
                }
            }


        }

        private void btnBVMoi_Click(object sender, EventArgs e)
        {
            moiButton();


        }

        private void btnBVSua_Click(object sender, EventArgs e)
        {
            suaButton();
        }

        private void btnBVBoQua_Click(object sender, EventArgs e)
        {
            LoadHCKData();
            LoadButton();
            btnBVMoi.Focus();
        }

        private void txbHCKThoiGianHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbHCKKinhPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnBVLuu_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbbHCKHV.SelectedValue) == 0)
            {
                cbbHCKHV.Focus();
            }
            else if (Convert.ToInt32(cbbKPDT.SelectedValue) == 0)
            {
                cbbKPDT.Focus();
            }
            else if (txbHCKNoiDungDT.Text == "")
            {
                txbHCKNoiDungDT.Focus();
            }
            else if (txbHCKThoiGianHoc.Text == "")
            {
                txbHCKThoiGianHoc.Focus();
            }
            else if(mktxbHCKBatDau.Value>mktxbHCKKetThuc.Value)
            {
                mktxbHCKKetThuc.Focus();
            }
            else
            {
                int HCKNam = Convert.ToInt32(cbbHCKNam.Text);
                int HCKHocVien = Convert.ToInt32(cbbHCKHV.SelectedValue);
                int KPDaoTao = Convert.ToInt32(cbbKPDT.SelectedValue);
                string HCKNoiDungDaoTao = DataProvider.Instance.FormatStringInput(txbHCKNoiDungDT.Text);
                int HCKThoiGianDaoTao = Convert.ToInt32(DataProvider.Instance.FormatStringInput(txbHCKThoiGianHoc.Text));
                string HCKThoiGianBatDau = mktxbHCKBatDau.Text;
                string HCKThoiGianKetThuc = mktxbHCKKetThuc.Text;
                string HCKKinhPhi = DataProvider.Instance.FormatStringInput(txbHCKKinhPhi.Text);
                string HCKKetQuaTB = DataProvider.Instance.FormatStringInput(txbHCKKetQuaTB.Text);
                string HCKKetQuaLT = DataProvider.Instance.FormatStringInput(txbKetQuaLT.Text);
                string HCKKetQuaTH = DataProvider.Instance.FormatStringInput(txbKetQuaTH.Text);
                int HCKChungNhan = Convert.ToInt32(cbbChungNhanDT.SelectedValue);
                int HCKTinhTrangDT = Convert.ToInt32(cbbHCKTinhTrangDT.SelectedValue);
                string GhiChu = DataProvider.Instance.FormatStringInput(txbHCKGhichu.Text);
                string HocVien = DataProvider.Instance.FormatStringInput(cbbHCKHV.Text);
                string HCKHinhThucHoc = DataProvider.Instance.FormatStringInput(cbbHinhThucHoc.Text);
                string HCKGoiKT = DataProvider.Instance.FormatStringInput(cbbGoiKyThuat.Text);
                string HCKLoaiKinhPhi = DataProvider.Instance.FormatStringInput(cbbLoaiKinhPhi.Text);
                string HCKTongSoTiet = DataProvider.Instance.FormatStringInput(txbTongSoTiet.Text);
                string HCKSoChungNhan = DataProvider.Instance.FormatStringInput(txbSoChungNhan.Text);
                string HCKSoTietHoc = DataProvider.Instance.FormatStringInput(txbSoTietHoc.Text);
                string HCKSoTietNghi = DataProvider.Instance.FormatStringInput(txbSoTietNghi.Text);
                string HCKMAHCK = DataProvider.Instance.FormatStringInput(txbMaHCK.Text);
                bool insertid = false;
                int IDHOCVIEN = HCKHocVien;
                int IDKHOAPHONG = KPDaoTao;

                int IDHCK = 0;
                if (txbHCKid.Text == "")
                {
                    HocChuyenKhoaDAO.Instance.InsertHCK(HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien, HCKHinhThucHoc, HCKGoiKT, HCKLoaiKinhPhi, HCKTongSoTiet, HCKSoChungNhan, HCKSoTietHoc, HCKSoTietNghi);

                    insertid = HocChuyenKhoaDAO.Instance.InsertHCK(HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien, HCKHinhThucHoc, HCKGoiKT, HCKLoaiKinhPhi, HCKTongSoTiet, HCKSoChungNhan, HCKSoTietHoc, HCKSoTietNghi);
                    if (insertid)
                    {
                        IDHCK = HocChuyenKhoaDAO.Instance.MAX_IDHCK();
                }
                    LoadButton();
                    LoadHCKData();
                    btnBVMoi.Focus();
                }
                else
                {
                    HocChuyenKhoaDAO.Instance.UpdateHCK(HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien, Convert.ToInt32(txbHCKid.Text), HCKHinhThucHoc, HCKGoiKT, HCKLoaiKinhPhi, HCKTongSoTiet, HCKSoChungNhan, HCKSoTietHoc, HCKSoTietNghi, HCKMAHCK);

                    insertid = HocChuyenKhoaDAO.Instance.UpdateHCK(HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien, Convert.ToInt32(txbHCKid.Text), HCKHinhThucHoc, HCKGoiKT, HCKLoaiKinhPhi, HCKTongSoTiet, HCKSoChungNhan, HCKSoTietHoc, HCKSoTietNghi, HCKMAHCK);
                    IDHCK = Convert.ToInt32(txbHCKid.Text);
                    LoadButton();
                    LoadHCKData();
                    btnBVMoi.Focus();
                }
                // cap nhat cham cong

                int MMYYBD = Convert.ToInt32(HCKThoiGianBatDau.Substring(8, 2) + HCKThoiGianBatDau.Substring(3, 2));
                int MMYYKT = Convert.ToInt32(HCKThoiGianKetThuc.Substring(8, 2) + HCKThoiGianKetThuc.Substring(3, 2));
                string MM = HCKThoiGianBatDau.Substring(3, 2);
                string YY = HCKThoiGianBatDau.Substring(8, 2);
                if (IDHCK > 0)
                {
                    ChamCongHCKDAO.Instance.UpdateChamCongHV_TINHTRANG(IDHCK);
                    insert_update_ChamCong(MM + YY, IDHOCVIEN, IDHCK, IDKHOAPHONG, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKTinhTrangDT);

                    while (MMYYKT > MMYYBD)
                    {
                        MM = (Convert.ToInt32(MM) + 1).ToString();
                        if (Convert.ToInt32(MM) < 10)
                        {
                            MM = "0" + MM;
                        }
                        if (MM == "13")
                        {
                            MM = "01";
                            YY = (Convert.ToInt32(YY) + 1).ToString();
                        }
                        insert_update_ChamCong(MM + YY, IDHOCVIEN, IDHCK, IDKHOAPHONG, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKTinhTrangDT);
                        MMYYBD = Convert.ToInt32(YY + MM);
                    }
                }
            
        }
    }
        public void insert_update_ChamCong(string MMYY, int IDHOCVIEN, int IDHCK, int IDKHOAPHONG, string HCKTHOIGIANBATDAU, string HCKTHOIGIANKETTHUC, int TINHTRANG)
        {
            if (ChamCongHCKDAO.Instance.Kiemtra_IDHCK_MMYY(IDHCK, MMYY))
            {

                ChamCongHCKDAO.Instance.UpdateChamCongHV(MMYY, IDHOCVIEN, IDHCK, IDKHOAPHONG, HCKTHOIGIANBATDAU, HCKTHOIGIANKETTHUC, TINHTRANG);
            }
            else
            {

                ChamCongHCKDAO.Instance.InsertChamCongHV(MMYY, IDHOCVIEN, IDHCK, IDKHOAPHONG, HCKTHOIGIANBATDAU, HCKTHOIGIANKETTHUC, TINHTRANG);
            }
        }


        private void btnBVXoa_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(txbHCKid.Text, out id))
            {
                DialogResult drXoa = MessageBox.Show("Xóa học viên: " + cbbHCKHV.Text + " - " + txbHCKKhoaPhong.Text + " - " + txbHCKDVCT.Text + " - Lớp: " + txbHCKNoiDungDT.Text, "Cảnh báo", MessageBoxButtons.YesNo);
                if (drXoa == DialogResult.Yes)
                {
                    HocChuyenKhoaDAO.Instance.DeleteHCK(Convert.ToInt32(txbHCKid.Text));
                    LoadButton();
                    LoadHCKData();
                    btnBVMoi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chọn học viên", "Cảnh báo");
            }
        }

        private void cbbHCKHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txbHCKPhai.Text = HocVienDAO.Instance.GetPhaibyHocVienID(Convert.ToInt32(cbbHCKHV.SelectedValue));
                txbHCKNgaySinh.Text = HocVienDAO.Instance.GetNgaySinhbyHocVienID(Convert.ToInt32(cbbHCKHV.SelectedValue));
                txbChucDanh.Text = HocVienDAO.Instance.GetChucDanhbyHocVienID(Convert.ToInt32(cbbHCKHV.SelectedValue));
                txbHCKDVCT.Text = HocVienDAO.Instance.GetDVCTbyHocVienID(Convert.ToInt32(cbbHCKHV.SelectedValue));
                txbHCKKhoaPhong.Text = HocVienDAO.Instance.GetKhoaPhongbyHocVienID(Convert.ToInt32(cbbHCKHV.SelectedValue));
            }
            catch (Exception ex)
            {
               ex.ToString();
            }
        }
    }

} 



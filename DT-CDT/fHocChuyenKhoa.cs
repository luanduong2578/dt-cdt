﻿using DT_CDT.DAO;
using DT_CDT.DTO;
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
    public partial class fHocChuyenKhoa : Form
    {
       
        public fHocChuyenKhoa()
        {
            InitializeComponent();
            LoadHCKData();
            LoadHCK();
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
        }
             
        void loadKPAndDV(ComboBox cbb)
        {
            cbb.DataSource = KhoaPhongDAO.Instance.loadKPandKPanBV();
            cbb.ValueMember = "KhoaPhongid";
            cbb.DisplayMember = "KHOA_PHONG_DAO_TAO";
        }

        void LoadHCK()
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
            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVXoa.Enabled = false;
            btnBVBoQua.Enabled = true;
            btnBVKetthuc.Enabled = false;
        }

        void LoadChungNhanDaoTao()
        {
            cbbChungNhanDT.DataSource = ChungNhanDaoTaoDAO.Instance.LoadListCNDAOTAO();
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
                        txbHCKid.Text = row.Cells[0].Value.ToString();
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
                        txbHCKKinhPhi.Text = row.Cells[11].Value.ToString();
                        txbHCKThoiGianHoc.Text = row.Cells[12].Value.ToString();
                        mktxbHCKBatDau.Value = Convert.ToDateTime(row.Cells[13].Value);
                        mktxbHCKKetThuc.Value = Convert.ToDateTime(row.Cells[14].Value);
                        txbHCKKetQuaTB.Text = row.Cells[15].Value.ToString();
                        txbKetQuaLT.Text = row.Cells[16].Value.ToString();
                        txbKetQuaTH.Text = row.Cells[17].Value.ToString();
                        cbbChungNhanDT.Text = row.Cells[18].Value.ToString();
                        txbHCKGhichu.Text = row.Cells[19].Value.ToString();
                    }
                }
                catch (Exception ae)
                {
                    string a = ae.ToString();
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
            LoadHCK();
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
                MessageBox.Show("Học viên không hợp lệ","Cảnh báo");
                cbbHCKHV.Focus();
            }
            else if (Convert.ToInt32(cbbKPDT.SelectedValue) == 0)
            {
                MessageBox.Show("Khoa phòng đào tạo không hợp lệ", "Cảnh báo");
                cbbKPDT.Focus();
            }
            else if(txbHCKNoiDungDT.Text =="")
            {
                MessageBox.Show("Nội dung đào tạo không được để trống");
                txbHCKNoiDungDT.Focus();
            }
            else if(txbHCKThoiGianHoc.Text == "")
            {
                MessageBox.Show("Thời gian đào tạo không được để trống");
                txbHCKThoiGianHoc.Focus();
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
                if (txbHCKid.Text == "")
                {
                    HocChuyenKhoaDAO.Instance.InsertHCK(HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien);
                    LoadHCK();
                    LoadHCKData();
                    btnBVMoi.Focus();
                }
                else
                {
                    HocChuyenKhoaDAO.Instance.UpdateHCK(HCKNam, HCKHocVien, KPDaoTao, HCKNoiDungDaoTao, HCKThoiGianDaoTao, HCKThoiGianBatDau, HCKThoiGianKetThuc, HCKKinhPhi, HCKKetQuaTB, HCKKetQuaLT, HCKKetQuaTH, HCKChungNhan, HCKTinhTrangDT, GhiChu, HocVien, Convert.ToInt32(txbHCKid.Text));
                    LoadHCK();
                    LoadHCKData();
                    btnBVMoi.Focus();
                }
            }
        }

        private void btnBVXoa_Click(object sender, EventArgs e)
        {
            DialogResult drXoa = MessageBox.Show("Xoa học viên: " + cbbHCKHV.Text +" - " + txbHCKKhoaPhong.Text + " - " + txbHCKDVCT.Text, "Cảnh báo", MessageBoxButtons.YesNo);
            if(drXoa == DialogResult.Yes)
            {
                HocChuyenKhoaDAO.Instance.DeleteHCK(Convert.ToInt32(txbHCKid.Text));
            }
            LoadHCK();
            LoadHCKData();
            btnBVMoi.Focus();            
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



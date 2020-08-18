using DT_CDT.DAO;
using DT_CDT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DT_CDT
{
    public partial class fLopHoc1 : Form
    {
        public fLopHoc1()
        {
            InitializeComponent();
            LoadLHtoDtgvLH();
            loadListNam(cbbLHNam);
            loadListNam(cbbSearchLHTuNam);
            loadListNam(cbbSearchLHDenNam);
            LoadNamHienTai(cbbLHNam);
            LoadNamHienTai(cbbSearchLHTuNam);
            LoadNamHienTai(cbbSearchLHDenNam);
            LoadButton();
            LoadDSBenhVienToCombobox();
            LoadDSKhoaPhongToCombobox();
            

        }
        void LoadDSKhoaPhongToCombobox()
        {
            List<KhoaPhong> ListKhoaPhong = KhoaPhongDAO.Instance.GetDSKhoaPhong();
            cbbKhoaPhong.DataSource = ListKhoaPhong;
            cbbKhoaPhong.DisplayMember = "KhoaPhongTen";
        }
        void LoadDSBenhVienToCombobox()
        {
            List<BenhVien> ListBenhVien = BenhVienDAO.Instance.GetDSBenhVien();
            cbbLHBV.DataSource = ListBenhVien;
            cbbLHBV.DisplayMember = "DonViTen";
        }
        void LoadButton()
        {
            txbLHid.Enabled = false;
            cbbLHNam.Enabled = false;
            cbbLoaiDT.Enabled = false;
            txbTenLop.Enabled = false;
            cbbLHBV.Enabled = false;
            cbbKhoaPhong.Enabled = false;
            txbLHGV.Enabled = false;
            txbLHDoiTuongHoc.Enabled = false;
            mktxbLHBatDau.Enabled = false;
            mktxbLHKetThuc.Enabled = false;
            txbLHSoTietHoc.Enabled = false;
            txbSoTietLT.Enabled = false;
            txbSoTietTH.Enabled = false;
            txbLHDiaDiem.Enabled = false;
            txbKinhPhi.Enabled = false;
            txbChiGV.Enabled = false;
            txbChiNuocUong.Enabled = false;
            txbChiKhac.Enabled = false;
            txbGhichu.Enabled = false;
            btnLHMoi.Enabled = true;
            btnLHLuu.Enabled = false;
            btnLHSua.Enabled = true;
            btnLHXoa.Enabled = true;
            btnLHBoQua.Enabled = false;
            btnLHKetthuc.Enabled = true;
        }
        void moiButton()
        {
            txbLHid.Enabled = false;
            cbbLHNam.Enabled = true;
            cbbLoaiDT.Enabled = true;
            txbTenLop.Enabled = true;
            cbbLHBV.Enabled = true;
            cbbKhoaPhong.Enabled = true;
            txbLHGV.Enabled = true;
            txbLHDoiTuongHoc.Enabled = true;
            mktxbLHBatDau.Enabled = true;
            mktxbLHKetThuc.Enabled = true;
            txbLHSoTietHoc.Enabled = true;
            txbSoTietLT.Enabled = true;
            txbSoTietTH.Enabled = true;
            txbLHDiaDiem.Enabled = true;
            txbKinhPhi.Enabled = true;
            txbChiGV.Enabled = true;
            txbChiNuocUong.Enabled = true;
            txbChiKhac.Enabled = true;
            txbGhichu.Enabled = true;

            txbLHid.Text = "";
            //   LoadNamHienTai(cbbLHNam);
            txbTenLop.Text = "";
            txbTenLop.Focus();
            cbbLHBV.Text = "";
            cbbKhoaPhong.Text = "";
            txbLHGV.Text = "";
            txbLHDoiTuongHoc.Text = "";
            mktxbLHBatDau.Value = DateTime.Today;
            mktxbLHKetThuc.Value = DateTime.Today;
            txbLHSoTietHoc.Text = "";
            txbSoTietLT.Text = "";
            txbSoTietTH.Text = "";
            txbLHDiaDiem.Text = "";
            txbKinhPhi.Text = "";
            txbChiGV.Text = "";
            txbChiNuocUong.Text = "";
            txbChiKhac.Text = "";
            txbGhichu.Text = "";
            btnLHMoi.Enabled = false;
            btnLHLuu.Enabled = true;
            btnLHSua.Enabled = false;
            btnLHXoa.Enabled = false;
            btnLHBoQua.Enabled = true;
            btnLHKetthuc.Enabled = false;
        }

        void suaButton()
        {
            txbLHid.Enabled = false;
            cbbLHNam.Enabled = true;
            cbbLoaiDT.Enabled = true;
            txbTenLop.Enabled = true;
            cbbLHBV.Enabled = true;
            cbbKhoaPhong.Enabled = true;
            txbLHGV.Enabled = true;
            txbLHDoiTuongHoc.Enabled = true;
            mktxbLHBatDau.Enabled = true;
            mktxbLHKetThuc.Enabled = true;
            txbLHSoTietHoc.Enabled = true;
            txbSoTietLT.Enabled = true;
            txbSoTietTH.Enabled = true;
            txbLHDiaDiem.Enabled = true;
            txbKinhPhi.Enabled = true;
            txbChiGV.Enabled = true;
            txbChiNuocUong.Enabled = true;
            txbChiKhac.Enabled = true;
            txbGhichu.Enabled = true;

            btnLHMoi.Enabled = false;
            btnLHLuu.Enabled = true;
            btnLHSua.Enabled = false;
            btnLHXoa.Enabled = false;
            btnLHBoQua.Enabled = true;
            btnLHKetthuc.Enabled = false;
            txbTenLop.Focus();
        }

        void LoadNamHienTai(ComboBox cbb)
        {
            //DateTime now = DateTime.Now;
            cbb.Text = LopHocDAO.Instance.LoadNamHienTai();
        }
        void loadListNam(ComboBox ccb)
        {
            List<NamNC> ListTuNam = NamNCDAO.Instance.GetDSNamNC();
            ccb.DataSource = ListTuNam;
            ccb.DisplayMember = "Namten";
        }


        private void dtgvLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnLHMoi.Enabled == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dtgvLH.Rows[e.RowIndex];
                    txbLHid.Text = row.Cells[0].Value.ToString();
                    cbbLHNam.Text = row.Cells[1].Value.ToString();
                    cbbLoaiDT.Text = row.Cells[2].Value.ToString();
                    txbTenLop.Text = row.Cells[3].Value.ToString();
                    cbbLHBV.Text = row.Cells[4].Value.ToString();
                    cbbKhoaPhong.Text = row.Cells[5].Value.ToString();
                    txbLHGV.Text = row.Cells[6].Value.ToString();
                    txbLHDoiTuongHoc.Text = row.Cells[7].Value.ToString();
                    mktxbLHBatDau.Value = Convert.ToDateTime(row.Cells[8].Value);
                    mktxbLHKetThuc.Value = Convert.ToDateTime(row.Cells[9].Value);
                    txbLHSoTietHoc.Text = row.Cells[10].Value.ToString();
                    txbSoTietLT.Text = row.Cells[11].Value.ToString();
                    txbSoTietTH.Text = row.Cells[12].Value.ToString();
                    txbLHDiaDiem.Text = row.Cells[13].Value.ToString();
                    txbKinhPhi.Text = row.Cells[14].Value.ToString();
                    txbChiGV.Text = row.Cells[15].Value.ToString();
                    txbChiNuocUong.Text = row.Cells[16].Value.ToString();
                    txbChiKhac.Text = row.Cells[17].Value.ToString();
                    txbGhichu.Text = row.Cells[18].Value.ToString();

                }
            }
        }

        void LoadLHtoDtgvLH()
        {

            int namHienTai = Convert.ToInt32(LopHocDAO.Instance.LoadNamHienTai());
            dtgvLH.DataSource = LopHocDAO.Instance.LoadLopHoc(namHienTai);
        }

        private void btnLHTim_Click(object sender, EventArgs e)
        {
            dtgvLH.DataSource = LopHocDAO.Instance.SearchLHbyTuNamDenNam(Convert.ToInt32(cbbSearchLHTuNam.Text), Convert.ToInt32(cbbSearchLHDenNam.Text));
        }

        private void btntimLHGV_Click(object sender, EventArgs e)
        {
            dtgvLH.DataSource = LopHocDAO.Instance.SearchLHbyTuNamDenNam(Convert.ToInt32(cbbSearchLHTuNam.Text), Convert.ToInt32(cbbSearchLHDenNam.Text));
        }

        private void txbSearchLop_TextChanged(object sender, EventArgs e)
        {
            dtgvLH.DataSource = LopHocDAO.Instance.SearchLHbyTenLop(Convert.ToInt32(cbbSearchLHTuNam.Text), Convert.ToInt32(cbbSearchLHDenNam.Text), txbSearchLop.Text);
        }

        private void txbSearchGV_TextChanged(object sender, EventArgs e)
        {
            dtgvLH.DataSource = LopHocDAO.Instance.SearchLHbyGV(Convert.ToInt32(cbbSearchLHTuNam.Text), Convert.ToInt32(cbbSearchLHDenNam.Text), txbSearchGV.Text);

        }

        private void btnLHMoi_Click(object sender, EventArgs e)
        {
            moiButton();
        }

        private void btnLHSua_Click(object sender, EventArgs e)
        {
            suaButton();
        }

        private void btnLHBoQua_Click(object sender, EventArgs e)
        {
            LoadLHtoDtgvLH();
            LoadButton();
        }

        private void txbLHSoTietHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbSoTietLT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbSoTietTH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbKinhPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbChiGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbChiNuocUong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbChiKhac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLHKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLHXoa_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (int.TryParse(txbLHid.Text, out num))
            {
                DialogResult drXoa = MessageBox.Show("Xoa Lớp: " + txbTenLop.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                if (drXoa == DialogResult.Yes)
                {

                    LopHocDAO.Instance.DeleteLopHoc(num);
                    LoadLHtoDtgvLH();
                    LoadButton();
                }
            }
            else
            {
                LoadLHtoDtgvLH();
                LoadButton();
            }
        }

        private void btnLHLuu_Click(object sender, EventArgs e)
        {
            if (txbTenLop.Text == "")
            {
                MessageBox.Show("Tên lớp không được để trống", "Cảnh báo");
                txbTenLop.Focus();
            }
            else if (LopHocDAO.Instance.CheckBV((cbbLHBV.SelectedItem as BenhVien).DonViid) == false)
            {
                MessageBox.Show("Bệnh viện mở lớp không hợp lệ", "Cảnh báo");
                cbbLHBV.Focus();
            }
            else if (txbLHGV.Text == "")
            {
                MessageBox.Show("Giảng viên không được để trống");
                txbLHGV.Focus();
            }
            else if (txbLHDoiTuongHoc.Text == "")
            {
                MessageBox.Show("Đối tượng học không được để trống");
                txbLHDoiTuongHoc.Focus();
            }
            else if (txbLHDiaDiem.Text == "")
            {
                MessageBox.Show("Địa điểm không được để trống");
                txbLHDoiTuongHoc.Focus();
            }
            else
            {
                int LHNam = Convert.ToInt32(cbbLHNam.Text);
                string TenLop = DataProvider.Instance.FormatStringInput(txbTenLop.Text);
                int LHBV = (cbbLHBV.SelectedItem as BenhVien).DonViid;
                string LHKhoaPhong = DataProvider.Instance.FormatStringInput(cbbKhoaPhong.Text);
                string LHGV = DataProvider.Instance.FormatStringInput(txbLHGV.Text);
                string LHDoiTuong = DataProvider.Instance.FormatStringInput(txbLHDoiTuongHoc.Text);
                DateTime LHThoiGianBatDau = DateTime.ParseExact(mktxbLHBatDau.Text, "dd/MM/yyyy", null);
                DateTime LHThoiGianKetThuc = DateTime.ParseExact(mktxbLHKetThuc.Text, "dd/MM/yyyy", null);
                string LHSoTiet = DataProvider.Instance.FormatStringInput(txbLHSoTietHoc.Text);
                string LHSoTietLT = DataProvider.Instance.FormatStringInput(txbSoTietLT.Text);
                string LHSoTietTH = DataProvider.Instance.FormatStringInput(txbSoTietTH.Text);
                string LHDiaDiem = DataProvider.Instance.FormatStringInput(txbLHDiaDiem.Text);
                string LHKinhPhi = DataProvider.Instance.FormatStringInput(txbKinhPhi.Text);
                string LHChiGV = DataProvider.Instance.FormatStringInput(txbChiGV.Text);
                string LHChiNuoc = DataProvider.Instance.FormatStringInput(txbChiNuocUong.Text);
                string LHChiKhac = DataProvider.Instance.FormatStringInput(txbChiKhac.Text);
                string LHGhichu = DataProvider.Instance.FormatStringInput(txbGhichu.Text);
                string LoaiDT = cbbLoaiDT.Text;
                bool Insertbool = false;
                if (txbLHid.Text == "")
                {
                    Insertbool= LopHocDAO.Instance.InsertLopHoc(LHNam, TenLop, LHBV, LHKhoaPhong, LHGV, LHDoiTuong, LHThoiGianBatDau, LHThoiGianKetThuc, LHSoTiet, LHSoTietLT, LHSoTietTH, LHDiaDiem, LHKinhPhi, LHChiGV, LHChiNuoc, LHChiKhac, LHGhichu, LoaiDT);
                   if(Insertbool)
                   {
                       LoadLHtoDtgvLH();
                       LoadButton();
                       btnLHMoi.Focus();
                   }
                   else
                   {
                       MessageBox.Show("Lỗi thêm mới:");
                       txbTenLop.Focus();

                   }

                }
                else
                {
                   Insertbool=  LopHocDAO.Instance.UpdateLopHoc(LHNam, TenLop, LHBV, LHKhoaPhong, LHGV, LHDoiTuong, LHThoiGianBatDau, LHThoiGianKetThuc, LHSoTiet, LHSoTietLT, LHSoTietTH, LHDiaDiem, LHKinhPhi, LHChiGV, LHChiNuoc, LHChiKhac, LHGhichu, LoaiDT, Convert.ToInt32(txbLHid.Text));
                   if (Insertbool)
                    {
                        LoadLHtoDtgvLH();
                        LoadButton();
                        btnLHMoi.Focus();
                    }
                    else
                   {
                       MessageBox.Show("Lỗi cập nhật:");
                       txbTenLop.Focus();
                   }
                }

            }
        }
    }
}

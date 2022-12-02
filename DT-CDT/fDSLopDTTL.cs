using DT_CDT.DAO;
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
    public partial class fDSLopDTTL : Form
    {
        public fDSLopDTTL()
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
            loadHVandKPanDVCT();
            LoadChungNhanDaoTao();
            LoadDSLoaiChungNhan();
            
        }
        void loadHVandKPanDVCT()
        {
            cbbGiangVien.DataSource = HocVienDAO.Instance.LoadListHVbyID();
            cbbGiangVien.ValueMember = "HOCVIENID";
            cbbGiangVien.DisplayMember = "HOC_VIEN";
        }
        void LoadDSKhoaPhongToCombobox()
        {
            cbbKhoaPhong.DataSource = KhoaPhongDAO.Instance.LoadListKhoaPhong();
            cbbKhoaPhong.ValueMember = "KHOAPHONGID";
            cbbKhoaPhong.DisplayMember = "KHOAPHONGTEN";
        }
        void LoadDSBenhVienToCombobox()
        {
            cbbLHBV.DataSource = BenhVienDAO.Instance.LoadListBenhVien();
            cbbLHBV.ValueMember = "DONVIID";
            cbbLHBV.DisplayMember = "DONVITEN";
        }
        void LoadDSLoaiChungNhan()
        {
            cbbLoaiChungNhan.DataSource = LoaiCNDTDAO.Instance.LoadListCNDAOTAO();
            cbbLoaiChungNhan.ValueMember = "CNDTID";
            cbbLoaiChungNhan.DisplayMember = "CNDTTEN";
        }
 
        void LoadButton()
        {
            txbLHid.Enabled = false;
            cbbLHNam.Enabled = false;
            txbTenLop.Enabled = false;
            cbbLHBV.Enabled = false;
            cbbKhoaPhong.Enabled = false;
            txbTroGiang.Enabled = false;
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
            cbbGiangVien.Enabled = false;
            cbbTrangThaiLop.Enabled = false;
            txbChucDanh.Enabled = false;
            txbDVCT.Enabled = false;
            txbKPCT.Enabled = false;
            cbbLoaiChungNhan.Enabled = false;
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

            txbTenLop.Enabled = true;
            cbbLHBV.Enabled = true;
            cbbKhoaPhong.Enabled = true;
            cbbTrangThaiLop.Enabled = true;
            txbTroGiang.Enabled = true;
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
            cbbGiangVien.Enabled = true;
            txbChucDanh.Enabled = false;
            txbDVCT.Enabled = false;
            txbKPCT.Enabled = false;
            cbbLoaiChungNhan.Enabled = true;

            txbLHid.Text = "";
            //   LoadNamHienTai(cbbLHNam);
            txbTenLop.Text = "";
            txbTenLop.Focus();
            cbbLHBV.Text = "";
            cbbKhoaPhong.Text = "";
            txbTroGiang.Text = "";
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
            cbbGiangVien.Text = "";
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
            cbbTrangThaiLop.Enabled = true;
            txbTenLop.Enabled = true;
            cbbLHBV.Enabled = true;
            cbbKhoaPhong.Enabled = true;
            txbTroGiang.Enabled = true;
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
            cbbGiangVien.Enabled = true;
            txbChucDanh.Enabled = false;
            txbDVCT.Enabled = false;
            txbKPCT.Enabled = false;
            cbbLoaiChungNhan.Enabled = true;
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
            cbb.Text = DSLopDTTLDAO.Instance.LoadNamHienTai();
        }
        void loadListNam(ComboBox ccb)
        {
            ccb.DataSource = NamNCDAO.Instance.LoadListNamNC();
            ccb.ValueMember = "NAMID";
            ccb.DisplayMember = "NAMTEN";
        }


        private void dtgvLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnLHMoi.Enabled == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dtgvLH.Rows[e.RowIndex];
                    txbDTTLMASO.Text = row.Cells[0].Value.ToString();
                    cbbLHNam.Text = row.Cells[1].Value.ToString();
                    txbTenLop.Text = row.Cells[2].Value.ToString();
                    cbbLHBV.Text = row.Cells[3].Value.ToString();
                    cbbKhoaPhong.Text = row.Cells[4].Value.ToString();
                    cbbGiangVien.Text = row.Cells[5].Value.ToString();
                    txbChucDanh.Text = row.Cells[6].Value.ToString();
                    txbDVCT.Text = row.Cells[7].Value.ToString();
                    txbKPCT.Text = row.Cells[8].Value.ToString();
                    txbTroGiang.Text = row.Cells[9].Value.ToString();
                    txbLHDoiTuongHoc.Text = row.Cells[10].Value.ToString();
                    mktxbLHBatDau.Value = Convert.ToDateTime(row.Cells[11].Value);
                    mktxbLHKetThuc.Value = Convert.ToDateTime(row.Cells[12].Value);
                    txbLHSoTietHoc.Text = row.Cells[13].Value.ToString();
                    txbSoTietLT.Text = row.Cells[14].Value.ToString();
                    txbSoTietTH.Text = row.Cells[15].Value.ToString();
                    cbbLoaiChungNhan.Text = row.Cells[16].Value.ToString();
                    txbLHDiaDiem.Text = row.Cells[17].Value.ToString();
                    txbKinhPhi.Text = row.Cells[18].Value.ToString();
                    txbChiGV.Text = row.Cells[19].Value.ToString();
                    txbChiNuocUong.Text = row.Cells[20].Value.ToString();
                    txbChiKhac.Text = row.Cells[21].Value.ToString();
                    txbGhichu.Text = row.Cells[22].Value.ToString();
                    txbLHid.Text = DSLopDTTLDAO.Instance.GetHCKIdByDTTLMASO(txbDTTLMASO.Text).ToString();
                    cbbTrangThaiLop.Text = row.Cells[24].Value.ToString();

                }
            }
        }

        void LoadLHtoDtgvLH()
        {

            int namHienTai = Convert.ToInt32(DSLopDTTLDAO.Instance.LoadNamHienTai());
            dtgvLH.DataSource = DSLopDTTLDAO.Instance.LoadLopHoc(namHienTai);
        }

        private void btnLHTim_Click(object sender, EventArgs e)
        {
            dtgvLH.DataSource = DSLopDTTLDAO.Instance.SearchLHbyTuNamDenNam(Convert.ToInt32(cbbSearchLHTuNam.Text), Convert.ToInt32(cbbSearchLHDenNam.Text));
        }

        private void btntimLHGV_Click(object sender, EventArgs e)
        {
            dtgvLH.DataSource = DSLopDTTLDAO.Instance.SearchLHbyTuNamDenNam(Convert.ToInt32(cbbSearchLHTuNam.Text), Convert.ToInt32(cbbSearchLHDenNam.Text));
        }

        private void txbSearchLop_TextChanged(object sender, EventArgs e)
        {
            dtgvLH.DataSource = DSLopDTTLDAO.Instance.SearchLHbyTenLop(Convert.ToInt32(cbbSearchLHTuNam.Text), Convert.ToInt32(cbbSearchLHDenNam.Text), txbSearchLop.Text);
        }

        private void txbSearchGV_TextChanged(object sender, EventArgs e)
        {
            dtgvLH.DataSource = DSLopDTTLDAO.Instance.SearchLHbyGV(Convert.ToInt32(cbbSearchLHTuNam.Text), Convert.ToInt32(cbbSearchLHDenNam.Text), txbSearchGV.Text);

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
                if(DSLopDTTLDAO.Instance.CountHocVienByLop(num))
                {
                    MessageBox.Show("Lớp: " + txbTenLop.Text + " đã cập nhật học viên", "Cảnh báo");
                    LoadLHtoDtgvLH();
                    LoadButton();
                }
                else
                {
                    DialogResult drXoa = MessageBox.Show("Xoa Lớp: " + txbTenLop.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                    if (drXoa == DialogResult.Yes)
                    {

                        DSLopDTTLDAO.Instance.DeleteLopHoc(num);
                        LoadLHtoDtgvLH();
                        LoadButton();
                    }
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
                txbTenLop.Focus();
            }
            else if (BenhVienDAO.Instance.Count_idDonVi_in_LopHoc(Convert.ToInt32(cbbLHBV.SelectedValue)) == 0)
            {
                cbbLHBV.Focus();
            }
            else if (cbbGiangVien.Text == "")
            {
                txbTroGiang.Focus();
            }
           else if(txbLHSoTietHoc.Text =="")
            {
                txbLHSoTietHoc.Focus();
            }
            else
            {
                int LHNam = Convert.ToInt32(cbbLHNam.Text);
                string TenLop = DataProvider.Instance.FormatStringInput(txbTenLop.Text);
                int LHBV = Convert.ToInt32(cbbLHBV.SelectedValue);
                //doi kieu cua khoa phong mo lop
                int LHKhoaPhong = Convert.ToInt32(cbbKhoaPhong.SelectedValue);
                string LHGVTROGIANG = DataProvider.Instance.FormatStringInput(txbTroGiang.Text);
                string LHDoiTuong = DataProvider.Instance.FormatStringInput(txbLHDoiTuongHoc.Text);
                string LHThoiGianBatDau = mktxbLHBatDau.Text;
                string LHThoiGianKetThuc = mktxbLHKetThuc.Text;
                string LHSoTiet = DataProvider.Instance.FormatStringInput(txbLHSoTietHoc.Text);
                string LHSoTietLT = DataProvider.Instance.FormatStringInput(txbSoTietLT.Text);
                string LHSoTietTH = DataProvider.Instance.FormatStringInput(txbSoTietTH.Text);
                string LHDiaDiem = DataProvider.Instance.FormatStringInput(txbLHDiaDiem.Text);
                string LHKinhPhi = DataProvider.Instance.FormatStringInput(txbKinhPhi.Text);
                string LHChiGV = DataProvider.Instance.FormatStringInput(txbChiGV.Text);
                string LHChiNuoc = DataProvider.Instance.FormatStringInput(txbChiNuocUong.Text);
                string LHChiKhac = DataProvider.Instance.FormatStringInput(txbChiKhac.Text);
                string LHGhichu = DataProvider.Instance.FormatStringInput(txbGhichu.Text);
                int idgianvien = Convert.ToInt32(cbbGiangVien.SelectedValue);
                int LOAICHUNGNHAN = Convert.ToInt32(cbbLoaiChungNhan.SelectedValue);
                int TRANGTHAILOP = 0;
                if (cbbTrangThaiLop.Text == "Kết thúc")
                {
                    TRANGTHAILOP = 1;
                }

                bool Insertbool = false;
                if (txbLHid.Text == "")
                {
                    Insertbool= DSLopDTTLDAO.Instance.InsertLopHoc(LHNam, TenLop, LHBV, LHKhoaPhong, LHGVTROGIANG, LHDoiTuong, LHThoiGianBatDau, LHThoiGianKetThuc, LHSoTiet, LHSoTietLT, LHSoTietTH, LHDiaDiem, LHKinhPhi, LHChiGV, LHChiNuoc, LHChiKhac, LHGhichu, LOAICHUNGNHAN, idgianvien, LOAICHUNGNHAN, TRANGTHAILOP);
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
                   Insertbool=  DSLopDTTLDAO.Instance.UpdateLopHoc(LHNam, TenLop, LHBV, LHKhoaPhong, LHGVTROGIANG, LHDoiTuong, LHThoiGianBatDau, LHThoiGianKetThuc, LHSoTiet, LHSoTietLT, LHSoTietTH, LHDiaDiem, LHKinhPhi, LHChiGV, LHChiNuoc, LHChiKhac, LHGhichu, idgianvien, LOAICHUNGNHAN, Convert.ToInt32(txbLHid.Text), TRANGTHAILOP);
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

        void LoadChungNhanDaoTao()
        {
            cbbLoaiChungNhan.DataSource = LoaiCNDTDAO.Instance.LoadListCNDAOTAO();
            cbbLoaiChungNhan.ValueMember = "CNDTID";
            cbbLoaiChungNhan.DisplayMember = "CNDTTEN";
        }
        private void cbbGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txbChucDanh.Text = HocVienDAO.Instance.GetChucDanhbyHocVienID(Convert.ToInt32(cbbGiangVien.SelectedValue));
                txbDVCT.Text = HocVienDAO.Instance.GetDVCTbyHocVienID(Convert.ToInt32(cbbGiangVien.SelectedValue));
                txbKPCT.Text = HocVienDAO.Instance.GetKhoaPhongbyHocVienID(Convert.ToInt32(cbbGiangVien.SelectedValue));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void txbSearchLop_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearchLop.Text = "";
        
        }

        private void txbSearchGV_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearchGV.Text = "";
        }
    }
}

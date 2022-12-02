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
    public partial class fDSNCKH : Form
    {
        public fDSNCKH()
        {
            InitializeComponent();
            LoadNCKH();
            loadNamNC();
            LoadDSKhoaPhong();
            LoadDSLoaiDeTai();
            LoadDSCapDeTai();
            LoadDSLinhVucNghienCuu();
            LoadTinhTrangDeTai();
            ButtonLoad();
            loadTuNam();
            loadDenNam();
            LoadNamNCKH(cbbTuNam);
            LoadNamNCKH(cbbDenNam);
            loadHocVienAndKP(cbbChuNhiem);
            loadHocVienAndKP(cbbCongsu1);
            loadHocVienAndKP(cbbCongsu2);
            loadHocVienAndKP(cbbCongsu3);
            loadHocVienAndKP(cbbCongsu4);
        }
        
       
        void LoadNamNCKH(ComboBox cbbNamNC)
        {
            DateTime now = DateTime.Now;
            cbbNamNC.Text = NCKHDAO.Instance.LoadNamNCKH();
        }
        void LoadNCKH()
        {

            int namNC = Convert.ToInt32(NCKHDAO.Instance.LoadNamNCKH());
            dtgvNCKH.DataSource = NCKHDAO.Instance.LoadNCKH(namNC);
        }
        void ButtonLoad()
        {
            cbbNam.Enabled = false;
            cbbNCKHKP.Enabled = false;
            cbbLoaiDeTai.Enabled = false;
            cbbNCKHCapDeTai.Enabled = false;
            cbbLinhVucNghienCuu.Enabled = false;
            cbbChuNhiem.Enabled = false;
            cbbCongsu1.Enabled = false;
            cbbCongsu2.Enabled = false;
            cbbCongsu3.Enabled = false;
            cbbCongsu4.Enabled = false;
            txbTenDeTai.Enabled = false;
            txbMucTieu.Enabled = false;
            cbbTrangThaiDeTai.Enabled = false;
            txbKinhPhi.Enabled = false;
            dtpkBatDau.Enabled = false;
            dtpkKetThuc.Enabled = false;
            dtpkNghiemThuDC.Enabled = false;
            dtpkNghiemThuDT.Enabled = false;
            txbKetQua.Enabled = false;
            txbGhichu.Enabled = false;
            btnBVMoi.Enabled = true;
            btnBVLuu.Enabled = false;
            btnBVSua.Enabled = true;
            btnBVXoa.Enabled = true;
            btnBVBoQua.Enabled = false;
            btnBVKetthuc.Enabled = true;


        }
        void MoiButton()
        {
            cbbNam.Enabled = true;
            cbbNCKHKP.Enabled = true;
            cbbLoaiDeTai.Enabled = true;
            cbbNCKHCapDeTai.Enabled = true;
            cbbLinhVucNghienCuu.Enabled = true;
            cbbChuNhiem.Enabled = true;
            cbbCongsu1.Enabled = true;
            cbbCongsu2.Enabled = true;
            cbbCongsu3.Enabled = true;
            cbbCongsu4.Enabled = true;
            txbTenDeTai.Enabled = true;
            txbMucTieu.Enabled = true;
            cbbTrangThaiDeTai.Enabled = true;
            txbKinhPhi.Enabled = true;
            dtpkBatDau.Enabled = true;
            dtpkKetThuc.Enabled = true;
            dtpkNghiemThuDC.Enabled = true;
            dtpkNghiemThuDT.Enabled = true;
            txbKetQua.Enabled = true;
            txbGhichu.Enabled = true;
            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVXoa.Enabled = false;
            btnBVBoQua.Enabled = true;
            btnBVKetthuc.Enabled = false;
            


        }
        void SuaButton()
        {
            cbbNam.Enabled = true;
            cbbNCKHKP.Enabled = true;
            cbbLoaiDeTai.Enabled = true;
            cbbNCKHCapDeTai.Enabled = true;
            cbbLinhVucNghienCuu.Enabled = true;
            cbbChuNhiem.Enabled = true;
            cbbCongsu1.Enabled = true;
            cbbCongsu2.Enabled = true;
            cbbCongsu3.Enabled = true;
            cbbCongsu4.Enabled = true;
            txbTenDeTai.Enabled = true;
            txbMucTieu.Enabled = true;
            cbbTrangThaiDeTai.Enabled = true;
            txbKinhPhi.Enabled = true;
            dtpkBatDau.Enabled = true;
            dtpkKetThuc.Enabled = true;
            dtpkNghiemThuDC.Enabled = true;
            dtpkNghiemThuDT.Enabled = true;
            txbGhichu.Enabled = true;
            txbKetQua.Enabled = true;
            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVXoa.Enabled = false;
            btnBVBoQua.Enabled = true;
            btnBVKetthuc.Enabled = false;


        }
        void loadNamNC()
        {

            cbbNam.DataSource = NamNCDAO.Instance.LoadListNamNC();
            cbbNam.ValueMember = "NAMID";
            cbbNam.DisplayMember = "Namten";
        }

        void loadTuNam()
        {
            cbbTuNam.DataSource = NamNCDAO.Instance.LoadListNamNC();
            cbbTuNam.ValueMember = "NAMID";
            cbbTuNam.DisplayMember = "Namten";
        }
        void loadDenNam()
        {
            cbbDenNam.DataSource = NamNCDAO.Instance.LoadListNamNC();
            cbbDenNam.ValueMember = "NAMID";
            cbbDenNam.DisplayMember = "Namten";
        }
        //       void LoadTinhchunhiem()
        //       {
        //           List<HocVien> ListTrangThai = HocVienDAO.Instance.GetDSHocVien();
        //          cbbTrangThaiDeTai.DataSource = ListTrangThai;
        //           cbbTrangThaiDeTai.DisplayMember = "TTDTTen";
        //       }
        void LoadHocVien(ComboBox cbb)
        {
            cbb.DataSource = HocVienDAO.Instance.LoadListHocVien();
            cbb.ValueMember = "HOCVIENID";
            cbb.DisplayMember = "HOCVIENHOTEN";
        }


        void LoadTinhTrangDeTai()
        {
            cbbTrangThaiDeTai.DataSource = TinhTrangDeTaiDAO.Instance.LoadListTinhTrangDeTai();
            cbbTrangThaiDeTai.ValueMember = "TTDTID";
            cbbTrangThaiDeTai.DisplayMember = "TTDTTEN";
        }

        void LoadDSLinhVucNghienCuu()
        {
            cbbLinhVucNghienCuu.DataSource = LinhVucNghienCuuDAO.Instance.LoatListLinhVucNghienCuu();
            cbbLinhVucNghienCuu.ValueMember = "LVNCID";
            cbbLinhVucNghienCuu.DisplayMember = "LVNCTEN";
        }
        void LoadDSCapDeTai()
        {
            cbbNCKHCapDeTai.DataSource = CapDeTaiDAO.Instance.LoatListCapDeTai();
            cbbNCKHCapDeTai.ValueMember = "CAPDTID";
            cbbNCKHCapDeTai.DisplayMember = "CAPDTTEN";
        }


        
        void loadHocVienAndKP(ComboBox cbb)
        {
            cbb.DataSource = HocVienDAO.Instance.LoadHocVienAndKhoaPhong();
            cbb.ValueMember = "HOCVIENID";
            cbb.DisplayMember = "HOTENHV";
        }


        void LoadDSKhoaPhong()
        {
            cbbNCKHKP.DataSource = KhoaPhongDAO.Instance.LoadListKhoaPhong();
            cbbNCKHKP.ValueMember = "KHOAPHONGID";
            cbbNCKHKP.DisplayMember = "KHOAPHONGTEN";
        }
        void LoadDSLoaiDeTai()
        {
            cbbLoaiDeTai.DataSource = LoaiDeTaiDAO.Instance.LoadListLoaiDeTai();
            cbbLoaiDeTai.ValueMember = "IDLOAIDETAI";
            cbbLoaiDeTai.DisplayMember = "LOAIDETAITEN";
        }

        private void btnBVKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbKinhPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBVMoi_Click(object sender, EventArgs e)
        {
            txbNCKHid.Text = "";
            txbNCKHMASO.Text = "";
            LoadNamNCKH(cbbNam);
            //cbbNCKHKhoaPhong.Text = "";
            //cbbLoaiDeTai.Text = "";
            //cbbNCKHCapDeTai.Text = "";
            //cbbLinhVucNghienCuu.Text = "";
            cbbChuNhiem.Text = "";
            cbbCongsu1.Text = "";
            cbbCongsu2.Text = "";
            cbbCongsu3.Text = "";
            cbbCongsu4.Text = "";
            txbTenDeTai.Text = "";
            txbMucTieu.Text = "";
            cbbTrangThaiDeTai.Text = "";
            txbKinhPhi.Text = "";
            dtpkBatDau.Text = "";
            dtpkKetThuc.Text = "";
            dtpkNghiemThuDC.Text = "";
            dtpkNghiemThuDT.Text = "";            
            MoiButton();
        }
        private void btnBVBoQua_Click(object sender, EventArgs e)
        {
            ButtonLoad();
        }

        private void dtgvNCKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnBVMoi.Enabled == true)
            {
                if (e.RowIndex >= 0)
                {
                    txbPhaiCN.Text = "";
                    txbPhaiCS1.Text = "";
                    txbPhaiCS2.Text = "";
                    txbPhaiCS3.Text = "";
                    txbPhaiCS4.Text = "";
                    txbNSCN.Text = "";
                    txbNSCS1.Text = "";
                    txbNSCS2.Text = "";
                    txbNSCS3.Text = "";
                    txbNSCS4.Text = "";
                    txbCDCN.Text = "";
                    txbCDCS1.Text = "";
                    txbCDCS2.Text = "";
                    txbCDCS3.Text = "";
                    txbCDCS4.Text = "";
                    txbKPCN.Text = "";
                    txbKPCS1.Text = "";
                    txbKPCS2.Text = "";
                    txbKPCS3.Text = "";
                    txbKPCS4.Text = "";
                    txbDVCTCN.Text = "";
                    txbDVCTCS1.Text = "";
                    txbDVCTCS2.Text = "";
                    txbDVCTCS3.Text = "";
                    txbDVCTCS4.Text = "";
                    
                    DataGridViewRow row = this.dtgvNCKH.Rows[e.RowIndex];
                    txbNCKHMASO.Text = row.Cells[0].Value.ToString();
                    cbbNam.Text = row.Cells[1].Value.ToString();
                    cbbLoaiDeTai.Text = row.Cells[2].Value.ToString();
                    cbbChuNhiem.Text = row.Cells[3].Value.ToString();
                    cbbCongsu1.Text = row.Cells[4].Value.ToString();
                    cbbCongsu2.Text = row.Cells[5].Value.ToString();
                    cbbCongsu3.Text = row.Cells[6].Value.ToString();
                    cbbCongsu4.Text = row.Cells[7].Value.ToString();
                    txbTenDeTai.Text = row.Cells[8].Value.ToString();
                    txbMucTieu.Text = row.Cells[9].Value.ToString();
                    cbbNCKHKP.Text = row.Cells[10].Value.ToString();
                    cbbLinhVucNghienCuu.Text = row.Cells[11].Value.ToString();
                    cbbNCKHCapDeTai.Text = row.Cells[12].Value.ToString();
                    dtpkBatDau.Text = row.Cells[13].Value.ToString();
                    dtpkKetThuc.Text = row.Cells[14].Value.ToString();
                    txbKinhPhi.Text = row.Cells[15].Value.ToString();
                    cbbTrangThaiDeTai.Text = row.Cells[16].Value.ToString();
                    dtpkNghiemThuDC.Text = row.Cells[17].Value.ToString();
                    dtpkNghiemThuDT.Text = row.Cells[18].Value.ToString();
                    txbKetQua.Text = row.Cells[19].Value.ToString();
                    txbGhichu.Text = row.Cells[20].Value.ToString();
                    txbNCKHid.Text = NCKHDAO.Instance.GetHCKIdByMANCKH(txbNCKHMASO.Text).ToString();
                    
                }
            }
        }

        void LoadNCKHbyTuNamDenNam(int tunam, int dennam)
        {
            dtgvNCKH.DataSource = NCKHDAO.Instance.SearchNCKHbyTuNamDenNam(tunam, dennam);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            LoadNCKHbyTuNamDenNam(Convert.ToInt32(cbbTuNam.Text), Convert.ToInt32(cbbDenNam.Text));
        }

        private void txbSearchDT_TextChanged(object sender, EventArgs e)
        {
            dtgvNCKH.DataSource = NCKHDAO.Instance.SearchNCKHbyTenDT(Convert.ToInt32(cbbTuNam.Text), Convert.ToInt32(cbbDenNam.Text), txbSearchDT.Text);
            
        }
        private void txbSearchNV_TextChanged(object sender, EventArgs e)
        {
            dtgvNCKH.DataSource = NCKHDAO.Instance.SearchNCKHbyTenNV(Convert.ToInt32(cbbTuNam.Text), Convert.ToInt32(cbbDenNam.Text), txbSearchDT.Text);

        }

        private void txbSearchDT_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearchDT.Text = "";
        }

        private void txbSearchNV_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearchNV.Text = "";

        }

        private void btnBVSua_Click(object sender, EventArgs e)
        {
            SuaButton();
        }
        private void btnBVLuu_Click(object sender, EventArgs e)
        {
            if (cbbChuNhiem.Text == "")
            {
                cbbChuNhiem.Focus();
            }
            else
            {
               // int NCKHid = Convert.ToInt32(txbNCKHid.Text);
                int Nam= Convert.ToInt32(cbbNam.Text);
                int LoaiDeTai = Convert.ToInt32(cbbLoaiDeTai.SelectedValue); 
                int ChuNhiem = Convert.ToInt32(cbbChuNhiem.SelectedValue);
                int? CongSu1 = 0; if(cbbCongsu1.Text == "") {CongSu1 = 0;} else { CongSu1 = Convert.ToInt32(cbbCongsu1.SelectedValue); }
                int? CongSu2 = 0; if(cbbCongsu2.Text == "") {CongSu2 = 0;} else { CongSu2 = Convert.ToInt32(cbbCongsu2.SelectedValue); }
                int? CongSu3 = 0; if (cbbCongsu3.Text == "") { CongSu3 = 0; } else { CongSu3 = Convert.ToInt32(cbbCongsu3.SelectedValue); }
                int? CongSu4 = 0; if (cbbCongsu4.Text == "") { CongSu4 = 0; } else { CongSu4 = Convert.ToInt32(cbbCongsu4.SelectedValue); }
                string TenDeTai = DataProvider.Instance.FormatStringInput(txbTenDeTai.Text); 
                string MucTieu = DataProvider.Instance.FormatStringInput(txbMucTieu.Text);
                int KhoaPhong = Convert.ToInt32(cbbNCKHKP.SelectedValue);
                int LinhVucNghienCuu = Convert.ToInt32(cbbLinhVucNghienCuu.SelectedValue);
                int CapDeTai = Convert.ToInt32(cbbNCKHCapDeTai.SelectedValue);
                string ThoiGianDuKienTu = DataProvider.Instance.FormatStringInput(dtpkBatDau.Text);
                string ThoiGianDuKienDen = DataProvider.Instance.FormatStringInput(dtpkKetThuc.Text) ; 
                string KinhPhi = DataProvider.Instance.FormatStringInput(txbKinhPhi.Text);
                int TinhTrangDeTai = Convert.ToInt32(cbbTrangThaiDeTai.SelectedValue);
                string NghiemThuDeCuong; if (dtpkNghiemThuDC.Text == "  /  /") { NghiemThuDeCuong = ""; } else { NghiemThuDeCuong = DataProvider.Instance.FormatStringInput(dtpkNghiemThuDC.Text); }
                string NghiemThuDetai; if (dtpkNghiemThuDT.Text == "  /  /") { NghiemThuDetai = ""; } else { NghiemThuDetai = DataProvider.Instance.FormatStringInput(dtpkNghiemThuDT.Text); } 
                string KetQuaNghiemThu = DataProvider.Instance.FormatStringInput(txbKetQua.Text); 
                string GhiChu = DataProvider.Instance.FormatStringInput(txbGhichu.Text);
               // Nhan vien dc cong don tu chu nhiem  va cac cong su
                string NhanVien = DataProvider.Instance.FormatStringInput(cbbChuNhiem.Text);
                if(cbbCongsu1.Text != "") {NhanVien = string.Concat(NhanVien, ", ", DataProvider.Instance.FormatStringInput(cbbCongsu1.Text));}
                if(cbbCongsu2.Text != "") {NhanVien = string.Concat(NhanVien, ", ", DataProvider.Instance.FormatStringInput(cbbCongsu2.Text));}
                if(cbbCongsu3.Text != "") {NhanVien = string.Concat(NhanVien, ", ", DataProvider.Instance.FormatStringInput(cbbCongsu3.Text));}
                if(cbbCongsu4.Text != "") {NhanVien = string.Concat(NhanVien, ", ", DataProvider.Instance.FormatStringInput(cbbCongsu4.Text));}

                if(txbNCKHid.Text == "")
                {
                    NCKHDAO.Instance.InsertNCKH(Nam, LoaiDeTai, ChuNhiem, CongSu1, CongSu2, CongSu3, CongSu4, TenDeTai, MucTieu, KhoaPhong, LinhVucNghienCuu, CapDeTai, ThoiGianDuKienTu, ThoiGianDuKienDen, KinhPhi, TinhTrangDeTai, NghiemThuDeCuong, NghiemThuDetai, KetQuaNghiemThu, GhiChu, NhanVien);
                    LoadNCKH();
                    ButtonLoad();
                }
                else
                {
                    NCKHDAO.Instance.UpdateNCKH(Nam, LoaiDeTai, ChuNhiem, CongSu1, CongSu2, CongSu3, CongSu4, TenDeTai, MucTieu, KhoaPhong, LinhVucNghienCuu, CapDeTai, ThoiGianDuKienTu, ThoiGianDuKienDen, KinhPhi, TinhTrangDeTai, NghiemThuDeCuong, NghiemThuDetai, KetQuaNghiemThu, GhiChu, NhanVien, Convert.ToInt32(txbNCKHid.Text));
                    LoadNCKH();
                    ButtonLoad();
                }
            }
        }

       
        private void dtpkBatDau_Leave(object sender, EventArgs e)
        {
            kiemtrangay(dtpkBatDau);
        }

        private void dtpkKetThuc_Leave(object sender, EventArgs e)
        {
            kiemtrangay(dtpkKetThuc);
        }      
        
        void kiemtrangay(MaskedTextBox a)
        {
            try
            {
                DateTime dt = DateTime.ParseExact(a.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception err)
            {
                
                MessageBox.Show("Ngày không hợp lệ","Cảnh báo");
                err.ToString();
                a.Text = "";
                a.Focus();

            }
        }

        private void btnBVXoa_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(txbNCKHid.Text, out num))
            {
                DialogResult drXoa = MessageBox.Show("Xóa đề tài: " + txbTenDeTai.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                if (drXoa == DialogResult.Yes)
                {
                    NCKHDAO.Instance.DeleteNCKH(num);
                    LoadNCKH();
                    ButtonLoad();
                }
            }

            else
            {
                LoadNCKH();
                ButtonLoad();
            }

        }

        private void cbbChuNhiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txbPhaiCN.Text = HocVienDAO.Instance.GetPhaibyHocVienID(Convert.ToInt32(cbbChuNhiem.SelectedValue));
                txbNSCN.Text = HocVienDAO.Instance.GetNgaySinhbyHocVienID(Convert.ToInt32(cbbChuNhiem.SelectedValue));
                txbCDCN.Text = HocVienDAO.Instance.GetChucDanhbyHocVienID(Convert.ToInt32(cbbChuNhiem.SelectedValue));
                txbDVCTCN.Text = HocVienDAO.Instance.GetDVCTbyHocVienID(Convert.ToInt32(cbbChuNhiem.SelectedValue));
                txbKPCN.Text = HocVienDAO.Instance.GetKhoaPhongbyHocVienID(Convert.ToInt32(cbbChuNhiem.SelectedValue));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void cbbCongsu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txbPhaiCS1.Text = HocVienDAO.Instance.GetPhaibyHocVienID(Convert.ToInt32(cbbCongsu1.SelectedValue));
                txbNSCS1.Text = HocVienDAO.Instance.GetNgaySinhbyHocVienID(Convert.ToInt32(cbbCongsu1.SelectedValue));
                txbCDCS1.Text = HocVienDAO.Instance.GetChucDanhbyHocVienID(Convert.ToInt32(cbbCongsu1.SelectedValue));
                txbDVCTCS1.Text = HocVienDAO.Instance.GetDVCTbyHocVienID(Convert.ToInt32(cbbCongsu1.SelectedValue));
                txbKPCS1.Text = HocVienDAO.Instance.GetKhoaPhongbyHocVienID(Convert.ToInt32(cbbCongsu1.SelectedValue));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void cbbCongsu2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txbPhaiCS2.Text = HocVienDAO.Instance.GetPhaibyHocVienID(Convert.ToInt32(cbbCongsu2.SelectedValue));
                txbNSCS2.Text = HocVienDAO.Instance.GetNgaySinhbyHocVienID(Convert.ToInt32(cbbCongsu2.SelectedValue));
                txbCDCS2.Text = HocVienDAO.Instance.GetChucDanhbyHocVienID(Convert.ToInt32(cbbCongsu2.SelectedValue));
                txbDVCTCS2.Text = HocVienDAO.Instance.GetDVCTbyHocVienID(Convert.ToInt32(cbbCongsu2.SelectedValue));
                txbKPCS2.Text = HocVienDAO.Instance.GetKhoaPhongbyHocVienID(Convert.ToInt32(cbbCongsu2.SelectedValue));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void cbbCongsu3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txbPhaiCS3.Text = HocVienDAO.Instance.GetPhaibyHocVienID(Convert.ToInt32(cbbCongsu3.SelectedValue));
                txbNSCS3.Text = HocVienDAO.Instance.GetNgaySinhbyHocVienID(Convert.ToInt32(cbbCongsu3.SelectedValue));
                txbCDCS3.Text = HocVienDAO.Instance.GetChucDanhbyHocVienID(Convert.ToInt32(cbbCongsu3.SelectedValue));
                txbDVCTCS3.Text = HocVienDAO.Instance.GetDVCTbyHocVienID(Convert.ToInt32(cbbCongsu3.SelectedValue));
                txbKPCS3.Text = HocVienDAO.Instance.GetKhoaPhongbyHocVienID(Convert.ToInt32(cbbCongsu3.SelectedValue));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void cbbCongsu4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txbPhaiCS4.Text = HocVienDAO.Instance.GetPhaibyHocVienID(Convert.ToInt32(cbbCongsu4.SelectedValue));
                txbNSCS4.Text = HocVienDAO.Instance.GetNgaySinhbyHocVienID(Convert.ToInt32(cbbCongsu4.SelectedValue));
                txbCDCS4.Text = HocVienDAO.Instance.GetChucDanhbyHocVienID(Convert.ToInt32(cbbCongsu4.SelectedValue));
                txbDVCTCS4.Text = HocVienDAO.Instance.GetDVCTbyHocVienID(Convert.ToInt32(cbbCongsu4.SelectedValue));
                txbKPCS4.Text = HocVienDAO.Instance.GetKhoaPhongbyHocVienID(Convert.ToInt32(cbbCongsu4.SelectedValue));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }
    }

}





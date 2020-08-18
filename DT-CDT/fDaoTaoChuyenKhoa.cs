using DT_CDT.DAO;
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
    public partial class fNCKH : Form
    {
        public fNCKH()
        {
            InitializeComponent();
            LoadNCKH();
            loadNamNC();
            LoadDSBV();
            LoadDSLoaiDeTai();
            LoadDSCapDeTai();
            LoadDSLinhVucNghienCuu();
            LoadTinhTrangDeTai();
            ButtonLoad();
            loadTuNam();
            loadDenNam();
            LoadNamHCK(cbbTuNamHCK);
            LoadNamHCK(cbbDenNamHCK);
            LoadHocVienvaBVvaKP(cbbHCKTenHV);
        }
// hien phai, ngay sinh, chuc danh len form -- khong can luu vao database (select tu hocvien)
        private void cbbTenHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // load phai
            int Idphai =  HocVienDAO.Instance.GetPhaibyHocVienID(Convert.ToInt32(cbbHCKTenHV.SelectedValue));
            if (Idphai == 1) { txbHCKPhai.Text = "Nam"; } else { txbHCKPhai.Text = "Nữ"; }
            // load ngay sinh

            // load chuc danh
            
        }
        //load danh sach hoc vien de chon (hocvien - tenbv - khoa phong)
        //xem lai khoa phong - doi voi nhan vien ngoai benh vien thi id khoa phong = null hoac = 0 
        //--> càn phải xóa khóa ngoại của bảng nhanvien tới khoaphong
        void LoadHocVienvaBVvaKP(ComboBox cbb)
        {
            cbb.DataSource = HocVienDAO.Instance.LoadHocVienvaBVvaKP();
            cbb.ValueMember = "HocVienid";
            cbb.DisplayMember = "HV";
        }

        void LoadDSBV()
        {
            List<BenhVien> ListBV = BenhVienDAO.Instance.GetDSBenhVien();
            cbbHCKDVCT.DataSource = ListBV;
            cbbHCKDVCT.DisplayMember = "DonViTen";
        }
       
        void LoadNamHCK(ComboBox cbbNamNC)
        {
            DateTime now = DateTime.Now;
            cbbNamNC.Text = NCKHDAO.Instance.GetDSNamHCK();
        }
        void ButtonLoad()
        {
            cbbHCKNamDT.Enabled = false;
            cbbHCKDVCT.Enabled = false;
            cbbHCKKhoaDT.Enabled = false;
            cbbNCKHCapDeTai.Enabled = false;
            cbbLinhVucNghienCuu.Enabled = false;
            cbbHCKTenHV.Enabled = false;
            cbbCongsu1.Enabled = false;
            cbbCongsu2.Enabled = false;
            cbbCongsu3.Enabled = false;
            cbbCongsu4.Enabled = false;
            txbHCKNoiDungHoc.Enabled = false;
            txbMucTieu.Enabled = false;
            cbbTrangThaiDeTai.Enabled = false;
            txbKinhPhi.Enabled = false;
            dtpkBatDau.Enabled = false;
            dtpkKetThuc.Enabled = false;
            dtpkNghiemThuDC.Enabled = false;
            dtpkNghiemThuDT.Enabled = false;
            txbKetQua.Enabled = false;
            txbGhichu.Enabled = false;
            btnDTCKMoi.Enabled = true;
            btnDTCKLuu.Enabled = false;
            btnDTCKSua.Enabled = true;
            btnDTCKXoa.Enabled = true;
            btnDTCKBoQua.Enabled = false;
            btnDTCKKetthuc.Enabled = true;


        }
        void MoiButton()
        {
            cbbHCKNamDT.Enabled = true;
            cbbHCKDVCT.Enabled = true;
            cbbHCKKhoaDT.Enabled = true;
            cbbNCKHCapDeTai.Enabled = true;
            cbbLinhVucNghienCuu.Enabled = true;
            cbbHCKTenHV.Enabled = true;
            cbbCongsu1.Enabled = true;
            cbbCongsu2.Enabled = true;
            cbbCongsu3.Enabled = true;
            cbbCongsu4.Enabled = true;
            txbHCKNoiDungHoc.Enabled = true;
            txbMucTieu.Enabled = true;
            cbbTrangThaiDeTai.Enabled = true;
            txbKinhPhi.Enabled = true;
            dtpkBatDau.Enabled = true;
            dtpkKetThuc.Enabled = true;
            dtpkNghiemThuDC.Enabled = true;
            dtpkNghiemThuDT.Enabled = true;
            txbKetQua.Enabled = true;
            txbGhichu.Enabled = true;
            btnDTCKMoi.Enabled = false;
            btnDTCKLuu.Enabled = true;
            btnDTCKSua.Enabled = false;
            btnDTCKXoa.Enabled = false;
            btnDTCKBoQua.Enabled = true;
            btnDTCKKetthuc.Enabled = false;
            


        }
        void SuaButton()
        {
            cbbHCKNamDT.Enabled = true;
            cbbHCKDVCT.Enabled = true;
            cbbHCKKhoaDT.Enabled = true;
            cbbNCKHCapDeTai.Enabled = true;
            cbbLinhVucNghienCuu.Enabled = true;
            cbbHCKTenHV.Enabled = true;
            cbbCongsu1.Enabled = true;
            cbbCongsu2.Enabled = true;
            cbbCongsu3.Enabled = true;
            cbbCongsu4.Enabled = true;
            txbHCKNoiDungHoc.Enabled = true;
            txbMucTieu.Enabled = true;
            cbbTrangThaiDeTai.Enabled = true;
            txbKinhPhi.Enabled = true;
            dtpkBatDau.Enabled = true;
            dtpkKetThuc.Enabled = true;
            dtpkNghiemThuDC.Enabled = true;
            dtpkNghiemThuDT.Enabled = true;
            txbGhichu.Enabled = true;
            txbKetQua.Enabled = true;
            btnDTCKMoi.Enabled = false;
            btnDTCKLuu.Enabled = true;
            btnDTCKSua.Enabled = false;
            btnDTCKXoa.Enabled = false;
            btnDTCKBoQua.Enabled = true;
            btnDTCKKetthuc.Enabled = false;


        }
        void loadNamNC()
        {
            List<NamNC> ListNamNC = NamNCDAO.Instance.GetDSNamNC();
            cbbHCKNamDT.DataSource = ListNamNC;
            cbbHCKNamDT.DisplayMember = "Namten";
        }

        void loadTuNam()
        {
            List<NamNC> ListTuNam = NamNCDAO.Instance.GetDSNamNC();
            cbbTuNamHCK.DataSource = ListTuNam;
            cbbTuNamHCK.DisplayMember = "Namten";
        }
        void loadDenNam()
        {
            List<NamNC> ListDenNam = NamNCDAO.Instance.GetDSNamNC();
            cbbDenNamHCK.DataSource = ListDenNam;
            cbbDenNamHCK.DisplayMember = "Namten";
        }
        //       void LoadTinhchunhiem()
        //       {
        //           List<HocVien> ListTrangThai = HocVienDAO.Instance.GetDSHocVien();
        //          cbbTrangThaiDeTai.DataSource = ListTrangThai;
        //           cbbTrangThaiDeTai.DisplayMember = "TTDTTen";
        //       }
        void LoadHocVien(ComboBox cbb)
        {
            List<HocVien> ListTrangThai = HocVienDAO.Instance.GetDSHocVien();
            cbb.DataSource = ListTrangThai;
            cbb.DisplayMember = "HocVienHoTen";
        }


        void LoadTinhTrangDeTai()
        {
            List<TinhTrangDeTai> ListTrangThai = TinhTrangDeTaiDAO.Instance.GetDSTinhTrangDeTai();
            cbbTrangThaiDeTai.DataSource = ListTrangThai;
            cbbTrangThaiDeTai.DisplayMember = "TTDTTen";
        }

        void LoadDSLinhVucNghienCuu()
        {
            List<LinhVucNghienCuu> ListCapDeTai = LinhVucNghienCuuDAO.Instance.GetDSLinhVucNghienCuu();
            cbbLinhVucNghienCuu.DataSource = ListCapDeTai;
            cbbLinhVucNghienCuu.DisplayMember = "LVNCTen";
        }
        void LoadDSCapDeTai()
        {
            List<CapDeTai> ListCapDeTai = CapDeTaiDAO.Instance.GetDSCapDeTai();
            cbbNCKHCapDeTai.DataSource = ListCapDeTai;
            cbbNCKHCapDeTai.DisplayMember = "CapDTTen";
        }


        void LoadNCKH()
        {

            int namNC = Convert.ToInt32(NCKHDAO.Instance.LoadNamNCKH());
            dtgvDTCK.DataSource = NCKHDAO.Instance.LoadNCKH(namNC);
        }
 


       
        void LoadDSLoaiDeTai()
        {
            List<LoaiDeTai> ListLoaiDeTai = LoaiDeTaiDAO.Instance.GetDSLoaiDeTai();
            cbbHCKKhoaDT.DataSource = ListLoaiDeTai;
            cbbHCKKhoaDT.DisplayMember = "LoaiDTTen";
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
            LoadNamNCKH(cbbHCKNamDT);
            //cbbNCKHKhoaPhong.Text = "";
            //cbbLoaiDeTai.Text = "";
            //cbbNCKHCapDeTai.Text = "";
            //cbbLinhVucNghienCuu.Text = "";
            cbbHCKTenHV.Text = "";
            cbbCongsu1.Text = "";
            cbbCongsu2.Text = "";
            cbbCongsu3.Text = "";
            cbbCongsu4.Text = "";
            txbHCKNoiDungHoc.Text = "";
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvDTCK.Rows[e.RowIndex];
                txbNCKHid.Text = row.Cells[0].Value.ToString();
                cbbHCKNamDT.Text = row.Cells[1].Value.ToString();
                cbbHCKKhoaDT.Text = row.Cells[2].Value.ToString();
                cbbHCKTenHV.Text = row.Cells[3].Value.ToString();
                cbbCongsu1.Text = row.Cells[4].Value.ToString();
                cbbCongsu2.Text = row.Cells[5].Value.ToString();
                cbbCongsu3.Text = row.Cells[6].Value.ToString();
                cbbCongsu4.Text = row.Cells[7].Value.ToString();
                txbHCKNoiDungHoc.Text = row.Cells[8].Value.ToString();
                txbMucTieu.Text = row.Cells[9].Value.ToString();
                cbbHCKDVCT.Text = row.Cells[10].Value.ToString();
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


            }
        }

        void LoadNCKHbyTuNamDenNam(int tunam, int dennam)
        {
            dtgvDTCK.DataSource = NCKHDAO.Instance.SearchNCKHbyTuNamDenNam(tunam, dennam);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            LoadNCKHbyTuNamDenNam(Convert.ToInt32(cbbTuNamHCK.Text), Convert.ToInt32(cbbDenNamHCK.Text));
        }

        private void txbSearchDT_TextChanged(object sender, EventArgs e)
        {
            dtgvDTCK.DataSource = NCKHDAO.Instance.SearchNCKHbyTenDT(Convert.ToInt32(cbbTuNamHCK.Text), Convert.ToInt32(cbbDenNamHCK.Text), txbSearchDT.Text);
            
        }
        private void txbSearchNV_TextChanged(object sender, EventArgs e)
        {
            dtgvDTCK.DataSource = NCKHDAO.Instance.SearchNCKHbyTenNV(Convert.ToInt32(cbbTuNamHCK.Text), Convert.ToInt32(cbbDenNamHCK.Text), txbSearchHV.Text);

        }
        




        private void txbSearchDT_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearchDT.Text = "";
        }

        private void txbSearchNV_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearchHV.Text = "";

        }

        private void btnBVSua_Click(object sender, EventArgs e)
        {
            SuaButton();
        }
        private void btnBVLuu_Click(object sender, EventArgs e)
        {
            if(cbbHCKTenHV.Text == "")
            {
                cbbHCKTenHV.Focus();
            }
            else
            {
               // int NCKHid = Convert.ToInt32(txbNCKHid.Text);
                int Nam= Convert.ToInt32(cbbHCKNamDT.Text);
                int LoaiDeTai = (cbbHCKKhoaDT.SelectedItem as LoaiDeTai).LoaiDTId;
                int ChuNhiem = Convert.ToInt32(cbbHCKTenHV.SelectedValue);
                int? CongSu1 = 0; if(cbbCongsu1.Text == "") {CongSu1 = 0;} else { CongSu1 = Convert.ToInt32(cbbCongsu1.SelectedValue); }
                int? CongSu2 = 0; if(cbbCongsu2.Text == "") {CongSu2 = 0;} else { CongSu2 = Convert.ToInt32(cbbCongsu2.SelectedValue); }
                int? CongSu3 = 0; if (cbbCongsu3.Text == "") { CongSu3 = 0; } else { CongSu3 = Convert.ToInt32(cbbCongsu3.SelectedValue); }
                int? CongSu4 = 0; if (cbbCongsu4.Text == "") { CongSu4 = 0; } else { CongSu4 = Convert.ToInt32(cbbCongsu4.SelectedValue); }
                string TenDeTai = DataProvider.Instance.FormatStringInput(txbHCKNoiDungHoc.Text); 
                string MucTieu = DataProvider.Instance.FormatStringInput(txbMucTieu.Text); 
                int KhoaPhong = (cbbHCKDVCT.SelectedItem as KhoaPhong).KhoaPhongid;
                int LinhVucNghienCuu = (cbbLinhVucNghienCuu.SelectedItem as LinhVucNghienCuu).LVNCId;
                int CapDeTai =(cbbNCKHCapDeTai.SelectedItem as CapDeTai).CapDTId;
                string ThoiGianDuKienTu = DataProvider.Instance.FormatStringInput(dtpkBatDau.Text);
                string ThoiGianDuKienDen = DataProvider.Instance.FormatStringInput(dtpkKetThuc.Text) ; 
                string KinhPhi = DataProvider.Instance.FormatStringInput(txbKinhPhi.Text);
                int TinhTrangDeTai = (cbbTrangThaiDeTai.SelectedItem as TinhTrangDeTai).TTDTId;
                string NghiemThuDeCuong; if (dtpkNghiemThuDC.Text == "  /  /") { NghiemThuDeCuong = ""; } else { NghiemThuDeCuong = DataProvider.Instance.FormatStringInput(dtpkNghiemThuDC.Text); }
                string NghiemThuDetai; if (dtpkNghiemThuDT.Text == "  /  /") { NghiemThuDetai = ""; } else { NghiemThuDetai = DataProvider.Instance.FormatStringInput(dtpkNghiemThuDT.Text); } 
                string KetQuaNghiemThu = DataProvider.Instance.FormatStringInput(txbKetQua.Text); 
                string GhiChu = DataProvider.Instance.FormatStringInput(txbGhichu.Text);
               // Nhan vien dc cong don tu chu nhiem  va cac cong su
                string NhanVien = DataProvider.Instance.FormatStringInput(cbbHCKTenHV.Text);
                if(cbbCongsu1.Text != "") {NhanVien = string.Concat(NhanVien, ", ", DataProvider.Instance.FormatStringInput(cbbCongsu1.Text));            }
                if(cbbCongsu2.Text != "") {NhanVien = string.Concat(NhanVien, ", ", DataProvider.Instance.FormatStringInput(cbbCongsu2.Text));            }
                if(cbbCongsu3.Text != "") {NhanVien = string.Concat(NhanVien, ", ", DataProvider.Instance.FormatStringInput(cbbCongsu3.Text));            }
                if(cbbCongsu4.Text != "") { NhanVien = string.Concat(NhanVien, ", ", DataProvider.Instance.FormatStringInput(cbbCongsu4.Text));            }

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
                
                MessageBox.Show(err.Message);
                a.Text = "";
                a.Focus();

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       
     }

}





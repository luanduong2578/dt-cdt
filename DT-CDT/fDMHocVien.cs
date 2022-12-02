using DT_CDT.DAO;
using DT_CDT.report;
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
    public partial class fDMHocVien : Form
    {
        public fDMHocVien()
        {
            InitializeComponent();
            LoadHocVien();
            LoadButton();
            LoadDSBenhVienToCombobox();
            LoadDSKhoaPhongToCombobox();
            LoadDSPhaiToCombobox();
            LoadDSChucDanhToCombobox();
        }

        private void btnBVKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadHocVien()
        {
            dtgvHocVien.DataSource = HocVienDAO.Instance.LoadHocVien();
        }
        void LoadButton()
        {
            txbHVid.Enabled = false;
            txbHVHoTen.Enabled = false;
            cbbHVPhai.Enabled = false;
            txbHVNamSinh.Enabled = false;
            cbbHVChucDanh.Enabled = false;
            cbbHVBenhVien.Enabled = false;
            cbbHVKhoaPhong.Enabled = false;
            txbHVDienThoai.Enabled = false;
            txbHVEmail.Enabled = false;
            txbHVGhiChu.Enabled = false;
            btnBVMoi.Enabled = true;
            btnBVLuu.Enabled = false;
            btnBVSua.Enabled = true;
            btnBVBoQua.Enabled = false;
            btnBVKetthuc.Enabled = true;
            btnBVXoa.Enabled = true;
        }
        void MoiButton()
        {
            txbHVid.Enabled = false;
            txbHVHoTen.Enabled = true;
            cbbHVPhai.Enabled = true;
            txbHVNamSinh.Enabled = true;
            cbbHVChucDanh.Enabled = true;
            cbbHVBenhVien.Enabled = true;
            cbbHVKhoaPhong.Enabled = true;
            txbHVDienThoai.Enabled = true;
            txbHVEmail.Enabled = true;
            txbHVGhiChu.Enabled = true;
            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVBoQua.Enabled = true;
            btnBVKetthuc.Enabled = false;
            btnBVXoa.Enabled = false;
            txbHVid.Text = "";
            txbHVHoTen.Text = "";
            cbbHVPhai.Text = "";
            txbHVNamSinh.Text = "";
            cbbHVChucDanh.Text = "";
            //cbbHVBenhVien.Text = "";
            //cbbHVKhoaPhong.Text = "";
            txbHVDienThoai.Text = "";
            txbHVEmail.Text = "";
            txbHVGhiChu.Text = "";
        }

        void suaButton()
        {
            txbHVid.Enabled = false;
            txbHVHoTen.Enabled = true;
            cbbHVPhai.Enabled = true;
            txbHVNamSinh.Enabled = true;
            cbbHVChucDanh.Enabled = true;
            cbbHVBenhVien.Enabled = true;
            cbbHVKhoaPhong.Enabled = true;
            txbHVDienThoai.Enabled = true;
            txbHVEmail.Enabled = true;
            txbHVGhiChu.Enabled = true;
            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVBoQua.Enabled = true;
            btnBVKetthuc.Enabled = false;
            btnBVXoa.Enabled = false;
           
        }
        private void dtgvHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnBVMoi.Enabled == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dtgvHocVien.Rows[e.RowIndex];
                    txbHVid.Text = row.Cells[0].Value.ToString();
                    txbHVHoTen.Text = row.Cells[1].Value.ToString();
                    txbHVNamSinh.Text = row.Cells[2].Value.ToString();
                    cbbHVPhai.Text = row.Cells[3].Value.ToString();
                    cbbHVBenhVien.Text = row.Cells[4].Value.ToString();
                    cbbHVKhoaPhong.Text = row.Cells[5].Value.ToString();
                    cbbHVChucDanh.Text = row.Cells[6].Value.ToString();
                    txbHVDienThoai.Text = row.Cells[7].Value.ToString();
                    txbHVEmail.Text = row.Cells[8].Value.ToString();
                    txbHVGhiChu.Text = row.Cells[9].Value.ToString();

                }
            }
        }

        private void btnBVMoi_Click(object sender, EventArgs e)
        {
            MoiButton();
        }

        private void btnBVBoQua_Click(object sender, EventArgs e)
        {
            LoadButton();
        }

        private void btnBVSua_Click(object sender, EventArgs e)
        {
            suaButton();
        }
         
        void LoadDSBenhVienToCombobox()
        {
            cbbHVBenhVien.DataSource = BenhVienDAO.Instance.LoadListBenhVien();
            cbbHVBenhVien.ValueMember = "DONVIID";
            cbbHVBenhVien.DisplayMember = "DONVITEN";
        }
        void LoadDSKhoaPhongToCombobox()
        {
            cbbHVKhoaPhong.DataSource = KhoaPhongDAO.Instance.LoadListKhoaPhong();
            cbbHVKhoaPhong.ValueMember = "KHOAPHONGID";
            cbbHVKhoaPhong.DisplayMember = "KHOAPHONGTEN";
        }
        void LoadDSPhaiToCombobox()
        {
            cbbHVPhai.DataSource = PhaiDAO.Instance.LoadListPhai();
            cbbHVPhai.ValueMember = "PHAIID";
            cbbHVPhai.DisplayMember = "PHAITEN";
        }
        void LoadDSChucDanhToCombobox()
        {
            cbbHVChucDanh.DataSource = ChucDanhDAO.Instance.LoadListChucDanh();
            cbbHVChucDanh.ValueMember = "CHUCDANHID";
            cbbHVChucDanh.DisplayMember = "CHUCDANHTEN";
        }

        private void btnBVLuu_Click(object sender, EventArgs e)
        {
            int IdChucDanh = Convert.ToInt32(cbbHVChucDanh.SelectedValue);
            int DonViid = Convert.ToInt32(cbbHVBenhVien.SelectedValue);
            int IdKhoaPhong = 1;  if (cbbHVKhoaPhong.Text != "") { IdKhoaPhong = Convert.ToInt32(cbbHVKhoaPhong.SelectedValue); }
            string HocVienHoten = DataProvider.Instance.FormatStringInput(txbHVHoTen.Text);
            string HocVienNamSinh = DataProvider.Instance.FormatStringInput(txbHVNamSinh.Text);
            string HocVienPhai = cbbHVPhai.Text;
            string HocVienDienThoai = DataProvider.Instance.FormatStringInput(txbHVDienThoai.Text);
            string HocVienGhiChu = DataProvider.Instance.FormatStringInput(txbHVGhiChu.Text);
            string HocVienEmail = DataProvider.Instance.FormatStringInput(txbHVEmail.Text);
            if (txbHVid.Text == "")
            {
                if (HocVienDAO.Instance.KiemTraHVDaTonTai(HocVienHoten, HocVienPhai, HocVienNamSinh, IdChucDanh, DonViid, IdKhoaPhong) > 0)
                {
                    MessageBox.Show("Nhân viên, Học viên đã tồn tại", "Cảnh báo");
                    txbHVHoTen.Focus();
                }
                else
                {
                    HocVienDAO.Instance.InsertHocVien(IdChucDanh, DonViid, IdKhoaPhong, HocVienHoten, HocVienNamSinh, HocVienPhai, HocVienDienThoai, HocVienGhiChu, HocVienEmail);
                    LoadHocVien();
                    LoadButton();
                }
            }
            else
            {
                int HVid = Convert.ToInt32(txbHVid.Text);
                HocVienDAO.Instance.UpdateHocVien(IdChucDanh, DonViid, IdKhoaPhong, HocVienHoten, HocVienNamSinh, HocVienPhai, HocVienDienThoai, HocVienGhiChu, HocVienEmail, HVid);
                LoadHocVien();
                LoadButton();
            }
                
            
        }

        private void txbSearchHV_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearchHV.Text = "";
        }

        private void txbSearchHV_TextChanged(object sender, EventArgs e)
        {
            LoadHocVienbyTen(txbSearchHV.Text);
        }
        void LoadHocVienbyTen(string tenhv)
        {
            dtgvHocVien.DataSource = HocVienDAO.Instance.SearchHVbyTenHV(tenhv);
        }

        private void cbbHVBenhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBVXoa_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (int.TryParse(txbHVid.Text, out num))
            {
                if (HocVienDAO.Instance.count_IDHV_in_fNCKH(num))
                {
                    MessageBox.Show("Nhân viên - Học viên đã cập nhật trong danh sách NCKH", "Cảnh báo");
                }
                else if (HocVienDAO.Instance.count_IDHV_in_fHOCCHUYENKHOA(num))
                {
                    MessageBox.Show("Nhân viên - Học viên đã cập nhật trong danh sách Học chuyên khoa", "Cảnh báo");
                }
                else if (HocVienDAO.Instance.count_IDHV_in_fDSHOCVIENDTLT(num))
                {
                    MessageBox.Show("Nhân viên - Học viên đã cập nhật trong danh sách Học Đào tạo theo lớp", "Cảnh báo");
                }
                else if (HocVienDAO.Instance.count_IDHV_in_fDSHOCVIENSHKH(num))
                {
                    MessageBox.Show("Nhân viên - Học viên đã cập nhật trong danh sách Học Sinh hoạt khoa học", "Cảnh báo");
                }
                else if (HocVienDAO.Instance.count_IDHV_in_fCAPCHUNGNHAN(num))
                {
                    MessageBox.Show("Nhân viên - Học viên đã cập nhật trong danh sách Cấp chứng nhận", "Cảnh báo");
                }


                else
                {
                    DialogResult drXoa = MessageBox.Show("Xóa Nhân viên: " + txbHVHoTen.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                    if (drXoa == DialogResult.Yes)
                    {
                        HocVienDAO.Instance.DeleteHocVien(num);
                        LoadHocVien();
                        LoadButton();
                    }
                }


            }
            else
            {
                LoadHocVien();
                LoadButton();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fInHV f = new fInHV();
            f.Show();
            
        }
    }
}

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
    public partial class fHocVienTheoLop : Form
    {
        public fHocVienTheoLop()
        {
            InitializeComponent();
            LoadDSHVtoDtgvHVTL();
            loadListNam(cbbSearchHVTLTuNam);
            loadListNam(cbbSearchHVTLLHDenNam);
            //            loadListNam(cbbLHNam);
            //            LoadNamHienTai(cbbLHNam);
            LoadNamHienTai(cbbSearchHVTLTuNam);
            LoadNamHienTai(cbbSearchHVTLLHDenNam);
            LoadLHtoDtgvLH();
            loadHVandKPanDVCT();
            ButtonLoad();
        }
        void ButtonLoad()
        {
            cbbHVHoTen.Enabled = false;
            txbSoTietHoc.Enabled = false;
            txbSoTietNghi.Enabled = false;
            cbbGoiCGKT.Enabled = false;
            txbGhichu.Enabled = false;
            btnHVTLMoi.Enabled = true;
            btnHVTLLuu.Enabled = false;
            btnHVTLSua.Enabled = true;
            btnHVTLXoa.Enabled = true;
            btnHVTLBoQua.Enabled = false;
            btnHVTLKetthuc.Enabled = true;
            btnHVTLMoi.Focus();
        }

        void ButtonMoi()
        {
            cbbHVHoTen.Enabled = true;
            txbSoTietHoc.Enabled = true;
            txbSoTietNghi.Enabled = true;
            cbbGoiCGKT.Enabled = true;
            txbGhichu.Enabled = true;
            btnHVTLMoi.Enabled = false;
            btnHVTLLuu.Enabled = true;
            btnHVTLSua.Enabled = false;
            btnHVTLXoa.Enabled = false;
            btnHVTLBoQua.Enabled = true;
            btnHVTLKetthuc.Enabled = false;
           
            cbbHVHoTen.Focus();
            txbHVTLID.Text = "";
            cbbHVHoTen.Text = "";
            txbSoTietHoc.Text = txbTongsoTiet.Text;
            txbSoTietNghi.Text = "0";
            cbbGoiCGKT.Text = "";
            txbGhichu.Text = "";
        }

        void ButtonSua()
        {
            cbbHVHoTen.Enabled = true;
            txbSoTietHoc.Enabled = true;
            txbSoTietNghi.Enabled = true;
            cbbGoiCGKT.Enabled = true;
            txbGhichu.Enabled = true;
            btnHVTLMoi.Enabled = false;
            btnHVTLLuu.Enabled = true;
            btnHVTLSua.Enabled = false;
            btnHVTLXoa.Enabled = false;
            btnHVTLBoQua.Enabled = true;
            btnHVTLKetthuc.Enabled = false;
            
            cbbHVHoTen.Focus();
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
        void LoadDSHVtoDtgvHVTL()
        {

            int namHienTai = Convert.ToInt32(LopHocDAO.Instance.LoadNamHienTai());
            dtgvHVTL.DataSource = HocVienTheoLopDAO.Instance.LoadDSLop(namHienTai);
        }

        void LoadLHtoDtgvLH()
        {

            int namHienTai = Convert.ToInt32(LopHocDAO.Instance.LoadNamHienTai());
            dtgvLop.DataSource = LopHocDAO.Instance.LoadLopHoc(namHienTai);
        }

        private void btnHVTLTim_Click(object sender, EventArgs e)
        {
            dtgvLop.DataSource = LopHocDAO.Instance.SearchLHbyTuNamDenNam(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text));
        }
        private void btntimHVTLGV_Click(object sender, EventArgs e)
        {
            dtgvHVTL.DataSource = HocVienTheoLopDAO.Instance.SearchDSHVbyTuNamDenNam(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text));
        }


        private void txbSearchHVTLLop_TextChanged(object sender, EventArgs e)
        {
            dtgvLop.DataSource = LopHocDAO.Instance.SearchLHbyTenLop(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text), txbSearchHVTLLop.Text);
        }
        private void txbSearchHVTLHV_TextChanged(object sender, EventArgs e)
        {
            dtgvHVTL.DataSource = HocVienTheoLopDAO.Instance.SearchDSHVbyHV(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text), txbSearchHVTLHV.Text);
        }


   

        private void dtgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnHVTLMoi.Enabled == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dtgvLop.Rows[e.RowIndex];
                    txbLopID.Text = row.Cells[0].Value.ToString();
                    txbTenLop.Text = row.Cells[3].Value.ToString();
                    txbTongsoTiet.Text = row.Cells[10].Value.ToString();
                    dtgvHVTL.DataSource = HocVienTheoLopDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
                }
            }
        }

        private void txbSearchHVTLLop_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearchHVTLLop.Text = "";
        }

        private void txbSearchHVTLHV_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearchHVTLHV.Text = "";
        }

        private void cbbHVHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbHVPhai.Text = (cbbHVHoTen.SelectedItem as HocVienByID).Phai;
            txbHVNS.Text = (cbbHVHoTen.SelectedItem as HocVienByID).Ngay;
            txbCD.Text = (cbbHVHoTen.SelectedItem as HocVienByID).Cd;
            txbDV.Text = (cbbHVHoTen.SelectedItem as HocVienByID).Bv;
            txbKP.Text = (cbbHVHoTen.SelectedItem as HocVienByID).Kp;
        }
        void loadHVandKPanDVCT()
        {
            List<HocVienByID> ListHV = HocVienDAO.Instance.GetHVbyID();
            cbbHVHoTen.DataSource = ListHV;
            cbbHVHoTen.DisplayMember = "HV";
        }
        private void txbSoTietHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbSoTietNghi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtgvHVTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnHVTLMoi.Enabled == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dtgvHVTL.Rows[e.RowIndex];
                    txbHVTLID.Text = row.Cells[0].Value.ToString();
                    txbTenLop.Text = row.Cells[2].Value.ToString();
                    cbbHVHoTen.Text = row.Cells[3].Value.ToString();
                    txbHVPhai.Text = row.Cells[4].Value.ToString();
                    txbHVNS.Text = row.Cells[5].Value.ToString();
                    txbCD.Text = row.Cells[6].Value.ToString();
                    txbDV.Text = row.Cells[7].Value.ToString();
                    txbKP.Text = row.Cells[8].Value.ToString();
                    
                    txbSoTietHoc.Text = row.Cells[10].Value.ToString();
                    txbSoTietNghi.Text = row.Cells[11].Value.ToString();
                    cbbGoiCGKT.Text = row.Cells[12].Value.ToString();
                    txbGhichu.Text = row.Cells[13].Value.ToString();
                }
            }

        }

        private void btnHVTLMoi_Click(object sender, EventArgs e)
        {
            if (txbLopID.Text == "")
            {
                MessageBox.Show("Yêu cầu chọn lớp học:", "Cảnh báo");
            }
            else
            {
                ButtonMoi();
            }
        }

        private void btnHVTLSua_Click(object sender, EventArgs e)
        {
            if (txbLopID.Text == "")
            {
                MessageBox.Show("Yêu cầu chọn lớp học:", "Cảnh báo");
            }
            else if(txbHVTLID.Text == "")
            {
                MessageBox.Show("Yêu cầu chọn học viên:", "Cảnh báo");
            }
            else
            {
                ButtonSua();
            }
            
        }

        private void btnHVTLBoQua_Click(object sender, EventArgs e)
        {
            ButtonLoad();
            btnHVTLMoi.Focus();
        }

        private void btnHVTLKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHVTLLuu_Click(object sender, EventArgs e)
        {
            if ((cbbHVHoTen.SelectedItem as HocVienByID).Id == 0)
            {
                MessageBox.Show("Học viên không hợp lệ", "Cảnh báo");
                cbbHVHoTen.Focus();
            }
            else
            {
  //              int DTid = Convert.ToInt32(txbHVTLID.Text);
                int MaHV = (cbbHVHoTen.SelectedItem as HocVienByID).Id;
                int MaLop = Convert.ToInt32(txbLopID.Text);
                int SoTietHoc = Convert.ToInt32(txbSoTietHoc.Text); ;
                int SoTietNghi = Convert.ToInt32(txbSoTietNghi.Text); ; 
                string ChuyenGiaoKT= cbbGoiCGKT.Text;
                string Ghichu =  txbGhichu.Text;
                bool LuuCheck = false;
                if (txbHVTLID.Text == "")
                {
                   LuuCheck = HocVienTheoLopDAO.Instance.InsertHVTL(MaHV, MaLop, SoTietHoc, SoTietNghi, ChuyenGiaoKT, Ghichu);
                   if (LuuCheck)
                   {
                       ButtonLoad();
                       dtgvHVTL.DataSource = HocVienTheoLopDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
                       btnHVTLMoi.Focus();
                   }
                   else
                   {
                       MessageBox.Show("Lỗi thêm mới");
                       cbbHVHoTen.Focus();
                   }
                }
                else
                {
                    LuuCheck = HocVienTheoLopDAO.Instance.UpdateHVTL(MaHV, MaLop, SoTietHoc, SoTietNghi, ChuyenGiaoKT, Ghichu, Convert.ToInt32(txbHVTLID.Text));
                    if (LuuCheck)
                    {
                        ButtonLoad();
                        dtgvHVTL.DataSource = HocVienTheoLopDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
                        btnHVTLMoi.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cập nhật");
                        cbbHVHoTen.Focus();
                    }
                }
            }
        }

        private void btnHVTLXoa_Click(object sender, EventArgs e)
        {
           int num = 0;

            if (int.TryParse(txbHVTLID.Text, out num))
            {
                DialogResult drXoa = MessageBox.Show("Xoa học viên: " + cbbHVHoTen.Text + " - Lớp: " + txbTenLop.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                if (drXoa == DialogResult.Yes)
                {
                    HocVienTheoLopDAO.Instance.DeleteHVTL(num);

                    ButtonLoad();

                    btnHVTLMoi.Focus();
                    if (txbLopID.Text == "")
                    {
                        LoadDSHVtoDtgvHVTL();
                    }
                    else
                    {
                        dtgvHVTL.DataSource = HocVienTheoLopDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
                    }
                }
            }
            else
            {
                ButtonLoad();
                dtgvHVTL.DataSource = HocVienTheoLopDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
                btnHVTLMoi.Focus();
            }


            
        }

    
    }
}

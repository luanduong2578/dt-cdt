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
    public partial class fDMChamCong : Form
    {
        public fDMChamCong()
        {
            InitializeComponent();
            LoadDMChamCong();
            LoadButton();
        }
        void LoadDMChamCong()
        {
            dtgvDMChamCong.DataSource = DMChamCongDAO.Instance.LoadDMChamCong();
        }

        private void dtgvChucDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvDMChamCong.Rows[e.RowIndex];
                txbid.Text = row.Cells[0].Value.ToString();
                txbTen.Text = row.Cells[1].Value.ToString();
                txbKyHieu.Text = row.Cells[2].Value.ToString();
                txbSoNgayCong.Text = row.Cells[3].Value.ToString();
                txbSoTietHoc.Text = row.Cells[4].Value.ToString();
                txbGhiChu.Text = row.Cells[5].Value.ToString();
            }

        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void LoadButton()
        {

            txbTen.Enabled = false;
            txbKyHieu.Enabled = false;
            txbSoTietHoc.Enabled = false;
            txbSoNgayCong.Enabled = false;
            txbGhiChu.Enabled = false;
            btnMoi.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnXoa.Enabled = true;
            btnKetthuc.Enabled = true;


        }
        void ButtonSua()
        {

            txbTen.Enabled = true;
            txbKyHieu.Enabled = true;
            txbSoTietHoc.Enabled = true;
            txbSoNgayCong.Enabled = true;
            txbGhiChu.Enabled = true;
            btnMoi.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnBoQua.Enabled = true;
            btnXoa.Enabled = false;
            btnKetthuc.Enabled = false;
        }
        void ButtonMoi()
        {
            txbTen.Enabled = true;
            txbKyHieu.Enabled = true;
            txbSoTietHoc.Enabled = true;
            txbSoNgayCong.Enabled = true;
            txbGhiChu.Enabled = true;
            btnMoi.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnBoQua.Enabled = true;
            btnXoa.Enabled = false;
            btnKetthuc.Enabled = false;

        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            ButtonMoi();
            txbTen.Text = "";
            txbKyHieu.Text = "";
            txbSoNgayCong.Text = "";
            txbSoTietHoc.Text = "";
            txbGhiChu.Text = "";
            txbTen.Focus();


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ButtonSua();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            LoadButton();
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            string DMCDTEN = DataProvider.Instance.FormatStringInput(txbTen.Text);
            string DMCDVIETTAT = DataProvider.Instance.FormatStringInput(txbKyHieu.Text);
            int SONGAYCONG = Convert.ToInt32(txbSoNgayCong.Text);
            int SOTIETHOC = Convert.ToInt32(txbSoTietHoc.Text);
            string GHICHU = DataProvider.Instance.FormatStringInput(txbGhiChu.Text);

            if (txbid.Text == "")
            {
                DMChamCongDAO.Instance.InsertDMChamCong(DMCDTEN,DMCDVIETTAT,SONGAYCONG,SOTIETHOC,GHICHU);
                txbid.Text = "";
                LoadDMChamCong();
                LoadButton();

            }
            else
            {
                int DMCDID = Convert.ToInt32(txbid.Text);
                DMChamCongDAO.Instance.UpdateDMChamCong(DMCDTEN,DMCDVIETTAT,SONGAYCONG,SOTIETHOC,GHICHU, DMCDID);
                LoadDMChamCong();
                LoadButton();
                txbid.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (int.TryParse(txbid.Text, out num))
            {
                if (ChucDanhDAO.Instance.Count_idChucDanhinHocVien(num) > 0)
                {
                    MessageBox.Show("Không được xóa.Chức danh đã được sử dụng trong danh sách Nhân viên _ Học viên", "Cảnh báo");
                }
                else
                {
                    DialogResult drXoa = MessageBox.Show("Xóa DM chấm công: " + txbTen.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                    if (drXoa == DialogResult.Yes)
                    {
                        ChucDanhDAO.Instance.DeleteChucDanh(num);
                        LoadDMChamCong();
                        LoadButton();
                        txbid.Text = "";
                    }
                }
            }
            else
            {
                LoadDMChamCong();
                LoadButton();
                txbid.Text = "";
            }
        }
    }
}

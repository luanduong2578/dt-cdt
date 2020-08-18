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
    public partial class fdmChucDanh : Form
    {
        public fdmChucDanh()
        {
            InitializeComponent();
            LoadChucDanh();
            LoadButton();
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadChucDanh()
        {
            dtgvChucDanh.DataSource = ChucDanhDAO.Instance.LoadChucDanh();
        }

        private void dtgvChucDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvChucDanh.Rows[e.RowIndex];
                 txbChucDanhid.Text = row.Cells[0].Value.ToString();
                 txbChucDanhTen.Text  = row.Cells[1].Value.ToString();
                 txbChucDanhTenVietTat.Text = row.Cells[2].Value.ToString();
            }
        }

        void LoadButton()
        {

            txbChucDanhid.Enabled = false;
            txbChucDanhTen.Enabled = false;
            txbChucDanhTenVietTat.Enabled = false;
            btnMoi.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnXoa.Enabled = true;
            btnKetthuc.Enabled = true;


        }
        void ButtonSua()
        {

            txbChucDanhid.Enabled = false;
            txbChucDanhTen.Enabled = true;
            txbChucDanhTenVietTat.Enabled = true;
            btnMoi.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnBoQua.Enabled = true;
            btnXoa.Enabled = false;
            btnKetthuc.Enabled = false;
        }
        void ButtonMoi()
        {
            txbChucDanhid.Enabled = false;
            txbChucDanhTen.Enabled = true;
            txbChucDanhTenVietTat.Enabled = true;
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
            txbChucDanhid.Text= "";
            txbChucDanhTen.Text = "";
            txbChucDanhTen.Focus();
            txbChucDanhTenVietTat.Text = "";
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
            string CDTen = DataProvider.Instance.FormatStringInput(txbChucDanhTen.Text);
            string CDTenVT = DataProvider.Instance.FormatStringInput(txbChucDanhTenVietTat.Text);
            if (txbChucDanhid.Text == "")
            {
                ChucDanhDAO.Instance.InsertChucDanh(CDTen, CDTenVT);
                 LoadChucDanh();
                LoadButton();

            }
            else
            {
                int BVid = Convert.ToInt32(txbChucDanhid.Text);
                ChucDanhDAO.Instance.UpdateChucDanh(CDTen, CDTenVT, BVid);
                LoadChucDanh();
                LoadButton();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (int.TryParse(txbChucDanhid.Text, out num))
            {
                if (ChucDanhDAO.Instance.Count_idChucDanhinHocVien(num) > 0)
                {
                    MessageBox.Show("Không được xóa.Chức danh đã được sử dụng trong danh sách Nhân viên _ Học viên", "Cảnh báo");
                }
                else
                {
                    DialogResult drXoa = MessageBox.Show("Xóa chức danh: " + txbChucDanhTen.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                    if (drXoa == DialogResult.Yes)
                    {
                        ChucDanhDAO.Instance.DeleteChucDanh(num);
                        LoadChucDanh();
                        LoadButton();
                    }
                }
            }
            else
            {
                LoadChucDanh();
                LoadButton();
            }
        }


    }
}

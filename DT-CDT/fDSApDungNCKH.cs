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
    public partial class fDSApDungNCKH : Form
    {
        public fDSApDungNCKH()
        {
            InitializeComponent();
            LoadADKH();
            ButtonLoad();
            loadTuNam();
            loadDenNam();
            loadNamNC();
            LoadDSKhoaPhong();
            LoadNamNCKH(cbbTuNam);
            LoadNamNCKH(cbbDenNam);
            LoadNamNCKH(cbbNam);
        }
        void LoadNamNCKH(ComboBox cbbNamNC)
        {
            DateTime now = DateTime.Now;
            cbbNamNC.Text = NCKHDAO.Instance.LoadNamNCKH();
        }
        void LoadADKH()
        {

            int namNC = Convert.ToInt32(NCKHDAO.Instance.LoadNamNCKH());
            dtgvADKH.DataSource = ApDungNCKHDAO.Instance.LoadADNCKH(namNC);
        }
        
        void ButtonLoad()
        {
            cbbNam.Enabled = false;
            cbbKPAD.Enabled = false;
            txbNguonAD.Enabled = false;
            txbNoiDungAD.Enabled = false;
            dtpkBatDau.Enabled = false;
            dtpkKetThuc.Enabled = false;
            cbbTienDo.Enabled = false;
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
            cbbKPAD.Enabled = true;
            txbNguonAD.Enabled = true;
            txbNoiDungAD.Enabled = true;
            dtpkBatDau.Enabled = true;
            dtpkKetThuc.Enabled = true;
            cbbTienDo.Enabled = true;
            txbKetQua.Enabled = true;
            txbGhichu.Enabled = true;

            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVXoa.Enabled = false;
            btnBVBoQua.Enabled = true;
            btnBVKetthuc.Enabled = false;
            LoadNamNCKH(cbbNam);
            cbbKPAD.Text = "";
            txbNCKHMASO.Text = "";
            txbNguonAD.Text = "";
            txbNoiDungAD.Text = "";
            dtpkBatDau.Text = "";
            dtpkKetThuc.Text = "";
            cbbTienDo.Text = "";
            txbKetQua.Text = "";
            txbGhichu.Text = "";
            txbADKHID.Text = "";


        }
        void SuaButton()
        {
            cbbNam.Enabled = true;
            cbbKPAD.Enabled = true;
            txbNguonAD.Enabled = true;
            txbNoiDungAD.Enabled = true;
            dtpkBatDau.Enabled = true;
            dtpkKetThuc.Enabled = true;
            cbbTienDo.Enabled = true;
            txbKetQua.Enabled = true;
            txbGhichu.Enabled = true;

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
        void LoadDSKhoaPhong()
        {
            cbbKPAD.DataSource = KhoaPhongDAO.Instance.LoadListKhoaPhong();
            cbbKPAD.ValueMember = "KHOAPHONGID";
            cbbKPAD.DisplayMember = "KHOAPHONGTEN";
        }

        private void btnBVKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBVMoi_Click(object sender, EventArgs e)
        {
            MoiButton();
        }

        private void btnBVBoQua_Click(object sender, EventArgs e)
        {
            ButtonLoad();
        }

        private void dtgvADKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnBVMoi.Enabled == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dtgvADKH.Rows[e.RowIndex];
                    txbADKHMASO.Text = row.Cells[0].Value.ToString();
                    cbbNam.Text = row.Cells[1].Value.ToString();
                    cbbKPAD.Text = row.Cells[2].Value.ToString();
                    txbNoiDungAD.Text = row.Cells[3].Value.ToString();
                    txbNguonAD.Text = row.Cells[4].Value.ToString();
                    dtpkBatDau.Text = row.Cells[5].Value.ToString();
                    dtpkKetThuc.Text = row.Cells[6].Value.ToString();
                    cbbTienDo.Text = row.Cells[7].Value.ToString();
                    txbKetQua.Text = row.Cells[8].Value.ToString();
                    txbGhichu.Text = row.Cells[9].Value.ToString();
                    txbADKHID.Text = ApDungNCKHDAO.Instance.GetHCKIdByMAADKH(txbADKHMASO.Text).ToString();
                }
            }
        }

        void LoadNCKHbyTuNamDenNam(int tunam, int dennam)
        {
            dtgvADKH.DataSource = ApDungNCKHDAO.Instance.SearchADNCKHbyTuNamDenNam(tunam, dennam);
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dtgvADKH.DataSource =  ApDungNCKHDAO.Instance.SearchADNCKHbyNoiDungAD(Convert.ToInt32(cbbTuNam.Text), Convert.ToInt32(cbbDenNam.Text), txbSearch.Text);
        }

        private void txbSearch_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearch.Text = "";
        }

        private void btnBVSua_Click(object sender, EventArgs e)
        {
            SuaButton();
        }

        private void btnBVLuu_Click(object sender, EventArgs e)
        {
            if (cbbKPAD.Text == "")
            {
                cbbKPAD.Focus();
            }
            else
            {
                // int NCKHid = Convert.ToInt32(txbNCKHid.Text);
                int Nam = Convert.ToInt32(cbbNam.Text);
                int KhoaPhongAD = Convert.ToInt32(cbbKPAD.SelectedValue);
                string NoiDungAD = DataProvider.Instance.FormatStringInput(txbNoiDungAD.Text);
                string NguonAD = DataProvider.Instance.FormatStringInput(txbNguonAD.Text);
                string NgayBD = dtpkBatDau.Text;
                string NgayKT = dtpkKetThuc.Text;
                string TienDo = cbbTienDo.Text;
                string KetQua = txbKetQua.Text;
                string GhiChu = txbGhichu.Text;
                if (txbADKHID.Text == "")
                {
                    ApDungNCKHDAO.Instance.InsertADKH(Nam, NoiDungAD, NguonAD, KhoaPhongAD, NgayBD, NgayKT, TienDo, KetQua, GhiChu);
                    LoadADKH();
                    ButtonLoad();
                }
                else
                {
                    ApDungNCKHDAO.Instance.UpdateADKH(Nam, NoiDungAD, NguonAD, KhoaPhongAD, NgayBD, NgayKT, TienDo, KetQua, GhiChu, Convert.ToInt32(txbADKHID.Text));
                    LoadADKH();
                    ButtonLoad();
                }
            }
        }

        private void btnBVXoa_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(txbADKHID.Text, out num))
            {
                DialogResult drXoa = MessageBox.Show("Xóa áp dụng NCKH: " + txbNoiDungAD.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                if (drXoa == DialogResult.Yes)
                {
                    ApDungNCKHDAO.Instance.DeleteADKH(num);
                    LoadADKH();
                    ButtonLoad();
                }
            }

            else
            {
                LoadADKH();
                ButtonLoad();
            }
        }
    }
}

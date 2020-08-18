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
    public partial class fKhoaPhong : Form
    {
        public fKhoaPhong()
        {
            InitializeComponent();
            LoadKhoaPHong();
            LoadDSBenhVienToCombobox(ccbBenhVien);
            LoadButton();
        }

        private void btnKPKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadKhoaPHong()
        {
            dtgvKhoaPhong.DataSource = KhoaPhongDAO.Instance.LoadKhoaPhong();
        }
        void LoadDSBenhVienToCombobox(ComboBox cbb)
        {
            cbb.DataSource = KhoaPhongDAO.Instance.LoadListBenhVien();
            cbb.ValueMember = "DONVIID";
            cbb.DisplayMember = "DONVITEN";
        }

        private void dtgvKhoaPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvKhoaPhong.Rows[e.RowIndex];
                ccbBenhVien.Text = row.Cells[2].Value.ToString();
                txbKPid.Text =  row.Cells[0].Value.ToString();
                txbKPTen.Text = row.Cells[3].Value.ToString();
                txbKPTenVietTat.Text = row.Cells[4].Value.ToString();
            }
        }
        void LoadButton()
        {
            ccbBenhVien.Enabled = false;
            txbKPid.Enabled = false;
            txbKPTen.Enabled = false;
            txbKPTenVietTat.Enabled = false;
            btnKPMoi.Enabled = true;
            btnKPSua.Enabled = true;
            btnKPXoa.Enabled = true;
            btnKPBoQua.Enabled = false;
            btnKPLuu.Enabled = false;
            btnKPKetthuc.Enabled = true;
            
        }
        void MoiButton()
        {
            ccbBenhVien.Enabled = true;
            txbKPid.Enabled = false;
            txbKPTen.Enabled = true;
            txbKPTenVietTat.Enabled = true;
            btnKPMoi.Enabled = false;
            btnKPSua.Enabled = false;
            btnKPXoa.Enabled = false;
            btnKPBoQua.Enabled = true;
            btnKPLuu.Enabled = true;
            btnKPKetthuc.Enabled = false;

        }
        void SuaButton()
        {
            ccbBenhVien.Enabled = true;
            txbKPid.Enabled = false;
            txbKPTen.Enabled = true;
            txbKPTenVietTat.Enabled = true;
            btnKPMoi.Enabled = false;
            btnKPSua.Enabled = false;
            btnKPXoa.Enabled = false;
            btnKPBoQua.Enabled = true;
            btnKPLuu.Enabled = true;
            btnKPKetthuc.Enabled = false;

        }
        private void btnKPMoi_Click(object sender, EventArgs e)
        {
            MoiButton();
            txbKPid.Text = "";
            txbKPTen.Text = "";
            txbKPTenVietTat.Text = "";
        }

        private void btnKPSua_Click(object sender, EventArgs e)
        {
            SuaButton();
        }

        private void btnKPBoQua_Click(object sender, EventArgs e)
        {
            LoadButton();
        }

        private void btnKPLuu_Click(object sender, EventArgs e)
        {
            
            int BVid = Convert.ToInt32(ccbBenhVien.SelectedValue);
            string KPTen = DataProvider.Instance.FormatStringInput(txbKPTen.Text);
            string KPTenVT = DataProvider.Instance.FormatStringInput(txbKPTenVietTat.Text);
            if ( txbKPid.Text =="")
            {
                KhoaPhongDAO.Instance.InsertKhoaPhong(BVid, KPTen,KPTenVT);
                LoadKhoaPHong();
                LoadButton();
            }
            else
            {
                int KPid = Convert.ToInt32(txbKPid.Text);
                KhoaPhongDAO.Instance.UpdateKhoaPhong(BVid, KPTen, KPTenVT, KPid);
                LoadKhoaPHong();
                LoadButton();
            }
        }

        private void btnKPXoa_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (int.TryParse(txbKPid.Text, out num))
            {
                if (KhoaPhongDAO.Instance.Count_idKhoaPhong_in_HocVien(num)>0)
                {
                    MessageBox.Show("Không được xóa. Khoa phòng đã được sử dụng trong danh sách Học viên");
                }
                else if(KhoaPhongDAO.Instance.Count_idKhoaPhong_in_NCKH(num)>0)
                {
                    MessageBox.Show("Không được xóa. Khoa phòng đã được sử dụng trong danh sách NCKH");
                }
                else
                {
                    DialogResult drXoa = MessageBox.Show("Xóa Khoa phòng: " + txbKPTen.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                    if (drXoa == DialogResult.Yes)
                    {
                        KhoaPhongDAO.Instance.DeleteKhoaPHong(num);
                        LoadKhoaPHong();
                        LoadButton();
                    }
                }
            }
            else
            {
                LoadKhoaPHong();
                LoadButton();
            }
        }
    }
}

   
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
    public partial class fBenhVien : Form
    {
        public fBenhVien()
        {
            InitializeComponent();
            LoadBenhVien();
            //LoadBenhVienBinding();
            LoadButton();
            
        }

        
        #region methods
        void LoadBenhVien()
        {
            dtgvBenhVien.DataSource = BenhVienDAO.Instance.LoadBenhvien();
        }

        void LoadButton()
        {

            txbBVid.Enabled = false;
            txbBVTen.Enabled = false;
            txbBVTenVietTat.Enabled = false;
            btnBVMoi.Enabled = true;
            btnBVLuu.Enabled = false;
            btnBVSua.Enabled = true;
            btnBVBoQua.Enabled = false;
            btnBVXoa.Enabled = true;
            btnBVKetthuc.Enabled = true;
            
            
        }
        void ButtonSua()
        {
            txbBVid.Enabled = false;
            txbBVTen.Enabled = true;
            txbBVTenVietTat.Enabled = true;
            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVBoQua.Enabled = true;
            btnBVXoa.Enabled = false;
            btnBVKetthuc.Enabled = false;
        }
        void ButtonMoi()
        {
            txbBVid.Enabled = false;
            txbBVTen.Enabled = true;
            txbBVTenVietTat.Enabled = true;
            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVBoQua.Enabled = true;
            btnBVXoa.Enabled = false;
            btnBVKetthuc.Enabled = false;

        }

        //void LoadBenhVienBinding()
       // {
           
        //    txbBVid.DataBindings.Add("text", dtgvBenhVien.DataSource, "DonViid", true, DataSourceUpdateMode.Never);
        //    txbBVTen.DataBindings.Add("text", dtgvBenhVien.DataSource, "DonViTen", true, DataSourceUpdateMode.Never);
        //    txbBVTenVietTat.DataBindings.Add("text", dtgvBenhVien.DataSource, "DonViTenVietTat", true, DataSourceUpdateMode.Never);
        //}
        #endregion


        #region events
        private void btnBVLuu_Click(object sender, EventArgs e)
        {
            string BVTen = DataProvider.Instance.FormatStringInput(txbBVTen.Text);
            string BVTenVT = DataProvider.Instance.FormatStringInput(txbBVTenVietTat.Text);
            if (txbBVid.Text == "")
            {
                BenhVienDAO.Instance.InsertBenhVien(BVTen, BVTenVT);
                LoadBenhVien();
                LoadButton();
                btnBVMoi.Focus();

            }
            else
            {
                int BVid = Convert.ToInt32(txbBVid.Text);
                BenhVienDAO.Instance.UpdateBenhVien(BVTen, BVTenVT, BVid);
                LoadBenhVien();
                LoadButton();
            }
        }

        private void btnBVSua_Click(object sender, EventArgs e)
        {
            ButtonSua();

        }

        private void btnBVBoQua_Click(object sender, EventArgs e)
        {
            LoadBenhVien();
            LoadButton();
           
        }


        private void btnBVMoi_Click(object sender, EventArgs e)
        {
            ButtonMoi();
            txbBVid.Text = "";
            txbBVTen.Text = "";
            txbBVTenVietTat.Text = "";
        }


        private void btnBVKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dtgvBenhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvBenhVien.Rows[e.RowIndex];
                txbBVid.Text = row.Cells[0].Value.ToString();
                txbBVTen.Text = row.Cells[1].Value.ToString();
                txbBVTenVietTat.Text = row.Cells[2].Value.ToString();
            }
        }
        #endregion

        private void btnBVXoa_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (int.TryParse(txbBVid.Text, out num))
            {
                if (BenhVienDAO.Instance.Count_idDonVi_in_KHoaPhong(num) > 0)
                {
                    MessageBox.Show("Không được xóa.Bệnh viện đã được sử dụng trong danh sách Khoa phòng", "Cảnh báo");
                }
                else if (BenhVienDAO.Instance.Count_idDonVi_in_HocVien(num) > 0)
                {
                    MessageBox.Show("Không được xóa.Bệnh viện đã được sử dụng trong danh sách Nhân viên _ Học viên", "Cảnh báo");
                }
                else
                {
                    DialogResult drXoa = MessageBox.Show("Xóa Bệnh viện: " + txbBVTen.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                    if (drXoa == DialogResult.Yes)
                    {
                        BenhVienDAO.Instance.DeleteDonVi(num);
                        LoadBenhVien();
                        LoadButton();
                    }
                }
            }
            else
            {
                LoadBenhVien();
                LoadButton();
            }

        }

        private void txbSeachBenhVien_TextChanged(object sender, EventArgs e)
        {
            LoadBenhVienbyTen(txbSeachBenhVien.Text);
        }
        void LoadBenhVienbyTen(string tenbv)
        {
            dtgvBenhVien.DataSource = BenhVienDAO.Instance.LoadBenhvienbyTenBV(tenbv);
        }

        private void txbSeachBenhVien_MouseUp(object sender, MouseEventArgs e)
        {
            txbSeachBenhVien.Text = "";
        }

       
    }
}

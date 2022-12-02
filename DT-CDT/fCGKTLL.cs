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
    public partial class fCGKTLL : Form
    {
        public fCGKTLL()
        {
            InitializeComponent();
            loadHVandKPanDVCT();
            Load_GOI_CGKT();
            loadHTuNam();
            loadDenNam();
            loadHCKNAMDT();
            load_DV_NHAN_CGKT();
            LoadNamHCK(cbbSearchTuNam);
            LoadNamHCK(cbbSearchDenNam);
            LoadNamHCK(ccbCGKTNAM);
            loadKPAndDV();
            loadButton();

        }

           void loadKPAndDV()
        {
            cbbIDKHOAPHONGCGKT.DataSource = KhoaPhongDAO.Instance.loadKPandKPanBV();
            cbbIDKHOAPHONGCGKT.ValueMember = "KhoaPhongid";
            cbbIDKHOAPHONGCGKT.DisplayMember = "KHOA_PHONG_DAO_TAO";
        }


        void loadButton()
        {
            ccbCGKTNAM.Enabled = false;
            txbCGKTTENGOI.Enabled = false;
            cbbIDDONVICT.Enabled = false;
            mktxbHCKBatDau.Enabled = false;
            mktxbHCKKetThuc.Enabled = false;
            cbbIDKHOAPHONGCGKT.Enabled = false;
            cbbIDCBDMCGKT.Enabled = false;
            txbHCKPhai.Enabled = false;
            txbHCKNgaySinh.Enabled = false;
            txbChucDanh.Enabled = false;
            txbHCKDVCT.Enabled = false;
            txbKhoaPhong.Enabled = false;
            txbHCKGhichu.Enabled = false;
            txbCGKTID.Enabled = false;
//            txbCGKTID.Visible = false;
            txbCGKTMASO.Visible = false;

            btnBVMoi.Enabled = true;
            btnBVLuu.Enabled = false;
            btnBVSua.Enabled = true;
            btnBVXoa.Enabled = true;
            btnBVKetthuc.Enabled = true;
            btnBVBoQua.Enabled = false;
            btnBVMoi.Focus();
        }

        void loadMoi()
        {
            ccbCGKTNAM.Enabled = true ;
            txbCGKTTENGOI.Enabled = true;
            cbbIDDONVICT.Enabled = true;
            mktxbHCKBatDau.Enabled = true;
            mktxbHCKKetThuc.Enabled = true;
            cbbIDKHOAPHONGCGKT.Enabled = true;
            cbbIDCBDMCGKT.Enabled = true;
            txbHCKPhai.Enabled = false;
            txbHCKNgaySinh.Enabled = false;
            txbChucDanh.Enabled = false;
            txbHCKDVCT.Enabled = false;
            txbKhoaPhong.Enabled = false;
            txbHCKGhichu.Enabled = true;
            txbCGKTID.Enabled = false;
//            txbCGKTID.Visible = false;
            txbCGKTMASO.Visible = false;

            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVXoa.Enabled = false;
            btnBVKetthuc.Enabled = false;
            btnBVBoQua.Enabled = true;

            LoadNamHCK(ccbCGKTNAM);
            txbCGKTTENGOI.Text = "";
            cbbIDDONVICT.Text = "";
            cbbIDCBDMCGKT.Text = "";
            txbHCKGhichu.Text = "";
            txbCGKTTENGOI.Focus();
            txbCGKTID.Text = "";
            cbbIDKHOAPHONGCGKT.Text = "";
        }
        void loadSua()
        {
            ccbCGKTNAM.Enabled = true;
            txbCGKTTENGOI.Enabled = true;
            cbbIDDONVICT.Enabled = true;
            mktxbHCKBatDau.Enabled = true;
            mktxbHCKKetThuc.Enabled = true;
            cbbIDCBDMCGKT.Enabled = true;
            txbHCKPhai.Enabled = false;
            txbHCKNgaySinh.Enabled = false;
            txbChucDanh.Enabled = false;
            txbHCKDVCT.Enabled = false;
            txbKhoaPhong.Enabled = false;
            txbHCKGhichu.Enabled = true;
            txbCGKTID.Enabled = false;
            cbbIDKHOAPHONGCGKT.Enabled = true;
            txbCGKTMASO.Visible = false;

            btnBVMoi.Enabled = false;
            btnBVLuu.Enabled = true;
            btnBVSua.Enabled = false;
            btnBVXoa.Enabled = false;
            btnBVKetthuc.Enabled = false;
            btnBVBoQua.Enabled = true;

            txbCGKTTENGOI.Focus();
        }
        void loadHVandKPanDVCT()
        {
            cbbIDCBDMCGKT.DataSource = HocVienDAO.Instance.LoadListHVbyID();
            cbbIDCBDMCGKT.ValueMember = "HOCVIENID";
            cbbIDCBDMCGKT.DisplayMember = "HOC_VIEN";
        }
        void load_DV_NHAN_CGKT()
        {
            cbbIDDONVICT.DataSource = BenhVienDAO.Instance.LoadListBenhVien();
            cbbIDDONVICT.ValueMember = "DONVIID";
            cbbIDDONVICT.DisplayMember = "DONVITEN";
        }
        void loadHCKNAMDT()
        {
            ccbCGKTNAM.DataSource = NamNCDAO.Instance.LoadListNamNC();
            ccbCGKTNAM.ValueMember = "NAMID";
            ccbCGKTNAM.DisplayMember = "NAMTEN";
        }
        void LoadNamHCK(ComboBox cbb)
        {
            cbb.Text = HocChuyenKhoaDAO.Instance.LoadNamHienTai();
        }
        void Load_GOI_CGKT()
        {

            int namHienTai = Convert.ToInt32(CGKTLLDAO.Instance.LoadNamHienTai());
            dtgvCGKT.DataSource = CGKTLLDAO.Instance.Load_Goi_CGKT(namHienTai);
        }

        void loadHTuNam()
        {
            cbbSearchTuNam.DataSource = NamNCDAO.Instance.LoadListNamNC();
            cbbSearchTuNam.ValueMember = "NAMID";
            cbbSearchTuNam.DisplayMember = "NAMTEN";
        }

        void loadDenNam()
        {
            cbbSearchDenNam.DataSource = NamNCDAO.Instance.LoadListNamNC();
            cbbSearchDenNam.ValueMember = "NAMID";
            cbbSearchDenNam.DisplayMember = "NAMTEN";
        }
        
        private void btnBVKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimND_Click(object sender, EventArgs e)
        {
            dtgvCGKT.DataSource = CGKTLLDAO.Instance.Search_Goi_CGKT_TuNamDenNam(Convert.ToInt32(cbbSearchTuNam.Text), Convert.ToInt32(cbbSearchDenNam.Text));

        }

        private void txbSearchND_TextChanged(object sender, EventArgs e)
        {
            dtgvCGKT.DataSource = CGKTLLDAO.Instance.Search_Goi_CGKT_TuNamDenNam_TenGoi(Convert.ToInt32(cbbSearchTuNam.Text), Convert.ToInt32(cbbSearchDenNam.Text), txbSearchND.Text);
        }

        private void cbbIDCBDMCGKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txbHCKPhai.Text = HocVienDAO.Instance.GetPhaibyHocVienID(Convert.ToInt32(cbbIDCBDMCGKT.SelectedValue));
                txbHCKNgaySinh.Text = HocVienDAO.Instance.GetNgaySinhbyHocVienID(Convert.ToInt32(cbbIDCBDMCGKT.SelectedValue));
                txbChucDanh.Text = HocVienDAO.Instance.GetChucDanhbyHocVienID(Convert.ToInt32(cbbIDCBDMCGKT.SelectedValue));
                txbHCKDVCT.Text = HocVienDAO.Instance.GetDVCTbyHocVienID(Convert.ToInt32(cbbIDCBDMCGKT.SelectedValue));
                txbKhoaPhong.Text = HocVienDAO.Instance.GetKhoaPhongbyHocVienID(Convert.ToInt32(cbbIDCBDMCGKT.SelectedValue));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnBVMoi_Click(object sender, EventArgs e)
        {
            loadMoi();
        }

        private void btnBVBoQua_Click(object sender, EventArgs e)
        {
            loadButton();            
        }

        private void btnBVXoa_Click(object sender, EventArgs e)
        {

            int id = 0;
            if (int.TryParse(txbCGKTID.Text, out id))
            {
                if (CGKTLLDAO.Instance.Count_GOI_CGKT_In_CGKTCT(id))
                {
                    MessageBox.Show("Không được xóa. Đã cập nhật chi tiết gói kỹ thuật", "Cảnh báo");
                }
                else
                {
                    DialogResult drXoa = MessageBox.Show("Xóa gói CGKT: " + txbCGKTTENGOI.Text, "Cảnh báo", MessageBoxButtons.YesNo);
                    if (drXoa == DialogResult.Yes)
                    {
                        CGKTLLDAO.Instance.DeleteCGKT(Convert.ToInt32(txbCGKTID.Text));
                        loadButton();
                        btnBVMoi.Focus();
                    }
                    else
                    {
                        loadButton();
                        btnBVMoi.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("Chọn gói kỹ thuật", "Cảnh báo");
            }
        }

        private void btnBVSua_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(txbCGKTID.Text, out id))
            {
                loadSua();
            }
            else
            {
                MessageBox.Show("Chọn gói kỹ thuật", "Cảnh báo");
            }

        }

        private void btnBVLuu_Click(object sender, EventArgs e)
        {
            try
           {
                if (txbCGKTTENGOI.Text == "")
                {
                    txbCGKTTENGOI.Focus();
                }
                else if (Convert.ToInt32(cbbIDDONVICT.SelectedValue) == 0)
                {
                    cbbIDDONVICT.Focus();
                }
                else if (Convert.ToInt32(cbbIDCBDMCGKT.SelectedValue) == 0)
                {
                    cbbIDCBDMCGKT.Focus();
                }
                else if(Convert.ToInt32(cbbIDKHOAPHONGCGKT.SelectedValue) ==0)
                {
                    cbbIDKHOAPHONGCGKT.Focus();
                }
                else
                {

                    int CGKTNAM = Convert.ToInt32(ccbCGKTNAM.Text);
                    // string CGKTMASO;         CGKT +  000 + CGKTID
                    string CGKTTENGOI = DataProvider.Instance.FormatStringInput(txbCGKTTENGOI.Text);
                    int IDDVNHANCGKTLL = Convert.ToInt32(cbbIDDONVICT.SelectedValue);
                    string CGKTBATDAU = mktxbHCKBatDau.Text;
                    string CGKTKETTHUC = mktxbHCKKetThuc.Text;
                    int IDKHOAPHONGCGKT = Convert.ToInt32(cbbIDKHOAPHONGCGKT.SelectedValue);
                    int IDCBDMCGKT = Convert.ToInt32(cbbIDCBDMCGKT.SelectedValue);
                    string GHICHU = DataProvider.Instance.FormatStringInput(txbHCKGhichu.Text);
                    //UPD  = sysdate   
                    if (txbCGKTID.Text == "")
                    {
                        CGKTLLDAO.Instance.InsertCGKT(CGKTNAM, CGKTTENGOI, IDDVNHANCGKTLL, CGKTBATDAU, CGKTKETTHUC, IDKHOAPHONGCGKT, IDCBDMCGKT, GHICHU);
                        Load_GOI_CGKT();
                        loadButton();
                        btnBVMoi.Focus();
                    }
                    else
                    {
                        int ID = Convert.ToInt32(txbCGKTID.Text);
                        CGKTLLDAO.Instance.UpdateCGKT(CGKTNAM, CGKTTENGOI, IDDVNHANCGKTLL, CGKTBATDAU, CGKTKETTHUC, IDKHOAPHONGCGKT,IDCBDMCGKT, GHICHU, ID);
                        Load_GOI_CGKT();
                        loadButton();
                        btnBVMoi.Focus();
                    }
                }
         }
          catch(Exception ex)
          {
              MessageBox.Show(ex.ToString());
            }
        
        }

        private void dtgvCGKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvCGKT.Rows[e.RowIndex];
                txbCGKTMASO.Text = row.Cells[0].Value.ToString();
                ccbCGKTNAM.Text = row.Cells[1].Value.ToString();
                txbCGKTTENGOI.Text = row.Cells[2].Value.ToString();
                cbbIDDONVICT.Text = row.Cells[3].Value.ToString();
                mktxbHCKBatDau.Value = Convert.ToDateTime(row.Cells[4].Value);
                mktxbHCKKetThuc.Value= Convert.ToDateTime(row.Cells[5].Value);
                cbbIDKHOAPHONGCGKT.Text = row.Cells[6].Value.ToString();
                cbbIDCBDMCGKT.Text = row.Cells[7].Value.ToString();
                txbHCKPhai.Text = row.Cells[8].Value.ToString();
                txbHCKNgaySinh.Text = row.Cells[9].Value.ToString();
                txbChucDanh.Text = row.Cells[10].Value.ToString();
                txbHCKDVCT.Text = row.Cells[11].Value.ToString();
                txbKhoaPhong.Text = row.Cells[12].Value.ToString();
                txbCGKTID.Text = CGKTLLDAO.Instance.getID_By_CGKTMASO(txbCGKTMASO.Text).ToString();

            }
        }

        private void txbSearchND_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearchND.Text = "";
        }
    }
}

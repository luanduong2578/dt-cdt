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
    public partial class fDSHocVienSHKH : Form
    {
        public fDSHocVienSHKH()
        {

            InitializeComponent();
            LoadGoiCGKT();
            LoadDSHVtoDtgvHVTL();
            loadListNam(cbbSearchHVTLTuNam);
            loadListNam(cbbSearchHVTLLHDenNam);
            LoadNamHienTai(cbbSearchHVTLTuNam);
            LoadNamHienTai(cbbSearchHVTLLHDenNam);
            LoadLHtoDtgvLH();
            loadHVandKPanDVCT();
            ButtonLoad();
            LoadCNDAOTAO();
        }
        void ButtonLoad()
        {

            txbLopMaLop.Enabled = false;
            txbTenLop.Enabled = false;
            txbLopTongsoTiet.Enabled = false;
            txbLT.Enabled = false;
            txbTH.Enabled = false;
            cbbHVHoTen.Enabled = false;
            txbHVPhai.Enabled = false;
            txbHVNS.Enabled = false;
            txbDV.Enabled = false;
            txbKP.Enabled = false;
            txbSoTietHoc.Enabled = false;
            txbSoTietNghi.Enabled = false;
            cbbGoiCGKT.Enabled = false;
            cbbLoaiCN.Enabled = false;
            txbSoCN.Enabled = false;
            txbGhichu.Enabled = false;
            txbLopID.Visible = false;
            txbLopLoaiCN.Visible = false;
            txbIDHV.Visible = false;

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
            txbLopMaLop.Enabled = false;
            txbTenLop.Enabled = false;
            txbLopTongsoTiet.Enabled = false;
            txbLT.Enabled = false;
            txbTH.Enabled = false;
            cbbHVHoTen.Enabled = true;
            txbHVPhai.Enabled = false;
            txbHVNS.Enabled = false;
            txbDV.Enabled = false;
            txbKP.Enabled = false;
            txbSoTietHoc.Enabled = true;
            txbSoTietNghi.Enabled = true;
            cbbGoiCGKT.Enabled = true;
            cbbGoiCGKT.Text = "";
            cbbLoaiCN.Enabled = true;
            txbSoCN.Enabled = false;
            txbGhichu.Enabled = false;
            txbLopID.Visible = false;
            txbLopLoaiCN.Visible = false;
            txbIDHV.Visible = false;



            cbbLoaiCN.Text = txbLopLoaiCN.Text;
            btnHVTLMoi.Enabled = false;
            btnHVTLLuu.Enabled = true;
            btnHVTLSua.Enabled = false;
            btnHVTLXoa.Enabled = false;
            btnHVTLBoQua.Enabled = true;
            btnHVTLKetthuc.Enabled = false;

            cbbHVHoTen.Focus();
            txbIDHV.Text = "";
            cbbHVHoTen.Text = "";
            txbSoTietHoc.Text = txbLopTongsoTiet.Text;
            txbSoTietNghi.Text = "0";
            cbbGoiCGKT.Text = "";
            txbGhichu.Text = "";
        }

        void ButtonSua()
        {
            txbLopMaLop.Enabled = false;
            txbTenLop.Enabled = false;
            txbLopTongsoTiet.Enabled = false;
            txbLT.Enabled = false;
            txbTH.Enabled = false;
            cbbHVHoTen.Enabled = true;
            txbHVPhai.Enabled = false;
            txbHVNS.Enabled = false;
            txbDV.Enabled = false;
            txbKP.Enabled = false;
            txbSoTietHoc.Enabled = true;
            txbSoTietNghi.Enabled = true;
            cbbGoiCGKT.Enabled = true;
            cbbLoaiCN.Enabled = true;
            txbSoCN.Enabled = false;
            txbGhichu.Enabled = false;
            txbLopID.Visible = false;
            txbLopLoaiCN.Visible = false;
            txbIDHV.Visible = false;

            btnHVTLMoi.Enabled = false;
            btnHVTLLuu.Enabled = true;
            btnHVTLSua.Enabled = false;
            btnHVTLXoa.Enabled = false;
            btnHVTLBoQua.Enabled = true;
            btnHVTLKetthuc.Enabled = false;
            cbbHVHoTen.Focus();
        }
        void LoadGoiCGKT()
        {
            cbbGoiCGKT.DataSource = CGKTLLDAO.Instance.LoadListCGKT();
            cbbGoiCGKT.ValueMember = "CGKTID";
            cbbGoiCGKT.DisplayMember = "CGKTTENGOI";
        }
        void LoadCNDAOTAO()
        {
            cbbLoaiCN.DataSource = LoaiCNDTDAO.Instance.LoadListCNDAOTAO();
            cbbLoaiCN.ValueMember = "CNDTID";
            cbbLoaiCN.DisplayMember = "CNDTTEN";
        }
        void LoadNamHienTai(ComboBox cbb)
        {
            //DateTime now = DateTime.Now;
            cbb.Text = DSLopSKHKDAO.Instance.LoadNamHienTai();
        }
        void loadListNam(ComboBox ccb)
        {
            ccb.DataSource = NamNCDAO.Instance.LoadListNamNC();
            ccb.ValueMember = "NAMID";
            ccb.DisplayMember = "NAMTEN";
        }
        void LoadDSHVtoDtgvHVTL()
        {

            int namHienTai = Convert.ToInt32(DSLopSKHKDAO.Instance.LoadNamHienTai());
            dtgvHVTL.DataSource = DSHocVienSHKHDAO.Instance.LoadDSLop(namHienTai);
        }

        void LoadLHtoDtgvLH()
        {

            int namHienTai = Convert.ToInt32(DSLopSKHKDAO.Instance.LoadNamHienTai());
            dtgvLop.DataSource = DSLopSKHKDAO.Instance.LoadLopHoc(namHienTai);
        }

        private void btnHVTLTim_Click(object sender, EventArgs e)
        {
            dtgvLop.DataSource = DSLopSKHKDAO.Instance.SearchLHbyTuNamDenNam(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text));
        }

        private void btntimHVTLGV_Click(object sender, EventArgs e)
        {
            dtgvHVTL.DataSource = DSHocVienSHKHDAO.Instance.SearchDSHVbyTuNamDenNam(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text));
        }


        private void txbSearchHVTLLop_TextChanged(object sender, EventArgs e)
        {
            dtgvLop.DataSource = DSLopSKHKDAO.Instance.SearchLHbyTenLop(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text), txbSearchHVTLLop.Text);
        }
        private void txbSearchHVTLHV_TextChanged(object sender, EventArgs e)
        {
            dtgvHVTL.DataSource = DSHocVienSHKHDAO.Instance.SearchDSHVbyHV(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text), txbSearchHVTLHV.Text);
        }




        private void dtgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnHVTLMoi.Enabled == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dtgvLop.Rows[e.RowIndex];
                    txbLopMaLop.Text = row.Cells[0].Value.ToString();
                    txbTenLop.Text = row.Cells[2].Value.ToString();
                    txbLopTongsoTiet.Text = row.Cells[13].Value.ToString();
                    txbLT.Text = row.Cells[14].Value.ToString();
                    txbTH.Text = row.Cells[15].Value.ToString();
                    txbLopLoaiCN.Text = row.Cells[16].Value.ToString();

                    txbLopID.Text = DSLopSKHKDAO.Instance.getIdByMALOP(txbLopMaLop.Text).ToString();
                    dtgvHVTL.DataSource = DSHocVienSHKHDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
                    txbDTTLID.Text = "";
                    txbIDHV.Text = "";
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
            try
            {
                txbHVPhai.Text = HocVienDAO.Instance.GetPhaibyHocVienID(Convert.ToInt32(cbbHVHoTen.SelectedValue));
                txbHVNS.Text = HocVienDAO.Instance.GetNgaySinhbyHocVienID(Convert.ToInt32(cbbHVHoTen.SelectedValue));
                txbCD.Text = HocVienDAO.Instance.GetChucDanhbyHocVienID(Convert.ToInt32(cbbHVHoTen.SelectedValue));
                txbDV.Text = HocVienDAO.Instance.GetDVCTbyHocVienID(Convert.ToInt32(cbbHVHoTen.SelectedValue));
                txbKP.Text = HocVienDAO.Instance.GetKhoaPhongbyHocVienID(Convert.ToInt32(cbbHVHoTen.SelectedValue));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        void loadHVandKPanDVCT()
        {
            cbbHVHoTen.DataSource = HocVienDAO.Instance.LoadListHVbyID();
            cbbHVHoTen.ValueMember = "HOCVIENID";
            cbbHVHoTen.DisplayMember = "HOC_VIEN";
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
                    txbIDHV.Text = row.Cells[0].Value.ToString();
                    cbbHVHoTen.Text = row.Cells[1].Value.ToString();
                    txbHVPhai.Text = row.Cells[2].Value.ToString();
                    txbHVNS.Text = row.Cells[3].Value.ToString();
                    txbCD.Text = row.Cells[4].Value.ToString();
                    txbDV.Text = row.Cells[5].Value.ToString();
                    txbKP.Text = row.Cells[6].Value.ToString();
                    txbLopMaLop.Text = row.Cells[7].Value.ToString();
                    txbTenLop.Text = row.Cells[8].Value.ToString();
                    txbSoTietHoc.Text = row.Cells[9].Value.ToString();
                    txbSoTietNghi.Text = row.Cells[10].Value.ToString();
                    cbbGoiCGKT.Text = row.Cells[11].Value.ToString();
                    cbbLoaiCN.Text = row.Cells[12].Value.ToString();
                    txbGhichu.Text = row.Cells[13].Value.ToString();
                    txbSoCN.Text = CapChungNhanDAO.Instance.LoadSoCCNDT(DSLopSKHKDAO.Instance.getIdByMALOP(txbLopMaLop.Text), Convert.ToInt32(txbIDHV.Text));
                    txbDTTLID.Text = DSHocVienSHKHDAO.Instance.get_HVDTTLID_By_IDHV_IDLOP(Convert.ToInt32(txbIDHV.Text), DSLopSKHKDAO.Instance.getIdByMALOP(txbLopMaLop.Text));
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
            else if (txbIDHV.Text == "")
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
            try
            {
                if (Convert.ToInt32(cbbHVHoTen.SelectedValue) == 0)
                {
                    MessageBox.Show("Học viên không hợp lệ", "Cảnh báo");
                    cbbHVHoTen.Focus();
                }
                else
                {
                    //              int DTid = Convert.ToInt32(txbHVTLID.Text);

                    int IDHOCVIEN = Convert.ToInt32(cbbHVHoTen.SelectedValue);
                    int IDLOPHOC = Convert.ToInt32(txbLopID.Text);
                    int SOTIETHOC = Convert.ToInt32(txbSoTietHoc.Text);
                    int SOTIETNGHI = Convert.ToInt32(txbSoTietNghi.Text);
                    string GOICHUYENGIAOKT = DataProvider.Instance.FormatStringInput(cbbGoiCGKT.Text);
                    string Ghichu = txbGhichu.Text;
                    int IDLOAICN = Convert.ToInt32(cbbLoaiCN.SelectedValue);
                    string GHICHU = DataProvider.Instance.FormatStringInput(txbGhichu.Text);
                    bool LuuCheck = false;
                    if (DSHocVienSHKHDAO.Instance.count_HV_by_IDHV_IDLOP(IDHOCVIEN, IDLOPHOC) > 0)
                    {
                        MessageBox.Show("Học viên: " + cbbHVHoTen.Text + " đã tồn tại", "Cảnh báo");
                    }
                    else
                    {
                        if (txbIDHV.Text == "")
                        {
                            LuuCheck = DSHocVienSHKHDAO.Instance.InsertHVTL(IDHOCVIEN, IDLOPHOC, SOTIETHOC, SOTIETNGHI, GOICHUYENGIAOKT, IDLOAICN, GHICHU);
                            if (LuuCheck)
                            {
                                ButtonLoad();
                                dtgvHVTL.DataSource = DSHocVienSHKHDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
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
                            int HVDTTLID = Convert.ToInt32(txbIDHV.Text);

                            LuuCheck = DSHocVienSHKHDAO.Instance.UpdateHVTL(IDHOCVIEN, IDLOPHOC, SOTIETHOC, SOTIETNGHI, GOICHUYENGIAOKT, IDLOAICN, GHICHU, HVDTTLID);
                            if (LuuCheck)
                            {
                                ButtonLoad();
                                dtgvHVTL.DataSource = DSHocVienSHKHDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
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
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHVTLXoa_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (int.TryParse(txbDTTLID.Text, out num)) 
            {
                DialogResult drXoa = MessageBox.Show("Xoa học viên: " + cbbHVHoTen.Text + " - Lớp: " + txbTenLop.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                if (drXoa == DialogResult.Yes)
                {
                    DSHocVienSHKHDAO.Instance.DeleteHVTL(num);

                    ButtonLoad();

                    btnHVTLMoi.Focus();
                    if (txbLopID.Text == "")
                    {
                        LoadDSHVtoDtgvHVTL();
                    }
                    else
                    {
                        dtgvHVTL.DataSource = DSHocVienSHKHDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
                    }
                }
            }
            else
            {
                ButtonLoad();
                dtgvHVTL.DataSource = DSHocVienSHKHDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
                btnHVTLMoi.Focus();
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            fDSLopSHKH f = new fDSLopSHKH();
            f.ShowDialog();
        }

        private void txbSoTietHoc_Leave(object sender, EventArgs e)
        {
            int tongsotiet = 0;
            int sotiethoc = 0;
            if (int.TryParse(txbLopTongsoTiet.Text, out tongsotiet))
            {
                if (int.TryParse(txbSoTietHoc.Text, out sotiethoc))
                {
                    txbSoTietNghi.Text = (tongsotiet - sotiethoc).ToString();
                }
                else
                {
                    txbSoTietHoc.Text = "0";
                    txbSoTietNghi.Text = "0";
                }
            }
            else
            {
                txbSoTietHoc.Text = "0";
                txbSoTietNghi.Text = "0";
            }
        }
    }
}

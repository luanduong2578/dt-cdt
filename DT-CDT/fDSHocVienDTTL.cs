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
    public partial class fDSHocVienDTTL : Form
    {
        public fDSHocVienDTTL()
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
//            txbLopID.Visible = false;
//            txbLopLoaiCN.Visible = false;
 //           txbIDHV.Visible = false;

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
//            txbLopID.Visible = false;
 //           txbLopLoaiCN.Visible = false;
 //           txbIDHV.Visible = false;



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
            cbbHVHoTen.Enabled = false;
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
//            txbLopID.Visible = false;
//            txbLopLoaiCN.Visible = false;
//            txbIDHV.Visible = false;

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
            cbb.Text = DSLopDTTLDAO.Instance.LoadNamHienTai();
        }
        void loadListNam(ComboBox ccb)
        {
            ccb.DataSource = NamNCDAO.Instance.LoadListNamNC();
            ccb.ValueMember = "NAMID";
            ccb.DisplayMember = "NAMTEN";
        }
        void LoadDSHVtoDtgvHVTL()
        {

            int namHienTai = Convert.ToInt32(DSLopDTTLDAO.Instance.LoadNamHienTai());
            dtgvHVTL.DataSource = DSHocVienDTTLDAO.Instance.LoadDSLop(namHienTai);
        }

        void LoadLHtoDtgvLH()
        {

            int namHienTai = Convert.ToInt32(DSLopDTTLDAO.Instance.LoadNamHienTai());
            dtgvLop.DataSource = DSLopDTTLDAO.Instance.LoadLopHoc(namHienTai);
        }

        private void btnHVTLTim_Click(object sender, EventArgs e)
        {
            dtgvLop.DataSource = DSLopDTTLDAO.Instance.SearchLHbyTuNamDenNam(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text));
        }

        private void btntimHVTLGV_Click(object sender, EventArgs e)
        {
            dtgvHVTL.DataSource = DSHocVienDTTLDAO.Instance.SearchDSHVbyTuNamDenNam(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text));
        }


        private void txbSearchHVTLLop_TextChanged(object sender, EventArgs e)
        {
            dtgvLop.DataSource = DSLopDTTLDAO.Instance.SearchLHbyTenLop(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text), txbSearchHVTLLop.Text);
        }
        private void txbSearchHVTLHV_TextChanged(object sender, EventArgs e)
        {
            dtgvHVTL.DataSource = DSHocVienDTTLDAO.Instance.SearchDSHVbyHV(Convert.ToInt32(cbbSearchHVTLTuNam.Text), Convert.ToInt32(cbbSearchHVTLLHDenNam.Text), txbSearchHVTLHV.Text);
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
                    txbThoigianbatdau.Text = row.Cells[11].Value.ToString();
                    txbThoigianketthuc.Text = row.Cells[12].Value.ToString();
                    txbKHOAPHONG.Text = row.Cells[23].Value.ToString();
                    txbLopID.Text = DSLopDTTLDAO.Instance.getIdByMALOP(txbLopMaLop.Text).ToString() ;
                    dtgvHVTL.DataSource = DSHocVienDTTLDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
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

                    txbSoCN.Text = CapChungNhanDAO.Instance.LoadSoCCNDT(DSLopDTTLDAO.Instance.getIdByMALOP(txbLopMaLop.Text), Convert.ToInt32(txbIDHV.Text));
                    txbDTTLID.Text = DSHocVienDTTLDAO.Instance.get_HVDTTLID_By_IDHV_IDLOP(Convert.ToInt32(txbIDHV.Text), DSLopDTTLDAO.Instance.getIdByMALOP(txbLopMaLop.Text));
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
            else if(txbIDHV.Text == "")
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
 //           try
 //           {
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
                    string HCKTHOIGIANBATDAU = txbThoigianbatdau.Text.Substring(0,10);
                    string HCKTHOIGIANKETTHUC = txbThoigianketthuc.Text.Substring(0, 10);
					int IDKHOAPHONG = Convert.ToInt32(txbKHOAPHONG.Text);
                    bool LuuCheck = false;


                    if (txbIDHV.Text == "")
                    {
                        if (DSHocVienDTTLDAO.Instance.count_HV_by_IDHV_IDLOP(IDHOCVIEN, IDLOPHOC) > 0)
                        {
                            MessageBox.Show("Học viên: " + cbbHVHoTen.Text + " đã tồn tại", "Cảnh báo");
                        }
                        else
                        {
                            LuuCheck = DSHocVienDTTLDAO.Instance.InsertHVTL(IDHOCVIEN, IDLOPHOC, SOTIETHOC, SOTIETNGHI, GOICHUYENGIAOKT, IDLOAICN, GHICHU);
                            if (LuuCheck)
                            {



                            int MMYYBD = Convert.ToInt32(txbThoigianbatdau.Text.Substring(8, 2) + txbThoigianbatdau.Text.Substring(0, 2));
                            int MMYYKT = Convert.ToInt32(txbThoigianketthuc.Text.Substring(8, 2) + txbThoigianketthuc.Text.Substring(0, 2));
                            string MM = txbThoigianbatdau.Text.Substring(0, 2);
                            string YY = txbThoigianbatdau.Text.Substring(8, 2);

                            insert_update_ChamCong_DTTL(MM + YY, IDHOCVIEN,IDHOCVIEN, IDKHOAPHONG,HCKTHOIGIANBATDAU,HCKTHOIGIANKETTHUC, 1);

                                while (MMYYKT > MMYYBD)
                                {
                                    MM = (Convert.ToInt32(MM) + 1).ToString();
                                    if (Convert.ToInt32(MM) < 10)
                                    {
                                        MM = "0" + MM;
                                    }
                                    if (MM == "13")
                                    {
                                        MM = "01";
                                        YY = (Convert.ToInt32(YY) + 1).ToString();
                                    }
                                    insert_update_ChamCong_DTTL(MM + YY, IDHOCVIEN, IDHOCVIEN, IDKHOAPHONG, HCKTHOIGIANBATDAU, HCKTHOIGIANKETTHUC, 1);
                                    MMYYBD = Convert.ToInt32(YY + MM);
                                }
                                ButtonLoad();
                                dtgvHVTL.DataSource = DSHocVienDTTLDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
                                btnHVTLMoi.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Lỗi thêm mới");
                                cbbHVHoTen.Focus();
                            }
                        }
                    }
                    else
                    {
                        int HVDTTLID = Convert.ToInt32(txbDTTLID.Text);

                        LuuCheck = DSHocVienDTTLDAO.Instance.UpdateHVTL(SOTIETHOC, SOTIETNGHI, GOICHUYENGIAOKT, IDLOAICN, GHICHU, HVDTTLID);
                        if (LuuCheck)
                        {
                            ButtonLoad();
                            dtgvHVTL.DataSource = DSHocVienDTTLDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
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

        public void insert_update_ChamCong_DTTL(string MMYY, int IDHOCVIEN, int IDLOPHOC, int IDKHOAPHONG, string HCKTHOIGIANBATDAU, string HCKTHOIGIANKETTHUC, int TINHTRANG)
        {
            ChamCongDTTLDAO.Instance.InsertChamCongHV_DTTL(MMYY, IDHOCVIEN, IDLOPHOC, IDKHOAPHONG, HCKTHOIGIANBATDAU, HCKTHOIGIANKETTHUC, TINHTRANG);
            
        }


        private void btnHVTLXoa_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (int.TryParse(txbDTTLID.Text, out num))
            {
                DialogResult drXoa = MessageBox.Show("Xoa học viên: " + cbbHVHoTen.Text + " - Lớp: " + txbTenLop.Text, "Cảnh báo", MessageBoxButtons.YesNo);

                if (drXoa == DialogResult.Yes)
                {
                    DSHocVienDTTLDAO.Instance.DeleteHVTL(num);
                    ChamCongDTTLDAO.Instance.DeleteChamCongHV_DTTL(Convert.ToInt32(txbIDHV.Text), Convert.ToInt32(txbLopID.Text));
                    ButtonLoad();
                    btnHVTLMoi.Focus();
                    if (txbLopID.Text == "")
                    {
                        LoadDSHVtoDtgvHVTL();
                    }
                    else
                    {
                        dtgvHVTL.DataSource = DSHocVienDTTLDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
                    }
                }
            }
            else
            {
                ButtonLoad();
                dtgvHVTL.DataSource = DSHocVienDTTLDAO.Instance.SearchDSHVbyIDMaLop(Convert.ToInt32(txbLopID.Text));
                btnHVTLMoi.Focus();
            }                       
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            fDSLopDTTL f = new fDSLopDTTL();
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

        private void btnTaodulieuchamcong_Click(object sender, EventArgs e)
        {
            if(txbLopID.Text == "")
            {
                MessageBox.Show("Chưa chọn lớp");
            }
            else
            {
                int countrows = dtgvHVTL.Rows.Count;
                int IDLOPHOC = Convert.ToInt32(txbLopID.Text);
                int IDKHOAPHONG = Convert.ToInt32(txbKHOAPHONG.Text);
                int IDHOCVIEN = 0;
                string HCKTHOIGIANBATDAU = txbThoigianbatdau.Text.Substring(0, 10);
                string HCKTHOIGIANKETTHUC = txbThoigianketthuc.Text.Substring(0, 10);
                for (int i = 0; i < countrows; i++)
                {

                    int YYMMBD = Convert.ToInt32(txbThoigianbatdau.Text.Substring(8, 2) + txbThoigianbatdau.Text.Substring(0, 2));
                    int YYMMKT = Convert.ToInt32(txbThoigianketthuc.Text.Substring(8, 2) + txbThoigianketthuc.Text.Substring(0, 2));
                    string MM = txbThoigianbatdau.Text.Substring(0, 2);
                    string YY = txbThoigianbatdau.Text.Substring(8, 2);
                    IDHOCVIEN = Convert.ToInt32(dtgvHVTL.Rows[i].Cells[0].Value.ToString());
                    ChamCongDTTLDAO.Instance.Update_TinhTrang_ChamCongHV_by_TaoDuLieuChamCong(IDLOPHOC, IDHOCVIEN);

                    while (YYMMKT >= YYMMBD)
                    {
                        //kiem tra tồn tại
                        if (ChamCongDTTLDAO.Instance.KIEMTRA_CHAMCONG_TONTAI(MM + YY, IDHOCVIEN, IDLOPHOC))
                        {
                            ChamCongDTTLDAO.Instance.UpdateChamCongHV(MM + YY, IDLOPHOC, IDHOCVIEN, IDKHOAPHONG, HCKTHOIGIANBATDAU, HCKTHOIGIANKETTHUC, 1);
                        }
                        else
                        {
                            insert_update_ChamCong_DTTL(MM + YY, IDHOCVIEN, IDLOPHOC, IDKHOAPHONG, HCKTHOIGIANBATDAU, HCKTHOIGIANKETTHUC, 1);
                        }
                        MM = (Convert.ToInt32(MM) + 1).ToString();
                        if (Convert.ToInt32(MM) < 10)
                        {
                            MM = "0" + MM;
                        }
                        if (MM == "13")
                        {
                            MM = "01";
                            YY = (Convert.ToInt32(YY) + 1).ToString();
                        }
                        YYMMBD = Convert.ToInt32(YY + MM);

                    }
                    
                 }
                MessageBox.Show("Tạo dữ liệu thành công");

            }
        }
    }
}

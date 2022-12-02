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
    public partial class fChamCong : Form
    {
        public fChamCong()
        {
            InitializeComponent();
            string day = DateTime.Now.ToString("MM/dd/yyyy");
            dtpkNGAYDIEMDANH.Text = day;
            Load_ChamCong(day.Substring(0, 2),day.Substring(8, 2));
            Load_ChamCong_DTTL(day.Substring(0, 2), day.Substring(8, 2));
            LoadNamHCK(cbbNam);
            LoadNamHCK(cbbNamDTTL);
            cbbThang.Text = day.Substring(0, 2);
            cbbThangDTTL.Text = day.Substring(0, 2);
            loadDMCHAMCONG();
            loadDMCHAMCONGDTTL();
           // load_TENLOP();

        }




//hoc chuyen khoa
        void LoadNamHCK(ComboBox cbb)
        {
            cbb.Text = HocChuyenKhoaDAO.Instance.LoadNamHienTai();
        }

        void Load_ChamCong(string MM, string YY)
        {
            dtgvDiemDanh.DataSource = ChamCongHCKDAO.Instance.LoadChamCong(MM+YY);
            dtgvDiemDanh.Columns[0].Width = 40;
            dtgvDiemDanh.Columns[1].Width = 70;
            dtgvDiemDanh.Columns[2].Width = 150;
            dtgvDiemDanh.Columns[3].Width = 150;
            dtgvDiemDanh.Columns[4].Width = 300;
            int i = 0;
            for(i= 5; i<36;i++)
            {
                dtgvDiemDanh.Columns[i].Width = 35;
            }
             
            
            dtgvDiemDanh.Columns[DateTime.Now.Day + 4].Width = 80;
            dtgvDiemDanh.Columns[0].Frozen = true;
            dtgvDiemDanh.Columns[1].Frozen = true;
            dtgvDiemDanh.Columns[2].Frozen = true;
            dtgvDiemDanh.Columns[3].Frozen = true;

        }

        private void dtgvDiemDanh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetColumnColor(DateTime.Now.Day + 4, Color.LightGray);
        }
        
        private void SetColumnColor(int indexCol, Color color)
        {
            for (int row = 0; row < dtgvDiemDanh.Rows.Count; row++)
            {
                dtgvDiemDanh.Rows[row].Cells[indexCol].Style.BackColor = color;
            }
        }

        private void cbbNam_SelectedValueChanged(object sender, EventArgs e)
        {

            Load_ChamCong(cbbThang.Text, cbbNam.Text.Substring(2,2));
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_ChamCong(cbbThang.Text, cbbNam.Text.Substring(2, 2));
        }
               
        private void txbSearch_HV_TextChanged(object sender, EventArgs e)
        {
            dtgvDiemDanh.DataSource = ChamCongHCKDAO.Instance.LoadChamCong_Search_HOCVIEN(txbSearch_HV.Text);
        }

        private void txbSearch_HV_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearch_HV.Text = "";
        }

        void loadDMCHAMCONG()
        {
            cbbDIEMDANH.DataSource = DMChamCongDAO.Instance.Load_DMChamCong_to_CBB();
            cbbDIEMDANH.ValueMember = "DMCDVIETTAT";
            cbbDIEMDANH.DisplayMember = "DMCDTEN";
        }

        private void dtgvDiemDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MMYY = "";
            if (e.RowIndex >= 0)

            {
                DataGridViewRow row = this.dtgvDiemDanh.Rows[e.RowIndex];
                txbMALOP.Text = row.Cells[1].Value.ToString();
                txbHOCVIEN.Text = row.Cells[2].Value.ToString();
                txbMMYY.Text = row.Cells[0].Value.ToString();
                txbGHICHU.Text = row.Cells[36].Value.ToString();
                MMYY = txbMMYY.Text;
                dtpkNGAYDIEMDANH.Text = MMYY.Substring(0, 2) + "/01/20" + MMYY.Substring(2, 2);
                txbIDLOP.Text = (ChamCongHCKDAO.Instance.get_IDLOP_By_MALOP(txbMALOP.Text)).ToString();
                cbbDIEMDANH.Text = "";
            }  
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IDLOP = Convert.ToInt32(txbIDLOP.Text);
            string ngaythangCC = dtpkNGAYDIEMDANH.Text;
            string Cot_ngayCC = "N" + Convert.ToInt32(ngaythangCC.Substring(0,2)).ToString();
            string MMYY = txbMMYY.Text;
            string LOAI_CC = "";
            string GHICHU = txbGHICHU.Text;
            if (cbbDIEMDANH.Text != "") {LOAI_CC = cbbDIEMDANH.SelectedValue.ToString();}
            
            if (ChamCongHCKDAO.Instance.Kiemtra_IDHCK_MMYY(IDLOP, MMYY))
            {
                ChamCongHCKDAO.Instance.UpdateChamCong(Cot_ngayCC, LOAI_CC, IDLOP, MMYY, GHICHU);
                dtgvDiemDanh.DataSource = ChamCongHCKDAO.Instance.LoadChamCong(MMYY);
            }
       }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }





//dao tao theo lop




        void Load_ChamCong_DTTL(string MM, string YY)
        {
            dtgvDTTL.DataSource = ChamCongDTTLDAO.Instance.LoadChamCong_DTTL(MM + YY);
            dtgvDTTL.Columns[0].Width = 40;
            dtgvDTTL.Columns[1].Width = 70;
            dtgvDTTL.Columns[2].Width = 150;
            dtgvDTTL.Columns[3].Width = 150;
            dtgvDTTL.Columns[4].Width = 300;
            int i = 0;
            for (i = 5; i < 36; i++)
            {
                dtgvDTTL.Columns[i].Width = 35;
            }
            dtgvDTTL.Columns[DateTime.Now.Day + 4].Width = 80;
            dtgvDTTL.Columns[0].Frozen = true;
            dtgvDTTL.Columns[1].Frozen = true;
            dtgvDTTL.Columns[2].Frozen = true;
            dtgvDTTL.Columns[3].Frozen = true;
            dtgvDTTL.Columns[37].Visible = false;
            dtgvDTTL.Columns[38].Visible = false;
        }
        void Load_ChamCong_DTTL_TIMLOP(string MM, string YY,string TIMLOP)
        {
            dtgvDTTL.DataSource = ChamCongDTTLDAO.Instance.LoadChamCong_DTTL_TIMLOP(MM + YY, TIMLOP);
            dtgvDTTL.Columns[0].Width = 40;
            dtgvDTTL.Columns[1].Width = 70;
            dtgvDTTL.Columns[2].Width = 150;
            dtgvDTTL.Columns[3].Width = 150;
            dtgvDTTL.Columns[4].Width = 300;
            int i = 0;
            for (i = 5; i < 36; i++)
            {
                dtgvDTTL.Columns[i].Width = 35;
            }
            dtgvDTTL.Columns[DateTime.Now.Day + 4].Width = 80;
            dtgvDTTL.Columns[0].Frozen = true;
            dtgvDTTL.Columns[1].Frozen = true;
            dtgvDTTL.Columns[2].Frozen = true;
            dtgvDTTL.Columns[3].Frozen = true;
            dtgvDTTL.Columns[37].Visible = false;
            dtgvDTTL.Columns[38].Visible = false;
        }

        private void cbbNamDTTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_ChamCong_DTTL(cbbThangDTTL.Text, cbbNamDTTL.Text.Substring(2, 2));
        }
        private void cbbThangDTTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_ChamCong_DTTL(cbbThangDTTL.Text, cbbNamDTTL.Text.Substring(2, 2));
        }

        private void btnKetThucDTTL_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dtgvDTTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MMYY = "";
            if (e.RowIndex >= 0)

            {
                DataGridViewRow row = this.dtgvDTTL.Rows[e.RowIndex];
                txbMMYYDTTL.Text = row.Cells[0].Value.ToString();
                txbMaLopDTTL.Text = row.Cells[1].Value.ToString();
                txbHVDTTL.Text = row.Cells[2].Value.ToString();
                txbGHICHU.Text = row.Cells[36].Value.ToString();
                txbIDLOPDTTL.Text = row.Cells[37].Value.ToString();
                txbIDHOCVIEN.Text = row.Cells[38].Value.ToString();
                MMYY = txbMMYYDTTL.Text;
                dtpkNGAYDIEMDANH.Text = MMYY.Substring(0, 2) + "/01/20" + MMYY.Substring(2, 2);
                txbIDLOP.Text = (ChamCongHCKDAO.Instance.get_IDLOP_By_MALOP(txbMALOP.Text)).ToString();
                cbbChonDiemDanhDTTL.Text = "";
            }

        }
        void loadDMCHAMCONGDTTL()
        {
            cbbChonDiemDanhDTTL.DataSource = DMChamCongDAO.Instance.Load_DMChamCong_to_CBB();
            cbbChonDiemDanhDTTL.ValueMember = "DMCDVIETTAT";
            cbbChonDiemDanhDTTL.DisplayMember = "DMCDTEN";
        }

 //       void load_TENLOP()
 //       {
 //           cbbChonLop.DataSource = ChamCongDTTLDAO.Instance.Load_TENLOP();
 //           cbbChonLop.ValueMember = "DSLOPDTTLID";
 //           cbbChonLop.DisplayMember = "NOIDUNGHOC";
 //       }

        private void txbTimLop_MouseUp(object sender, MouseEventArgs e)
        {
            txbTimLop.Text = "";
        }

        private void txbTimLop_TextChanged(object sender, EventArgs e)
        {
            Load_ChamCong_DTTL_TIMLOP(cbbThangDTTL.Text, cbbNamDTTL.Text.Substring(2, 2),txbTimLop.Text);
        }

        private void btnLuuDTTL_Click(object sender, EventArgs e)
        {
            int IDLOP_DTTL = Convert.ToInt32(txbIDLOPDTTL.Text);
            string ngaythangCC_DTTL = dtpkNgayChamCong_DTTL.Text;
            string Cot_ngayCC_DTTL = "N" + Convert.ToInt32(ngaythangCC_DTTL.Substring(0, 2)).ToString();
            string MMYY = txbMMYYDTTL.Text;
            int IDHOCVIEN = Convert.ToInt32(txbIDHOCVIEN.Text);
            string LOAI_CC = "";
            string GHICHU = txbGhiChuDTTL.Text;
            if (cbbChonDiemDanhDTTL.Text != "") { LOAI_CC = cbbChonDiemDanhDTTL.SelectedValue.ToString(); }

            if (ChamCongDTTLDAO.Instance.Kiemtra_IDHCK_MMYY_DTTL(IDLOP_DTTL, MMYY, IDHOCVIEN))
            {
                ChamCongDTTLDAO.Instance.UpdateChamCong_DTTL(Cot_ngayCC_DTTL, LOAI_CC, IDLOP_DTTL, IDHOCVIEN, MMYY, GHICHU);
                dtgvDTTL.DataSource = ChamCongDTTLDAO.Instance.LoadChamCong_DTTL(MMYY);
            }
        }
    }
}

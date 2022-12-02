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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            pMain.Visible = false;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            fLogin f = new fLogin();
            f.ShowDialog();
        }
        private void chứcDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMCHUCDANH dmcd = new DMCHUCDANH();
            dmcd.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.ShowDialog();
        }


        private void đơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDMBenhVien f = new fDMBenhVien();
            f.ShowDialog();
        }

        private void khoaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDMKhoaPhong f = new fDMKhoaPhong();
            f.ShowDialog();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDMChucVu f = new fDMChucVu();
            f.ShowDialog();
        }

        private void nhânViênHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDMHocVien f = new fDMHocVien();
            f.ShowDialog();
        }

        private void nCKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDSNCKH f = new fDSNCKH();
            f.ShowDialog();
        }

        private void nCKHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fDSNCKH f = new fDSNCKH();
            f.ShowDialog();
        }

        private void họcChuyênKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDSHocChuyenKhoa f = new fDSHocChuyenKhoa();
            f.ShowDialog();
        }

        private void ápDụngNCKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDSApDungNCKH f = new fDSApDungNCKH();
            f.ShowDialog();
        }

        private void danhSáchLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDSLopDTTL f = new fDSLopDTTL();
            f.ShowDialog();
        }

        private void họcViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDSHocVienDTTL f = new fDSHocVienDTTL();
            f.ShowDialog();
        }

        private void sinhHoạtKhoaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDSHocVienSHKH f = new fDSHocVienSHKH();
            f.ShowDialog();
        }

        private void cấpChứngNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCapChungNhan f = new fCapChungNhan();
            f.ShowDialog();
        }

        private void chuyểnGiaoKỹThuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCGKTCT f = new fCGKTCT();
            f.ShowDialog();
        }

        private void nhânViênHọcViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(!CheckExistForm("fDMHocVien"))
            {
                pMain.Visible = true;
                fDMHocVien f = new fDMHocVien();
                f.TopLevel = false;
                pMain.Controls.Clear();
                pMain.Controls.Add(f);
                f.Show();

            }
            else
            {
                ActiveChildForm("fDMHocVien");
            }


        }

        private void điểmDanhHọcChuyênKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChamCong f = new fChamCong();
            f.ShowDialog();
                
        }

        private void dMChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDMChamCong f = new fDMChamCong();
            f.ShowDialog();
        }

        private void mởNgàyChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMoChamCong f = new fMoChamCong();
            f.ShowDialog();
        }

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach(Form f in this.MdiChildren)
            {
                if(f.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    f.Activate();
                    break;
                }
            }            
        }
    } 
}


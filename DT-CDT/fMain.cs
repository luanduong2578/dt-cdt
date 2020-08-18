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
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void chứcDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdmChucDanh dmcd = new fdmChucDanh();
            dmcd.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void đơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBenhVien f = new fBenhVien();
            f.ShowDialog();
        }

        private void khoaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhoaPhong f = new fKhoaPhong();
            f.ShowDialog();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChucVu f = new fChucVu();
            f.ShowDialog();
        }

        private void nhânViênHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHocVien f = new fHocVien();
            f.ShowDialog();
        }

        private void nCKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNCKH f = new fNCKH();
            f.ShowDialog();
        }

        private void nCKHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fNCKH f = new fNCKH();
            f.ShowDialog();
        }

        private void họcChuyênKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHocChuyenKhoa f = new fHocChuyenKhoa();
            f.ShowDialog();
        }

        private void ápDụngNCKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fApDungNCKH f = new fApDungNCKH();
            f.ShowDialog();
        }

        private void danhSáchLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLopHoc1 f = new fLopHoc1();
            f.ShowDialog();
        }

        private void họcViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHocVienTheoLop f = new fHocVienTheoLop();
            f.ShowDialog();
        }
    } 
}


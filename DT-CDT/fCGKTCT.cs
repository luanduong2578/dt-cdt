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
    public partial class fCGKTCT : Form
    {
        public fCGKTCT()
        {
            InitializeComponent();
            loadHTuNam();
            loadDenNam();
            loadNamCGKT();
            LoadNamHCK(cbbSearchTuNam);
            LoadNamHCK(cbbSearchDenNam);
            LoadNamHCK(cbbNamCGKT);
            load_GOI_CGKT(Convert.ToInt32(CGKTCTDAO.Instance.LoadNamHienTai()));
            txbCGKTID.Text = "";
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
        void loadNamCGKT()
        {
            cbbNamCGKT.DataSource = NamNCDAO.Instance.LoadListNamNC();
            cbbNamCGKT.ValueMember = "NAMID";
            cbbNamCGKT.DisplayMember = "NAMTEN";
        }

        void LoadNamHCK(ComboBox cbb)
        {
            cbb.Text = CGKTCTDAO.Instance.LoadNamHienTai();
        }
        void load_GOI_CGKT(int nam)
        {
            cbbGoiCGKT.DataSource = CGKTCTDAO.Instance.Load_Goi_CGKT(nam);
            cbbGoiCGKT.ValueMember = "ID";
            cbbGoiCGKT.DisplayMember = "GOIKT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fCGKTLL f = new fCGKTLL();
            f.Show();
        }

        private void cbbNamCGKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbbGoiCGKT.Text = "";
                txbCGKTID.Text = "";
                load_GOI_CGKT(Convert.ToInt32(cbbNamCGKT.Text));
            }
            catch(Exception ex)
            {
                ex.ToString();
            }

        }

        private void cbbGoiCGKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txbCGKTID.Text = cbbGoiCGKT.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void txbSearchND_MouseUp(object sender, MouseEventArgs e)
        {
            txbSearchND.Text = "";
        }
    }
}

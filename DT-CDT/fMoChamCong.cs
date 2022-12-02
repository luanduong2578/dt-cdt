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
    public partial class fMoChamCong : Form
    {
        public fMoChamCong()
        {
            InitializeComponent();
            dateTimePicker1.Text = MoChamCongDAO.Instance.GetMoCC_NGAYBATDAU();
            dateTimePicker2.Text = MoChamCongDAO.Instance.GetMoCC_NGAYKETTHUC();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if( MoChamCongDAO.Instance.UpdateMoChamCongHV(dateTimePicker1.Text, dateTimePicker2.Text))
            {
                MessageBox.Show("Cập nhật thành công");
            }

        }
    }
}

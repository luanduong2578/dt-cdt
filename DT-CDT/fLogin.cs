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
     public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;
            if (Login(username, password))
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }

        }

        bool Login(string username, string password)
        {

            return TaiKhoanDAO.Instance.Login(username, password);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}


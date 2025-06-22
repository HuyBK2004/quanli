using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string msg;
            var user = NguoiDungBUS.Login(username, password, out msg);
            if (user != null)
            {
                this.Hide();
                new frmMain(user).Show();
            }
            else
            {
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRegister().Show();
        }
    }
}
using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            var user = new NguoiDung
            {
                HoTen = txtHoTen.Text.Trim(),
                Username = txtUsername.Text.Trim(),
                MatKhau = txtPassword.Text,
                Email = txtEmail.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim()
            };
            string confirmPassword = txtConfirmPassword.Text;
            string msg;
            if (NguoiDungBUS.Register(user, confirmPassword, out msg))
            {
                MessageBox.Show(msg, "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                new frmLogin().Show();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }
    }
}
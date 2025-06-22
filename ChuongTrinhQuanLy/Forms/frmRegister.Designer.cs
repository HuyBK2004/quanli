using System.Windows.Forms;

namespace Forms
{
    partial class frmRegister
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle, lblUsername, lblPassword, lblConfirmPassword, lblHoTen, lblEmail, lblSoDienThoai;
        private System.Windows.Forms.TextBox txtUsername, txtPassword, txtConfirmPassword, txtHoTen, txtEmail, txtSoDienThoai;
        private System.Windows.Forms.Button btnDangKy, btnQuayLai;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();

            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();

            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Đăng ký tài khoản khách hàng";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(60, 20);

            // 
            // lblHoTen
            // 
            this.lblHoTen.Text = "Họ tên:";
            this.lblHoTen.Location = new System.Drawing.Point(30, 70);

            // 
            // lblUsername
            // 
            this.lblUsername.Text = "Tên đăng nhập:";
            this.lblUsername.Location = new System.Drawing.Point(30, 110);

            // 
            // lblPassword
            // 
            this.lblPassword.Text = "Mật khẩu:";
            this.lblPassword.Location = new System.Drawing.Point(30, 150);

            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            this.lblConfirmPassword.Location = new System.Drawing.Point(30, 190);

            // 
            // lblEmail
            // 
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(30, 230);

            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Text = "Số điện thoại:";
            this.lblSoDienThoai.Location = new System.Drawing.Point(30, 270);

            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(170, 67);
            this.txtHoTen.Width = 200;

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(170, 107);
            this.txtUsername.Width = 200;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 147);
            this.txtPassword.Width = 200;
            this.txtPassword.PasswordChar = '*';

            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(170, 187);
            this.txtConfirmPassword.Width = 200;
            this.txtConfirmPassword.PasswordChar = '*';

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(170, 227);
            this.txtEmail.Width = 200;

            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(170, 267);
            this.txtSoDienThoai.Width = 200;

            // 
            // btnDangKy
            // 
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Location = new System.Drawing.Point(80, 320);
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.Location = new System.Drawing.Point(210, 320);
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);

            // 
            // frmRegister
            // 
            this.ClientSize = new System.Drawing.Size(420, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnQuayLai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký khách hàng";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
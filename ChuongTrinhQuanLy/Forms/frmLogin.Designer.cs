namespace Forms
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangKy;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Đăng nhập hệ thống";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(90, 30);

            // 
            // lblUsername
            // 
            this.lblUsername.Text = "Tên đăng nhập:";
            this.lblUsername.Location = new System.Drawing.Point(40, 90);

            // 
            // lblPassword
            // 
            this.lblPassword.Text = "Mật khẩu:";
            this.lblPassword.Location = new System.Drawing.Point(40, 130);

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(160, 87);
            this.txtUsername.Width = 180;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(160, 127);
            this.txtPassword.Width = 180;
            this.txtPassword.PasswordChar = '*';

            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Location = new System.Drawing.Point(90, 180);
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);

            // 
            // btnDangKy
            // 
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Location = new System.Drawing.Point(210, 180);
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(400, 270);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnDangKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
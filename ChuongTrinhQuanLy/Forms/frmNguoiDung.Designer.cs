namespace Forms
{
    partial class frmNguoiDung
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();

            // lblTitle
            this.lblTitle.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.AutoSize = true;

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(20, 55);
            this.pnlMain.Size = new System.Drawing.Size(810, 185);

            // lblHoTen
            this.lblHoTen.Text = "Họ tên:";
            this.lblHoTen.Location = new System.Drawing.Point(25, 15);
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(110, 13);
            this.txtHoTen.Width = 200;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblUsername
            this.lblUsername.Text = "Username:";
            this.lblUsername.Location = new System.Drawing.Point(25, 55);
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(110, 53);
            this.txtUsername.Width = 200;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblMatKhau
            this.lblMatKhau.Text = "Mật khẩu:";
            this.lblMatKhau.Location = new System.Drawing.Point(25, 95);
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtMatKhau
            this.txtMatKhau.Location = new System.Drawing.Point(110, 93);
            this.txtMatKhau.Width = 200;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhau.PasswordChar = '*';

            // lblEmail
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(25, 135);
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(110, 133);
            this.txtEmail.Width = 200;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblSoDienThoai
            this.lblSoDienThoai.Text = "SĐT:";
            this.lblSoDienThoai.Location = new System.Drawing.Point(380, 15);
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtSoDienThoai
            this.txtSoDienThoai.Location = new System.Drawing.Point(470, 13);
            this.txtSoDienThoai.Width = 200;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblVaiTro
            this.lblVaiTro.Text = "Vai trò:";
            this.lblVaiTro.Location = new System.Drawing.Point(380, 55);
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Segoe UI", 10F);

            // cboVaiTro
            this.cboVaiTro.Location = new System.Drawing.Point(470, 53);
            this.cboVaiTro.Width = 200;
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboVaiTro.Items.AddRange(new object[] { "Chu", "NhanVienKho", "ThuNgan", "KH" });

            // lblTrangThai
            this.lblTrangThai.Text = "Trạng thái:";
            this.lblTrangThai.Location = new System.Drawing.Point(380, 95);
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);

            // cboTrangThai
            this.cboTrangThai.Location = new System.Drawing.Point(470, 93);
            this.cboTrangThai.Width = 200;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.Items.AddRange(new object[] { "BinhThuong", "Khoa" });

            // btnThem
            this.btnThem.Text = "Thêm";
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(470, 133);
            this.btnThem.Size = new System.Drawing.Size(65, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Text = "Sửa";
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(545, 133);
            this.btnSua.Size = new System.Drawing.Size(65, 30);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(620, 133);
            this.btnXoa.Size = new System.Drawing.Size(65, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // dgvNguoiDung
            this.dgvNguoiDung.Location = new System.Drawing.Point(20, 260);
            this.dgvNguoiDung.Size = new System.Drawing.Size(800, 260);
            this.dgvNguoiDung.ReadOnly = true;
            this.dgvNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoiDung.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvNguoiDung.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvNguoiDung.SelectionChanged += new System.EventHandler(this.dgvNguoiDung_SelectionChanged);

            // frmNguoiDung
            this.Text = "Quản lý Người dùng";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(850, 540);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.dgvNguoiDung);

            this.pnlMain.Controls.Add(this.lblHoTen);
            this.pnlMain.Controls.Add(this.txtHoTen);
            this.pnlMain.Controls.Add(this.lblUsername);
            this.pnlMain.Controls.Add(this.txtUsername);
            this.pnlMain.Controls.Add(this.lblMatKhau);
            this.pnlMain.Controls.Add(this.txtMatKhau);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.lblSoDienThoai);
            this.pnlMain.Controls.Add(this.txtSoDienThoai);
            this.pnlMain.Controls.Add(this.lblVaiTro);
            this.pnlMain.Controls.Add(this.cboVaiTro);
            this.pnlMain.Controls.Add(this.lblTrangThai);
            this.pnlMain.Controls.Add(this.cboTrangThai);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Controls.Add(this.btnSua);
            this.pnlMain.Controls.Add(this.btnXoa);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
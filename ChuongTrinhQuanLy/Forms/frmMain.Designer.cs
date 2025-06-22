namespace Forms
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuDonHang;
        private System.Windows.Forms.ToolStripMenuItem mnuGioHang;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Label lblWelcome;

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNguoiDung,
            this.mnuSanPham,
            this.mnuPhieuNhap,
            this.mnuHoaDon,
            this.mnuDonHang,
            this.mnuGioHang,
            this.mnuDangXuat,
            this.mnuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 28);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuNguoiDung
            // 
            this.mnuNguoiDung.Name = "mnuNguoiDung";
            this.mnuNguoiDung.Size = new System.Drawing.Size(103, 24);
            this.mnuNguoiDung.Text = "Người Dùng";
            this.mnuNguoiDung.Click += new System.EventHandler(this.mnuNguoiDung_Click);
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(86, 24);
            this.mnuSanPham.Text = "Sản Phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
            // 
            // mnuPhieuNhap
            // 
            this.mnuPhieuNhap.Name = "mnuPhieuNhap";
            this.mnuPhieuNhap.Size = new System.Drawing.Size(97, 24);
            this.mnuPhieuNhap.Text = "Phiếu Nhập";
            this.mnuPhieuNhap.Click += new System.EventHandler(this.mnuPhieuNhap_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(81, 24);
            this.mnuHoaDon.Text = "Hóa Đơn";
            this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
            // 
            // mnuDonHang
            // 
            this.mnuDonHang.Name = "mnuDonHang";
            this.mnuDonHang.Size = new System.Drawing.Size(89, 24);
            this.mnuDonHang.Text = "Đơn Hàng";
            this.mnuDonHang.Click += new System.EventHandler(this.mnuDonHang_Click);
            // 
            // mnuGioHang
            // 
            this.mnuGioHang.Name = "mnuGioHang";
            this.mnuGioHang.Size = new System.Drawing.Size(84, 24);
            this.mnuGioHang.Text = "Giỏ Hàng";
            this.mnuGioHang.Click += new System.EventHandler(this.mnuGioHang_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(91, 24);
            this.mnuDangXuat.Text = "Đăng Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(59, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.lblWelcome.Location = new System.Drawing.Point(30, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(303, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Chào mừng bạn đến với hệ thống!";
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(730, 261);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Bán Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
namespace Forms
{
    partial class frmHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();

            // lblTitle
            this.lblTitle.Text = "QUẢN LÝ HÓA ĐƠN";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.AutoSize = true;

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(20, 55);
            this.pnlMain.Size = new System.Drawing.Size(960, 420);

            // dgvHoaDon
            this.dgvHoaDon.Location = new System.Drawing.Point(10, 10);
            this.dgvHoaDon.Size = new System.Drawing.Size(710, 170);
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvHoaDon.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvHoaDon.SelectionChanged += new System.EventHandler(this.dgvHoaDon_SelectionChanged);

            // dgvChiTietHD
            this.dgvChiTietHD.Location = new System.Drawing.Point(10, 200);
            this.dgvChiTietHD.Size = new System.Drawing.Size(710, 180);
            this.dgvChiTietHD.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvChiTietHD.ReadOnly = true;
            this.dgvChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHD.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblMaSP
            this.lblMaSP.Text = "Mã SP:";
            this.lblMaSP.Location = new System.Drawing.Point(740, 30);
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtMaSP
            this.txtMaSP.Location = new System.Drawing.Point(800, 28);
            this.txtMaSP.Width = 130;
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblSoLuong
            this.lblSoLuong.Text = "Số lượng:";
            this.lblSoLuong.Location = new System.Drawing.Point(740, 70);
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtSoLuong
            this.txtSoLuong.Location = new System.Drawing.Point(800, 68);
            this.txtSoLuong.Width = 130;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblDonGia
            this.lblDonGia.Text = "Đơn giá:";
            this.lblDonGia.Location = new System.Drawing.Point(740, 110);
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtDonGia
            this.txtDonGia.Location = new System.Drawing.Point(800, 108);
            this.txtDonGia.Width = 130;
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 10F);

            // btnTaoHoaDon
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaoHoaDon.BackColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.btnTaoHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnTaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(740, 170);
            this.btnTaoHoaDon.Size = new System.Drawing.Size(190, 35);
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);

            // btnThemSP
            this.btnThemSP.Text = "Thêm SP vào hóa đơn";
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemSP.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Location = new System.Drawing.Point(740, 215);
            this.btnThemSP.Size = new System.Drawing.Size(190, 35);
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);

            // btnThanhToan
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Location = new System.Drawing.Point(740, 260);
            this.btnThanhToan.Size = new System.Drawing.Size(190, 35);
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            // frmHoaDon
            this.Text = "Quản lý Hóa đơn";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMain);

            this.pnlMain.Controls.Add(this.dgvHoaDon);
            this.pnlMain.Controls.Add(this.dgvChiTietHD);
            this.pnlMain.Controls.Add(this.lblMaSP);
            this.pnlMain.Controls.Add(this.txtMaSP);
            this.pnlMain.Controls.Add(this.lblSoLuong);
            this.pnlMain.Controls.Add(this.txtSoLuong);
            this.pnlMain.Controls.Add(this.lblDonGia);
            this.pnlMain.Controls.Add(this.txtDonGia);
            this.pnlMain.Controls.Add(this.btnTaoHoaDon);
            this.pnlMain.Controls.Add(this.btnThemSP);
            this.pnlMain.Controls.Add(this.btnThanhToan);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
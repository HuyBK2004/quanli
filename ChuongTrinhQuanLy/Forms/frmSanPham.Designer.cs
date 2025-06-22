using System.Windows.Forms;

namespace Forms
{
    partial class frmSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();

            // lblTitle
            this.lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.AutoSize = true;

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(20, 55);
            this.pnlMain.Size = new System.Drawing.Size(800, 115);

            // lblTenSP
            this.lblTenSP.Text = "Tên SP:";
            this.lblTenSP.Location = new System.Drawing.Point(20, 20);
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtTenSP
            this.txtTenSP.Location = new System.Drawing.Point(100, 18);
            this.txtTenSP.Width = 200;
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblMoTa
            this.lblMoTa.Text = "Mô tả:";
            this.lblMoTa.Location = new System.Drawing.Point(20, 55);
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtMoTa
            this.txtMoTa.Location = new System.Drawing.Point(100, 53);
            this.txtMoTa.Width = 200;
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblGiaBan
            this.lblGiaBan.Text = "Giá bán:";
            this.lblGiaBan.Location = new System.Drawing.Point(20, 90);
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtGiaBan
            this.txtGiaBan.Location = new System.Drawing.Point(100, 88);
            this.txtGiaBan.Width = 200;
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblDonViTinh
            this.lblDonViTinh.Text = "Đơn vị tính:";
            this.lblDonViTinh.Location = new System.Drawing.Point(340, 20);
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtDonViTinh
            this.txtDonViTinh.Location = new System.Drawing.Point(440, 18);
            this.txtDonViTinh.Width = 150;
            this.txtDonViTinh.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblTrangThai
            this.lblTrangThai.Text = "Trạng thái:";
            this.lblTrangThai.Location = new System.Drawing.Point(340, 55);
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);

            // cboTrangThai
            this.cboTrangThai.Location = new System.Drawing.Point(440, 53);
            this.cboTrangThai.Width = 150;
            this.cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.Items.AddRange(new object[] { "DangBan", "NgungBan" });

            // btnThem
            this.btnThem.Text = "Thêm";
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(640, 18);
            this.btnThem.Size = new System.Drawing.Size(65, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Text = "Sửa";
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(715, 18);
            this.btnSua.Size = new System.Drawing.Size(65, 30);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(640, 58);
            this.btnXoa.Size = new System.Drawing.Size(140, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // dgvSanPham
            this.dgvSanPham.Location = new System.Drawing.Point(20, 180);
            this.dgvSanPham.Size = new System.Drawing.Size(800, 330);
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvSanPham.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);

            // frmSanPham
            this.Text = "Quản lý Sản phẩm";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(850, 540);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.dgvSanPham);

            this.pnlMain.Controls.Add(this.lblTenSP);
            this.pnlMain.Controls.Add(this.txtTenSP);
            this.pnlMain.Controls.Add(this.lblMoTa);
            this.pnlMain.Controls.Add(this.txtMoTa);
            this.pnlMain.Controls.Add(this.lblGiaBan);
            this.pnlMain.Controls.Add(this.txtGiaBan);
            this.pnlMain.Controls.Add(this.lblDonViTinh);
            this.pnlMain.Controls.Add(this.txtDonViTinh);
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
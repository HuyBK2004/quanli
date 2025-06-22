using System.Windows.Forms;

namespace Forms
{
    partial class frmPhieuNhap
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.DataGridView dgvChiTietPN;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Button btnTaoPhieu;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.Button btnTuChoi;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dgvChiTietPN = new System.Windows.Forms.DataGridView();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.btnTuChoi = new System.Windows.Forms.Button();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();

            // lblTitle
            this.lblTitle.Text = "QUẢN LÝ PHIẾU NHẬP KHO";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.AutoSize = true;

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(20, 55);
            this.pnlMain.Size = new System.Drawing.Size(960, 415);

            // dgvPhieuNhap
            this.dgvPhieuNhap.Location = new System.Drawing.Point(10, 10);
            this.dgvPhieuNhap.Size = new System.Drawing.Size(710, 170);
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvPhieuNhap.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvPhieuNhap.SelectionChanged += new System.EventHandler(this.dgvPhieuNhap_SelectionChanged);

            // dgvChiTietPN
            this.dgvChiTietPN.Location = new System.Drawing.Point(10, 200);
            this.dgvChiTietPN.Size = new System.Drawing.Size(710, 180);
            this.dgvChiTietPN.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvChiTietPN.ReadOnly = true;
            this.dgvChiTietPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPN.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);

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

            // lblGiaNhap
            this.lblGiaNhap.Text = "Giá nhập:";
            this.lblGiaNhap.Location = new System.Drawing.Point(740, 110);
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtGiaNhap
            this.txtGiaNhap.Location = new System.Drawing.Point(800, 108);
            this.txtGiaNhap.Width = 130;
            this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F);

            // btnTaoPhieu
            this.btnTaoPhieu.Text = "Tạo phiếu nhập";
            this.btnTaoPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaoPhieu.BackColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.btnTaoPhieu.ForeColor = System.Drawing.Color.White;
            this.btnTaoPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieu.Location = new System.Drawing.Point(740, 160);
            this.btnTaoPhieu.Size = new System.Drawing.Size(190, 35);
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);

            // btnThemSP
            this.btnThemSP.Text = "Thêm SP vào phiếu";
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemSP.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Location = new System.Drawing.Point(740, 205);
            this.btnThemSP.Size = new System.Drawing.Size(190, 35);
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);

            // btnDuyet
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDuyet.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyet.Location = new System.Drawing.Point(740, 250);
            this.btnDuyet.Size = new System.Drawing.Size(90, 35);
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);

            // btnTuChoi
            this.btnTuChoi.Text = "Từ chối";
            this.btnTuChoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTuChoi.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTuChoi.ForeColor = System.Drawing.Color.White;
            this.btnTuChoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuChoi.Location = new System.Drawing.Point(840, 250);
            this.btnTuChoi.Size = new System.Drawing.Size(90, 35);
            this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);

            // frmPhieuNhap
            this.Text = "Quản lý Phiếu nhập kho";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMain);

            this.pnlMain.Controls.Add(this.dgvPhieuNhap);
            this.pnlMain.Controls.Add(this.dgvChiTietPN);
            this.pnlMain.Controls.Add(this.lblMaSP);
            this.pnlMain.Controls.Add(this.txtMaSP);
            this.pnlMain.Controls.Add(this.lblSoLuong);
            this.pnlMain.Controls.Add(this.txtSoLuong);
            this.pnlMain.Controls.Add(this.lblGiaNhap);
            this.pnlMain.Controls.Add(this.txtGiaNhap);
            this.pnlMain.Controls.Add(this.btnTaoPhieu);
            this.pnlMain.Controls.Add(this.btnThemSP);
            this.pnlMain.Controls.Add(this.btnDuyet);
            this.pnlMain.Controls.Add(this.btnTuChoi);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
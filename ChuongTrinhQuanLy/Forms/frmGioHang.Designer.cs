namespace Forms
{
    partial class frmGioHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "GIỎ HÀNG";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.AutoSize = true;

            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(20, 55);
            this.pnlMain.Size = new System.Drawing.Size(800, 200);

            // 
            // dgvGioHang
            // 
            this.dgvGioHang.Location = new System.Drawing.Point(10, 10);
            this.dgvGioHang.Size = new System.Drawing.Size(580, 180);
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvGioHang.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // lblMaSP
            // 
            this.lblMaSP.Text = "Mã SP:";
            this.lblMaSP.Location = new System.Drawing.Point(610, 20);
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(670, 18);
            this.txtMaSP.Width = 110;
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Text = "Số lượng:";
            this.lblSoLuong.Location = new System.Drawing.Point(610, 60);
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(670, 58);
            this.txtSoLuong.Width = 110;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // btnThem
            // 
            this.btnThem.Text = "Thêm vào giỏ";
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(610, 100);
            this.btnThem.Size = new System.Drawing.Size(170, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa khỏi giỏ";
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(610, 140);
            this.btnXoa.Size = new System.Drawing.Size(170, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // btnDatHang
            // 
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDatHang.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatHang.Location = new System.Drawing.Point(610, 180);
            this.btnDatHang.Size = new System.Drawing.Size(170, 30);
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);

            // 
            // frmGioHang
            // 
            this.Text = "Giỏ hàng";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(850, 280);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMain);

            this.pnlMain.Controls.Add(this.dgvGioHang);
            this.pnlMain.Controls.Add(this.lblMaSP);
            this.pnlMain.Controls.Add(this.txtMaSP);
            this.pnlMain.Controls.Add(this.lblSoLuong);
            this.pnlMain.Controls.Add(this.txtSoLuong);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Controls.Add(this.btnXoa);
            this.pnlMain.Controls.Add(this.btnDatHang);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
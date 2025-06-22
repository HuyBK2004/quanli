namespace Forms
{
    partial class frmPhieuNhapKho
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThemPhieu = new System.Windows.Forms.Button();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.pnlNhap = new System.Windows.Forms.Panel();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.dgvChiTietNhap = new System.Windows.Forms.DataGridView();
            this.btnXoaChiTiet = new System.Windows.Forms.Button();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.pnlNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 35);
            this.lblTitle.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemPhieu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemPhieu.ForeColor = System.Drawing.Color.White;
            this.btnThemPhieu.Location = new System.Drawing.Point(650, 17);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(120, 35);
            this.btnThemPhieu.TabIndex = 1;
            this.btnThemPhieu.Text = "+ Thêm phiếu";
            this.btnThemPhieu.UseVisualStyleBackColor = false;
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)
            ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(20, 60);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersVisible = false;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(750, 200);
            this.dgvPhieuNhap.TabIndex = 2;
            // 
            // pnlNhap
            // 
            this.pnlNhap.Anchor = ((System.Windows.Forms.AnchorStyles)
            (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNhap.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNhap.Controls.Add(this.lblSanPham);
            this.pnlNhap.Controls.Add(this.cboSanPham);
            this.pnlNhap.Controls.Add(this.lblSoLuong);
            this.pnlNhap.Controls.Add(this.txtSoLuong);
            this.pnlNhap.Controls.Add(this.lblGiaNhap);
            this.pnlNhap.Controls.Add(this.txtGiaNhap);
            this.pnlNhap.Controls.Add(this.btnThemSanPham);
            this.pnlNhap.Controls.Add(this.dgvChiTietNhap);
            this.pnlNhap.Controls.Add(this.btnXoaChiTiet);
            this.pnlNhap.Controls.Add(this.lblGhiChu);
            this.pnlNhap.Controls.Add(this.txtGhiChu);
            this.pnlNhap.Controls.Add(this.btnLuu);
            this.pnlNhap.Location = new System.Drawing.Point(20, 270);
            this.pnlNhap.Name = "pnlNhap";
            this.pnlNhap.Size = new System.Drawing.Size(750, 150);
            this.pnlNhap.TabIndex = 3;
            this.pnlNhap.Visible = false;
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSanPham.Location = new System.Drawing.Point(15, 15);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(75, 19);
            this.lblSanPham.Text = "Sản phẩm:";
            // 
            // cboSanPham
            // 
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboSanPham.Location = new System.Drawing.Point(95, 12);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(140, 28);
            this.cboSanPham.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoLuong.Location = new System.Drawing.Point(250, 15);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(68, 19);
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSoLuong.Location = new System.Drawing.Point(324, 12);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(60, 27);
            this.txtSoLuong.TabIndex = 2;
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiaNhap.Location = new System.Drawing.Point(400, 15);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(64, 19);
            this.lblGiaNhap.Text = "Giá nhập:";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGiaNhap.Location = new System.Drawing.Point(470, 12);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(80, 27);
            this.txtGiaNhap.TabIndex = 3;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemSanPham.ForeColor = System.Drawing.Color.White;
            this.btnThemSanPham.Location = new System.Drawing.Point(570, 10);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(70, 30);
            this.btnThemSanPham.TabIndex = 4;
            this.btnThemSanPham.Text = "Thêm";
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // dgvChiTietNhap
            // 
            this.dgvChiTietNhap.AllowUserToAddRows = false;
            this.dgvChiTietNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhap.Location = new System.Drawing.Point(15, 48);
            this.dgvChiTietNhap.Name = "dgvChiTietNhap";
            this.dgvChiTietNhap.ReadOnly = true;
            this.dgvChiTietNhap.RowHeadersVisible = false;
            this.dgvChiTietNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietNhap.Size = new System.Drawing.Size(625, 60);
            this.dgvChiTietNhap.TabIndex = 5;
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoaChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXoaChiTiet.Location = new System.Drawing.Point(655, 48);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(70, 30);
            this.btnXoaChiTiet.TabIndex = 6;
            this.btnXoaChiTiet.Text = "Xóa";
            this.btnXoaChiTiet.UseVisualStyleBackColor = false;
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGhiChu.Location = new System.Drawing.Point(15, 115);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(58, 19);
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGhiChu.Location = new System.Drawing.Point(80, 112);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(400, 27);
            this.txtGhiChu.TabIndex = 7;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(655, 100);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 35);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(790, 430);
            this.Controls.Add(this.pnlNhap);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.btnThemPhieu);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhieuNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu nhập kho";
            this.Load += new System.EventHandler(this.frmPhieuNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.pnlNhap.ResumeLayout(false);
            this.pnlNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThemPhieu;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Panel pnlNhap;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.DataGridView dgvChiTietNhap;
        private System.Windows.Forms.Button btnXoaChiTiet;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLuu;
    }
}
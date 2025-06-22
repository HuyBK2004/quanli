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
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
    this.lblTongTien = new System.Windows.Forms.Label();
    this.btnThanhToan = new System.Windows.Forms.Button();
    ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
    this.SuspendLayout();
    // 
    // dgvGioHang
    // 
    this.dgvGioHang.AllowUserToAddRows = false;
    this.dgvGioHang.AllowUserToDeleteRows = false;
    this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dgvGioHang.Location = new System.Drawing.Point(12, 12);
    this.dgvGioHang.Name = "dgvGioHang";
    this.dgvGioHang.ReadOnly = true;
    this.dgvGioHang.Size = new System.Drawing.Size(600, 260);
    this.dgvGioHang.TabIndex = 0;
    // 
    // lblTongTien
    // 
    this.lblTongTien.AutoSize = true;
    this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
    this.lblTongTien.Location = new System.Drawing.Point(12, 285);
    this.lblTongTien.Name = "lblTongTien";
    this.lblTongTien.Size = new System.Drawing.Size(90, 17);
    this.lblTongTien.TabIndex = 1;
    this.lblTongTien.Text = "Tổng tiền: 0";
    // 
    // btnThanhToan
    // 
    this.btnThanhToan.Location = new System.Drawing.Point(500, 280);
    this.btnThanhToan.Name = "btnThanhToan";
    this.btnThanhToan.Size = new System.Drawing.Size(112, 32);
    this.btnThanhToan.TabIndex = 2;
    this.btnThanhToan.Text = "Thanh toán";
    this.btnThanhToan.UseVisualStyleBackColor = true;
    this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
    // 
    // frmGioHang
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(624, 321);
    this.Controls.Add(this.btnThanhToan);
    this.Controls.Add(this.lblTongTien);
    this.Controls.Add(this.dgvGioHang);
    this.Name = "frmGioHang";
    this.Text = "Giỏ hàng";
    ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
        }
    }
}

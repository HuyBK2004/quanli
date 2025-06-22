namespace Forms
{
    partial class frmSanPhamKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       private System.Windows.Forms.DataGridView dgvSanPham;
private System.Windows.Forms.Button btnXemGioHang;

private void InitializeComponent()
{
    this.dgvSanPham = new System.Windows.Forms.DataGridView();
    this.btnXemGioHang = new System.Windows.Forms.Button();
    ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
    this.SuspendLayout();
    // 
    // dgvSanPham
    // 
    this.dgvSanPham.AllowUserToAddRows = false;
    this.dgvSanPham.AllowUserToDeleteRows = false;
    this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dgvSanPham.Location = new System.Drawing.Point(12, 12);
    this.dgvSanPham.Name = "dgvSanPham";
    this.dgvSanPham.ReadOnly = true;
    this.dgvSanPham.Size = new System.Drawing.Size(600, 300);
    this.dgvSanPham.TabIndex = 0;
    this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
    // 
    // btnXemGioHang
    // 
    this.btnXemGioHang.Location = new System.Drawing.Point(520, 320);
    this.btnXemGioHang.Name = "btnXemGioHang";
    this.btnXemGioHang.Size = new System.Drawing.Size(92, 32);
    this.btnXemGioHang.TabIndex = 1;
    this.btnXemGioHang.Text = "Xem giỏ hàng";
    this.btnXemGioHang.UseVisualStyleBackColor = true;
    this.btnXemGioHang.Click += new System.EventHandler(this.btnXemGioHang_Click);
    // 
    // frmSanPhamKH
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(624, 361);
    this.Controls.Add(this.btnXemGioHang);
    this.Controls.Add(this.dgvSanPham);
    this.Name = "frmSanPhamKH";
    this.Text = "Sản phẩm";
    ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
    this.ResumeLayout(false);
}
    }
}

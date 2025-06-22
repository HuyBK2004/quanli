namespace Forms
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;
      private System.Windows.Forms.DataGridView dgvHoaDon;
private System.Windows.Forms.TextBox txtMaSP;
private System.Windows.Forms.Button btnTim;
private System.Windows.Forms.Button btnTaoHoaDon;

private void InitializeComponent()
{
    this.dgvHoaDon = new System.Windows.Forms.DataGridView();
    this.txtMaSP = new System.Windows.Forms.TextBox();
    this.btnTim = new System.Windows.Forms.Button();
    this.btnTaoHoaDon = new System.Windows.Forms.Button();
    ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
    this.SuspendLayout();
    // 
    // dgvHoaDon
    // 
    this.dgvHoaDon.AllowUserToAddRows = false;
    this.dgvHoaDon.AllowUserToDeleteRows = false;
    this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dgvHoaDon.Location = new System.Drawing.Point(12, 52);
    this.dgvHoaDon.Name = "dgvHoaDon";
    this.dgvHoaDon.ReadOnly = true;
    this.dgvHoaDon.Size = new System.Drawing.Size(700, 300);
    this.dgvHoaDon.TabIndex = 0;
    // 
    // txtMaSP
    // 
    this.txtMaSP.Location = new System.Drawing.Point(12, 15);
    this.txtMaSP.Name = "txtMaSP";
    this.txtMaSP.Size = new System.Drawing.Size(180, 22);
    this.txtMaSP.TabIndex = 1;
    // 
    // btnTim
    // 
    this.btnTim.Location = new System.Drawing.Point(200, 13);
    this.btnTim.Name = "btnTim";
    this.btnTim.Size = new System.Drawing.Size(90, 26);
    this.btnTim.TabIndex = 2;
    this.btnTim.Text = "Tìm hóa đơn";
    this.btnTim.UseVisualStyleBackColor = true;
    this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
    // 
    // btnTaoHoaDon
    // 
    this.btnTaoHoaDon.Location = new System.Drawing.Point(622, 13);
    this.btnTaoHoaDon.Name = "btnTaoHoaDon";
    this.btnTaoHoaDon.Size = new System.Drawing.Size(90, 26);
    this.btnTaoHoaDon.TabIndex = 3;
    this.btnTaoHoaDon.Text = "Tạo hóa đơn";
    this.btnTaoHoaDon.UseVisualStyleBackColor = true;
    this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
    // 
    // frmHoaDon
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(724, 371);
    this.Controls.Add(this.btnTaoHoaDon);
    this.Controls.Add(this.btnTim);
    this.Controls.Add(this.txtMaSP);
    this.Controls.Add(this.dgvHoaDon);
    this.Name = "frmHoaDon";
    this.Text = "Quản lý hóa đơn";
    ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
}
    }
}

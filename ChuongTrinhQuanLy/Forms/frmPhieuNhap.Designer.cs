using System.Windows.Forms;

namespace Forms
{
    partial class frmPhieuNhap
    {
        private System.ComponentModel.IContainer components = null;
       private System.Windows.Forms.DataGridView dgvPhieuNhap;
private System.Windows.Forms.Button btnDuyet;
private System.Windows.Forms.Button btnTuChoi;

private void InitializeComponent()
{
    this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
    this.btnDuyet = new System.Windows.Forms.Button();
    this.btnTuChoi = new System.Windows.Forms.Button();
    ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
    this.SuspendLayout();
    // 
    // dgvPhieuNhap
    // 
    this.dgvPhieuNhap.AllowUserToAddRows = false;
    this.dgvPhieuNhap.AllowUserToDeleteRows = false;
    this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dgvPhieuNhap.Location = new System.Drawing.Point(12, 12);
    this.dgvPhieuNhap.Name = "dgvPhieuNhap";
    this.dgvPhieuNhap.ReadOnly = true;
    this.dgvPhieuNhap.Size = new System.Drawing.Size(700, 300);
    this.dgvPhieuNhap.TabIndex = 0;
    // 
    // btnDuyet
    // 
    this.btnDuyet.Location = new System.Drawing.Point(500, 320);
    this.btnDuyet.Name = "btnDuyet";
    this.btnDuyet.Size = new System.Drawing.Size(90, 32);
    this.btnDuyet.TabIndex = 1;
    this.btnDuyet.Text = "Duyệt";
    this.btnDuyet.UseVisualStyleBackColor = true;
    this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
    // 
    // btnTuChoi
    // 
    this.btnTuChoi.Location = new System.Drawing.Point(622, 320);
    this.btnTuChoi.Name = "btnTuChoi";
    this.btnTuChoi.Size = new System.Drawing.Size(90, 32);
    this.btnTuChoi.TabIndex = 2;
    this.btnTuChoi.Text = "Từ chối";
    this.btnTuChoi.UseVisualStyleBackColor = true;
    this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);
    // 
    // frmPhieuNhap
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(724, 371);
    this.Controls.Add(this.btnTuChoi);
    this.Controls.Add(this.btnDuyet);
    this.Controls.Add(this.dgvPhieuNhap);
    this.Name = "frmPhieuNhap";
    this.Text = "Duyệt phiếu nhập";
    ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
    this.ResumeLayout(false);
}
    }
}

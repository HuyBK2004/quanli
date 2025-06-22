namespace Forms
{
    partial class frmDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.DataGridView dgvChiTietDH;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.dgvChiTietDH = new System.Windows.Forms.DataGridView();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "ĐƠN HÀNG CỦA TÔI";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.AutoSize = true;

            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(20, 60);
            this.pnlMain.Size = new System.Drawing.Size(860, 370);

            // 
            // dgvDonHang
            // 
            this.dgvDonHang.Location = new System.Drawing.Point(15, 15);
            this.dgvDonHang.Size = new System.Drawing.Size(820, 150);
            this.dgvDonHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDonHang.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvDonHang.SelectionChanged += new System.EventHandler(this.dgvDonHang_SelectionChanged);

            // 
            // dgvChiTietDH
            // 
            this.dgvChiTietDH.Location = new System.Drawing.Point(15, 180);
            this.dgvChiTietDH.Size = new System.Drawing.Size(820, 120);
            this.dgvChiTietDH.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvChiTietDH.ReadOnly = true;
            this.dgvChiTietDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDH.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXemChiTiet.BackColor = System.Drawing.Color.FromArgb(45, 85, 255);
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Location = new System.Drawing.Point(715, 310);
            this.btnXemChiTiet.Size = new System.Drawing.Size(120, 35);
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);

            // 
            // frmDonHang
            // 
            this.Text = "Đơn hàng của tôi";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMain);

            this.pnlMain.Controls.Add(this.dgvDonHang);
            this.pnlMain.Controls.Add(this.dgvChiTietDH);
            this.pnlMain.Controls.Add(this.btnXemChiTiet);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
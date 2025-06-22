using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmPhieuNhap : Form
    {
    private PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();

    public frmPhieuNhap()
    {
        InitializeComponent();
        LoadPhieuNhap();
    }

    private void LoadPhieuNhap()
    {
        dgvPhieuNhap.DataSource = phieuNhapBUS.LayDanhSachPhieuNhap();
    }

    private void btnDuyet_Click(object sender, EventArgs e)
    {
        if (dgvPhieuNhap.SelectedRows.Count > 0)
        {
            int maPN = Convert.ToInt32(dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value);
            phieuNhapBUS.DuyetPhieuNhap(maPN, true);
            MessageBox.Show("Đã duyệt phiếu nhập và cập nhật kho!");
            LoadPhieuNhap();
        }
    }

    private void btnTuChoi_Click(object sender, EventArgs e)
    {
        if (dgvPhieuNhap.SelectedRows.Count > 0)
        {
            int maPN = Convert.ToInt32(dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value);
            phieuNhapBUS.DuyetPhieuNhap(maPN, false);
            MessageBox.Show("Đã từ chối phiếu nhập!");
            LoadPhieuNhap();
        }
    }
    }
}

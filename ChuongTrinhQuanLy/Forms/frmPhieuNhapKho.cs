using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmPhieuNhapKho : Form
    {
       private PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
    private int maNguoiDung;

    public frmPhieuNhapKho(int maND)
    {
        InitializeComponent();
        maNguoiDung = maND;
        LoadPhieuNhap();
    }

    private void LoadPhieuNhap()
    {
        dgvPhieuNhap.DataSource = phieuNhapBUS.LayDanhSachPhieuNhap();
    }

    private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
    {
        // Lấy chi tiết phiếu nhập từ UI
        var dsCT = new List<ChiTietPhieuNhap>();
        // ... code lấy dữ liệu sản phẩm nhập ...
        var pn = new PhieuNhap
        {
            NgayNhap = DateTime.Now,
            MaNguoiDung = maNguoiDung,
            TrangThai = "ChoDuyet"
        };
        int maPN = phieuNhapBUS.TaoPhieuNhap(pn, dsCT);
        if (maPN > 0)
        {
            MessageBox.Show("Tạo phiếu nhập thành công #" + maPN);
            LoadPhieuNhap();
        }
    }
    }
}

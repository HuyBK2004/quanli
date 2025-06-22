using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmHoaDon : Form
    {
       private HoaDonBUS hoaDonBUS = new HoaDonBUS();
    private SanPhamBUS sanPhamBUS = new SanPhamBUS();
    private int maNguoiDung; // Lấy theo tài khoản đăng nhập

    public frmHoaDon(int maND)
    {
        InitializeComponent();
        maNguoiDung = maND;
        LoadDanhSachHoaDon();
    }

    private void LoadDanhSachHoaDon(string maSP = null)
    {
        dgvHoaDon.DataSource = hoaDonBUS.LayDanhSachHoaDon(maSP);
    }

    private void btnTaoHoaDon_Click(object sender, EventArgs e)
    {
        // Lấy danh sách sản phẩm và số lượng từ UI
        var dsCT = new List<ChiTietHoaDon>();
        // ... code lấy dữ liệu từ lưới sản phẩm ...
        int maHD = hoaDonBUS.TaoHoaDon(maNguoiDung, dsCT);
        if (maHD > 0)
        {
            MessageBox.Show("Tạo hóa đơn thành công #" + maHD);
            LoadDanhSachHoaDon();
        }
    }

    private void btnTim_Click(object sender, EventArgs e)
    {
        string maSP = txtMaSP.Text.Trim();
        LoadDanhSachHoaDon(string.IsNullOrEmpty(maSP) ? null : maSP);
    }
    }
}

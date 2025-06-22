using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmGioHang : Form
    {
            private GioHangBUS gioHangBUS = new GioHangBUS();
    private HoaDonBUS hoaDonBUS = new HoaDonBUS();
    private SanPhamBUS sanPhamBUS = new SanPhamBUS();
    private int maNguoiDung;

    public frmGioHang(int maND)
    {
        InitializeComponent();
        maNguoiDung = maND;
        LoadGioHang();
    }

    private void LoadGioHang()
    {
        var dsGio = gioHangBUS.LayGioHang(maNguoiDung);
        var dsView = new List<dynamic>();
        decimal tongTien = 0;
        foreach (var gh in dsGio)
        {
            var sp = sanPhamBUS.TimSanPham(gh.MaSP);
            dsView.Add(new
            {
                gh.MaSP,
                sp.TenSP,
                sp.GiaBan,
                gh.SoLuong,
                ThanhTien = sp.GiaBan * gh.SoLuong
            });
            tongTien += sp.GiaBan * gh.SoLuong;
        }
        dgvGioHang.DataSource = dsView;
        lblTongTien.Text = $"Tổng tiền: {tongTien:N0} đ";
    }

    private void btnThanhToan_Click(object sender, EventArgs e)
    {
        int maHD = hoaDonBUS.ThanhToan(maNguoiDung);
        if (maHD > 0)
        {
            MessageBox.Show("Thanh toán thành công! Đã tạo hóa đơn #" + maHD);
            LoadGioHang();
        }
        else
        {
            MessageBox.Show("Giỏ hàng trống!");
        }
    }
    }
}

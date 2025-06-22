using System.Collections.Generic;

public class GioHang
{
    public List<ChiTietHoaDon> DanhSachHang { get; set; } = new List<ChiTietHoaDon>();

    public void ThemSanPham(SanPham sp, int soLuong)
    {
        var spDaCo = DanhSachHang.Find(h => h.MaSanPham == sp.MaSanPham);
        if (spDaCo != null)
            spDaCo.SoLuong += soLuong;
        else
            DanhSachHang.Add(new ChiTietHoaDon {
                MaSanPham = sp.MaSanPham,
                TenSanPham = sp.TenSanPham,
                DonGia = sp.Gia,
                SoLuong = soLuong
            });
    }
    public void XoaSanPham(string maSanPham)
    {
        DanhSachHang.RemoveAll(h => h.MaSanPham == maSanPham);
    }
    public void Clear()
    {
        DanhSachHang.Clear();
    }
    public decimal TongTien()
    {
        decimal tong = 0;
        foreach (var cthd in DanhSachHang)
            tong += cthd.DonGia * cthd.SoLuong;
        return tong;
    }
}

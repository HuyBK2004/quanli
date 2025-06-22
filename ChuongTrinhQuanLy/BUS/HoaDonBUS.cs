using System;
using System.Collections.Generic;
using DTO;
using DataAccess;

namespace BUS
{
   public class HoaDonBUS
{
    // Thanh toán: tạo hóa đơn từ giỏ hàng của khách hàng
    public int ThanhToan(int maNguoiDung)
    {
        // Lấy giỏ hàng
        var dsGio = GioHangDAO.LayGioHang(maNguoiDung);
        if (dsGio.Count == 0) return -1;

        decimal tongTien = 0;
        foreach (var gh in dsGio)
        {
            SanPham sp = SanPhamDAO.TimSanPham(gh.MaSP);
            tongTien += sp.GiaBan * gh.SoLuong;
        }

        var hd = new HoaDon
        {
            NgayLap = DateTime.Now,
            MaNguoiDung = maNguoiDung,
            TongTien = tongTien
        };
        int maHoaDon = HoaDonDAO.ThemHoaDon(hd);

        foreach (var gh in dsGio)
        {
            SanPham sp = SanPhamDAO.TimSanPham(gh.MaSP);
            HoaDonDAO.ThemChiTietHoaDon(new ChiTietHoaDon
            {
                MaHoaDon = maHoaDon,
                MaSP = gh.MaSP,
                SoLuong = gh.SoLuong,
                DonGia = sp.GiaBan
            });
        }

        GioHangDAO.XoaToanBoGioHang(maNguoiDung);
        return maHoaDon;
    }

    // Tạo hóa đơn thủ công (cho thu ngân)
    public int TaoHoaDon(int maNguoiDung, List<ChiTietHoaDon> dsSanPham)
    {
        decimal tongTien = 0;
        foreach (var ct in dsSanPham)
        {
            tongTien += ct.DonGia * ct.SoLuong;
        }
        var hd = new HoaDon
        {
            NgayLap = DateTime.Now,
            MaNguoiDung = maNguoiDung,
            TongTien = tongTien
        };
        int maHoaDon = HoaDonDAO.ThemHoaDon(hd);

        foreach (var ct in dsSanPham)
        {
            ct.MaHoaDon = maHoaDon;
            HoaDonDAO.ThemChiTietHoaDon(ct);
        }
        return maHoaDon;
    }

    public List<HoaDon> LayDanhSachHoaDon(string maSP = null)
    {
        return HoaDonDAO.LayDanhSachHoaDon(maSP);
    }
}
}

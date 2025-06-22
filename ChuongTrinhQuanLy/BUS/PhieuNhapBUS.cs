using System;
using System.Collections.Generic;
using DTO;
using DataAccess;

namespace BUS
{
    public int TaoPhieuNhap(PhieuNhap pn, List<ChiTietPhieuNhap> dsChiTiet)
    {
        int maPN = PhieuNhapDAO.TaoPhieuNhap(pn);
        foreach (var ct in dsChiTiet)
        {
            ct.MaPhieuNhap = maPN;
            ChiTietPhieuNhapDAO.ThemChiTietPhieuNhap(ct);
        }
        return maPN;
    }

    public List<PhieuNhap> LayDanhSachPhieuNhap()
    {
        return PhieuNhapDAO.LayDanhSachPhieuNhap();
    }

    public void CapNhatTrangThai(int maPN, string trangThai)
    {
        PhieuNhapDAO.CapNhatTrangThai(maPN, trangThai);
    }

    // Duyệt phiếu nhập (chủ cửa hàng)
    public void DuyetPhieuNhap(int maPN, bool chapNhan)
    {
        var dsChiTiet = ChiTietPhieuNhapDAO.LayDanhSachTheoPhieu(maPN);
        foreach (var ct in dsChiTiet)
        {
            var sp = SanPhamDAO.TimSanPham(ct.MaSP);
            if (chapNhan)
            {
                if (sp != null)
                {
                    SanPhamDAO.TangSoLuongSanPham(ct.MaSP, ct.SoLuong);
                }
                else
                {
                    var spMoi = new SanPham
                    {
                        MaSP = ct.MaSP,
                        TenSP = "[Tạo từ phiếu nhập]",
                        MoTa = "",
                        GiaBan = ct.GiaNhap,
                        DonViTinh = "",
                        TrangThai = "DangBan"
                    };
                    SanPhamDAO.ThemSanPham(spMoi);
                }
            }
        }
        PhieuNhapDAO.CapNhatTrangThai(maPN, chapNhan ? "DaDuyet" : "TuChoi");
    }
    
}

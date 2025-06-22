using System;
using System.Collections.Generic;
using DTO;
using DataAccess;

namespace BUS
{

public class SanPhamBUS
{
    public List<SanPham> LayTatCaSanPham()
    {
        return SanPhamDAO.LayTatCaSanPham();
    }

    public SanPham TimSanPham(int maSP)
    {
        return SanPhamDAO.TimSanPham(maSP);
    }

    public void ThemSanPham(SanPham sp)
    {
        SanPhamDAO.ThemSanPham(sp);
    }

    public void TangSoLuongSanPham(int maSP, int soLuong)
    {
        SanPhamDAO.TangSoLuongSanPham(maSP, soLuong);
    }
}
}

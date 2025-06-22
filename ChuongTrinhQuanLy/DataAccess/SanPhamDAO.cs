using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
public class SanPhamDAO
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

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class GioHangDAO
{
        public void ThemVaoGioHang(int maNguoiDung, int maSP, int soLuong)
    {
        GioHangDAO.ThemVaoGioHang(maNguoiDung, maSP, soLuong);
    }

    public void XoaKhoiGioHang(int maNguoiDung, int maSP)
    {
        GioHangDAO.XoaKhoiGioHang(maNguoiDung, maSP);
    }

    public void XoaToanBoGioHang(int maNguoiDung)
    {
        GioHangDAO.XoaToanBoGioHang(maNguoiDung);
    }

    public List<GioHang> LayGioHang(int maNguoiDung)
    {
        return GioHangDAO.LayGioHang(maNguoiDung);
    }
}

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class GioHangDAO
{
    public static void ThemVaoGioHang(int maNguoiDung, int maSP, int soLuong)
    {
        string sql = @"IF EXISTS (SELECT 1 FROM GioHang WHERE MaNguoiDung = @maNguoiDung AND MaSP = @maSP)
                       UPDATE GioHang SET SoLuong = SoLuong + @soLuong WHERE MaNguoiDung = @maNguoiDung AND MaSP = @maSP
                       ELSE
                       INSERT INTO GioHang(MaNguoiDung, MaSP, SoLuong) VALUES(@maNguoiDung, @maSP, @soLuong)";
        DBHelper.ExecuteNonQuery(sql,
            new SqlParameter("@maNguoiDung", maNguoiDung),
            new SqlParameter("@maSP", maSP),
            new SqlParameter("@soLuong", soLuong));
    }

    public static void XoaKhoiGioHang(int maNguoiDung, int maSP)
    {
        string sql = "DELETE FROM GioHang WHERE MaNguoiDung = @maNguoiDung AND MaSP = @maSP";
        DBHelper.ExecuteNonQuery(sql,
            new SqlParameter("@maNguoiDung", maNguoiDung),
            new SqlParameter("@maSP", maSP));
    }

    public static void XoaToanBoGioHang(int maNguoiDung)
    {
        string sql = "DELETE FROM GioHang WHERE MaNguoiDung = @maNguoiDung";
        DBHelper.ExecuteNonQuery(sql,
            new SqlParameter("@maNguoiDung", maNguoiDung));
    }

    public static List<GioHang> LayGioHang(int maNguoiDung)
    {
        List<GioHang> ds = new List<GioHang>();
        string sql = "SELECT * FROM GioHang WHERE MaNguoiDung = @maNguoiDung";
        DataTable dt = DBHelper.ExecuteQuery(sql, new SqlParameter("@maNguoiDung", maNguoiDung));
        foreach (DataRow row in dt.Rows)
        {
            ds.Add(new GioHang
            {
                MaNguoiDung = (int)row["MaNguoiDung"],
                MaSP = (int)row["MaSP"],
                SoLuong = (int)row["SoLuong"]
            });
        }
        return ds;
    }
}

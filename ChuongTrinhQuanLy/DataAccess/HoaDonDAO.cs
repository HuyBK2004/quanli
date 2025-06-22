using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class HoaDonDAO
{
    public static int ThemHoaDon(HoaDon hd)
    {
        string sql = "INSERT INTO HoaDon(NgayLap, MaNguoiDung, TongTien) OUTPUT INSERTED.MaHoaDon VALUES(@NgayLap, @MaNguoiDung, @TongTien)";
        var maHoaDon = (int)DBHelper.ExecuteScalar(sql,
            new SqlParameter("@NgayLap", hd.NgayLap),
            new SqlParameter("@MaNguoiDung", hd.MaNguoiDung),
            new SqlParameter("@TongTien", hd.TongTien));
        return maHoaDon;
    }

    public static void ThemChiTietHoaDon(ChiTietHoaDon ct)
    {
        string sql = "INSERT INTO ChiTietHoaDon(MaHoaDon, MaSP, SoLuong, DonGia) VALUES(@MaHoaDon, @MaSP, @SoLuong, @DonGia)";
        DBHelper.ExecuteNonQuery(sql,
            new SqlParameter("@MaHoaDon", ct.MaHoaDon),
            new SqlParameter("@MaSP", ct.MaSP),
            new SqlParameter("@SoLuong", ct.SoLuong),
            new SqlParameter("@DonGia", ct.DonGia));
    }

    public static List<HoaDon> LayDanhSachHoaDon(string maSP = null)
    {
        var ds = new List<HoaDon>();
        string sql = "SELECT DISTINCT hd.* FROM HoaDon hd INNER JOIN ChiTietHoaDon ct ON hd.MaHoaDon = ct.MaHoaDon";
        if (!string.IsNullOrEmpty(maSP))
            sql += " WHERE ct.MaSP = @maSP";
        DataTable dt = DBHelper.ExecuteQuery(sql,
            string.IsNullOrEmpty(maSP) ? null : new SqlParameter("@maSP", maSP));
        foreach (DataRow row in dt.Rows)
        {
            ds.Add(new HoaDon
            {
                MaHoaDon = (int)row["MaHoaDon"],
                NgayLap = (DateTime)row["NgayLap"],
                MaNguoiDung = (int)row["MaNguoiDung"],
                TongTien = (decimal)row["TongTien"]
            });
        }
        return ds;
    }
}

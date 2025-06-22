using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class ChiTietPhieuNhapDAO
{
    public static void ThemChiTietPhieuNhap(ChiTietPhieuNhap ct)
    {
        string sql = "INSERT INTO ChiTietPhieuNhap(MaPhieuNhap, MaSP, SoLuong, GiaNhap) VALUES(@MaPhieuNhap, @MaSP, @SoLuong, @GiaNhap)";
        DBHelper.ExecuteNonQuery(sql,
            new SqlParameter("@MaPhieuNhap", ct.MaPhieuNhap),
            new SqlParameter("@MaSP", ct.MaSP),
            new SqlParameter("@SoLuong", ct.SoLuong),
            new SqlParameter("@GiaNhap", ct.GiaNhap));
    }

    public static List<ChiTietPhieuNhap> LayDanhSachTheoPhieu(int maPN)
    {
        var ds = new List<ChiTietPhieuNhap>();
        string sql = "SELECT * FROM ChiTietPhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap";
        DataTable dt = DBHelper.ExecuteQuery(sql, new SqlParameter("@MaPhieuNhap", maPN));
        foreach (DataRow row in dt.Rows)
        {
            ds.Add(new ChiTietPhieuNhap
            {
                MaPhieuNhap = (int)row["MaPhieuNhap"],
                MaSP = (int)row["MaSP"],
                SoLuong = (int)row["SoLuong"],
                GiaNhap = (decimal)row["GiaNhap"]
            });
        }
        return ds;
    }
}

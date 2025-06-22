using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class PhieuNhapDAO
{
    public static int TaoPhieuNhap(PhieuNhap pn)
    {
        string sql = "INSERT INTO PhieuNhap(NgayNhap, MaNguoiDung, TrangThai) OUTPUT INSERTED.MaPhieuNhap VALUES(@NgayNhap, @MaNguoiDung, @TrangThai)";
        var maPN = (int)DBHelper.ExecuteScalar(sql,
            new SqlParameter("@NgayNhap", pn.NgayNhap),
            new SqlParameter("@MaNguoiDung", pn.MaNguoiDung),
            new SqlParameter("@TrangThai", pn.TrangThai));
        return maPN;
    }

    public static List<PhieuNhap> LayDanhSachPhieuNhap()
    {
        var ds = new List<PhieuNhap>();
        string sql = "SELECT * FROM PhieuNhap";
        DataTable dt = DBHelper.ExecuteQuery(sql);
        foreach (DataRow row in dt.Rows)
        {
            ds.Add(new PhieuNhap
            {
                MaPhieuNhap = (int)row["MaPhieuNhap"],
                NgayNhap = (DateTime)row["NgayNhap"],
                MaNguoiDung = (int)row["MaNguoiDung"],
                TrangThai = row["TrangThai"].ToString()
            });
        }
        return ds;
    }

    public static void CapNhatTrangThai(int maPN, string trangThai)
    {
        string sql = "UPDATE PhieuNhap SET TrangThai = @TrangThai WHERE MaPhieuNhap = @MaPhieuNhap";
        DBHelper.ExecuteNonQuery(sql,
            new SqlParameter("@TrangThai", trangThai),
            new SqlParameter("@MaPhieuNhap", maPN));
    }
}

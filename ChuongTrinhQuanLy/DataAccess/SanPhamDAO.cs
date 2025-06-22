using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class SanPhamDAO
{
    public static List<SanPham> LayTatCaSanPham()
    {
        List<SanPham> ds = new List<SanPham>();
        string sql = "SELECT * FROM SanPham WHERE TrangThai = 'DangBan'";
        DataTable dt = DBHelper.ExecuteQuery(sql);
        foreach (DataRow row in dt.Rows)
        {
            ds.Add(new SanPham
            {
                MaSP = (int)row["MaSP"],
                TenSP = row["TenSP"].ToString(),
                MoTa = row["MoTa"].ToString(),
                GiaBan = (decimal)row["GiaBan"],
                DonViTinh = row["DonViTinh"].ToString(),
                TrangThai = row["TrangThai"].ToString()
            });
        }
        return ds;
    }

    public static void TangSoLuongSanPham(int maSP, int soLuong)
    {
        string sql = "UPDATE SanPham SET SoLuong = SoLuong + @soLuong WHERE MaSP = @maSP";
        DBHelper.ExecuteNonQuery(sql,
            new SqlParameter("@soLuong", soLuong),
            new SqlParameter("@maSP", maSP));
    }

    public static void ThemSanPham(SanPham sp)
    {
        string sql = "INSERT INTO SanPham(TenSP, MoTa, GiaBan, DonViTinh, TrangThai) VALUES(@TenSP, @MoTa, @GiaBan, @DonViTinh, @TrangThai)";
        DBHelper.ExecuteNonQuery(sql,
            new SqlParameter("@TenSP", sp.TenSP),
            new SqlParameter("@MoTa", sp.MoTa),
            new SqlParameter("@GiaBan", sp.GiaBan),
            new SqlParameter("@DonViTinh", sp.DonViTinh),
            new SqlParameter("@TrangThai", sp.TrangThai));
    }

    public static SanPham TimSanPham(int maSP)
    {
        string sql = "SELECT * FROM SanPham WHERE MaSP = @maSP";
        DataTable dt = DBHelper.ExecuteQuery(sql, new SqlParameter("@maSP", maSP));
        if (dt.Rows.Count == 0) return null;
        DataRow row = dt.Rows[0];
        return new SanPham
        {
            MaSP = (int)row["MaSP"],
            TenSP = row["TenSP"].ToString(),
            MoTa = row["MoTa"].ToString(),
            GiaBan = (decimal)row["GiaBan"],
            DonViTinh = row["DonViTinh"].ToString(),
            TrangThai = row["TrangThai"].ToString()
        };
    }
}

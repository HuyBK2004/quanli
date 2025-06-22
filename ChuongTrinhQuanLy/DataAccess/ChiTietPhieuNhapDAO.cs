using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;
using System;

namespace DataAccess
{
    public class ChiTietPhieuNhapDAO
    {
        public static List<ChiTietPhieuNhap> GetByPhieu(int maPhieuNhap)
        {
            string sql = @"SELECT c.*, s.TenSP FROM ChiTietPhieuNhap c
                           JOIN SanPham s ON c.MaSP = s.MaSP
                           WHERE c.MaPhieuNhap = @MaPhieuNhap";
            var dt = DBHelper.ExecuteQuery(sql, new MySqlParameter("@MaPhieuNhap", maPhieuNhap));
            var list = new List<ChiTietPhieuNhap>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ChiTietPhieuNhap
                {
                    MaPhieuNhap = (int)row["MaPhieuNhap"],
                    MaSP = (int)row["MaSP"],
                    TenSP = row["TenSP"].ToString(),
                    SoLuong = (int)row["SoLuong"],
                    GiaNhap = (decimal)row["GiaNhap"]
                });
            }
            return list;
        }

        // Thêm chi ti?t phi?u nh?p (dùng cho transaction)
        public static void Insert(ChiTietPhieuNhap ct, int maPhieuNhap, MySqlConnection conn, MySqlTransaction trans)
        {
            string sql = @"INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaSP, SoLuong, GiaNhap)
                           VALUES (@MaPhieuNhap, @MaSP, @SoLuong, @GiaNhap)";
            var cmd = new MySqlCommand(sql, conn, trans);
            cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
            cmd.Parameters.AddWithValue("@MaSP", ct.MaSP);
            cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
            cmd.Parameters.AddWithValue("@GiaNhap", ct.GiaNhap);
            cmd.ExecuteNonQuery();
        }

        // Thêm cho tr??ng h?p thêm t?ng dòng (không dùng transaction)
        public static bool Insert(ChiTietPhieuNhap ct)
        {
            string sql = @"INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaSP, SoLuong, GiaNhap)
                           VALUES (@MaPhieuNhap, @MaSP, @SoLuong, @GiaNhap)";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@MaPhieuNhap", ct.MaPhieuNhap),
                new MySqlParameter("@MaSP", ct.MaSP),
                new MySqlParameter("@SoLuong", ct.SoLuong),
                new MySqlParameter("@GiaNhap", ct.GiaNhap)
            );
            return res > 0;
        }

        public static bool Update(ChiTietPhieuNhap ct)
        {
            string sql = @"UPDATE ChiTietPhieuNhap SET SoLuong=@SoLuong, GiaNhap=@GiaNhap
                           WHERE MaPhieuNhap=@MaPhieuNhap AND MaSP=@MaSP";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@SoLuong", ct.SoLuong),
                new MySqlParameter("@GiaNhap", ct.GiaNhap),
                new MySqlParameter("@MaPhieuNhap", ct.MaPhieuNhap),
                new MySqlParameter("@MaSP", ct.MaSP)
            );
            return res > 0;
        }

        public static bool Delete(int maPhieuNhap, int maSP)
        {
            string sql = @"DELETE FROM ChiTietPhieuNhap WHERE MaPhieuNhap=@MaPhieuNhap AND MaSP=@MaSP";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@MaPhieuNhap", maPhieuNhap),
                new MySqlParameter("@MaSP", maSP)
            );
            return res > 0;
        }

        internal static List<ChiTietPhieuNhap> GetByPhieuNhap(int maPhieuNhap)
        {
            throw new NotImplementedException();
        }
    }
}
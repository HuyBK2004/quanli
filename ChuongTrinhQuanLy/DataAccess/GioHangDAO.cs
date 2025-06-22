using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DataAccess
{
    public class GioHangDAO
    {
        public static List<GioHang> GetByUser(int maNguoiDung)
        {
            string sql = "SELECT * FROM GioHang WHERE MaNguoiDung=@ID";
            var dt = DBHelper.ExecuteQuery(sql, new MySqlParameter("@ID", maNguoiDung));
            var list = new List<GioHang>();
            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));
            return list;
        }

        public static bool Insert(GioHang gh)
        {
            string sql = @"INSERT INTO GioHang (MaNguoiDung, MaSP, SoLuong)
                        VALUES (@MaNguoiDung, @MaSP, @SoLuong)";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@MaNguoiDung", gh.MaNguoiDung),
                new MySqlParameter("@MaSP", gh.MaSP),
                new MySqlParameter("@SoLuong", gh.SoLuong)
            );
            return res > 0;
        }

        public static bool Update(GioHang gh)
        {
            string sql = @"UPDATE GioHang SET SoLuong=@SoLuong
                           WHERE MaNguoiDung=@MaNguoiDung AND MaSP=@MaSP";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@SoLuong", gh.SoLuong),
                new MySqlParameter("@MaNguoiDung", gh.MaNguoiDung),
                new MySqlParameter("@MaSP", gh.MaSP)
            );
            return res > 0;
        }

        public static bool Delete(int maNguoiDung, int maSP)
        {
            string sql = "DELETE FROM GioHang WHERE MaNguoiDung=@MaNguoiDung AND MaSP=@MaSP";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@MaNguoiDung", maNguoiDung),
                new MySqlParameter("@MaSP", maSP)
            );
            return res > 0;
        }

        public static bool Clear(int maNguoiDung)
        {
            string sql = "DELETE FROM GioHang WHERE MaNguoiDung=@MaNguoiDung";
            int res = DBHelper.ExecuteNonQuery(sql, new MySqlParameter("@MaNguoiDung", maNguoiDung));
            return res > 0;
        }

        private static GioHang Map(DataRow row)
        {
            return new GioHang
            {
                MaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]),
                MaSP = Convert.ToInt32(row["MaSP"]),
                SoLuong = Convert.ToInt32(row["SoLuong"])
            };
        }
    }
}
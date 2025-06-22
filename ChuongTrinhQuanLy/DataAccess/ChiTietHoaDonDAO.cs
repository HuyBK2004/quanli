using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DataAccess
{
    public class ChiTietHoaDonDAO
    {
        public static List<ChiTietHoaDon> GetByHoaDon(int maHoaDon)
        {
            string sql = "SELECT * FROM ChiTietHoaDon WHERE MaHoaDon=@ID";
            var dt = DBHelper.ExecuteQuery(sql, new MySqlParameter("@ID", maHoaDon));
            var list = new List<ChiTietHoaDon>();
            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));
            return list;
        }

        public static bool Insert(ChiTietHoaDon ct)
        {
            string sql = @"INSERT INTO ChiTietHoaDon (MaHoaDon, MaSP, SoLuong, DonGia)
                        VALUES (@MaHoaDon, @MaSP, @SoLuong, @DonGia)";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@MaHoaDon", ct.MaHoaDon),
                new MySqlParameter("@MaSP", ct.MaSP),
                new MySqlParameter("@SoLuong", ct.SoLuong),
                new MySqlParameter("@DonGia", ct.DonGia)
            );
            return res > 0;
        }

        public static bool Update(ChiTietHoaDon ct)
        {
            string sql = @"UPDATE ChiTietHoaDon SET SoLuong=@SoLuong, DonGia=@DonGia 
                           WHERE MaHoaDon=@MaHoaDon AND MaSP=@MaSP";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@SoLuong", ct.SoLuong),
                new MySqlParameter("@DonGia", ct.DonGia),
                new MySqlParameter("@MaHoaDon", ct.MaHoaDon),
                new MySqlParameter("@MaSP", ct.MaSP)
            );
            return res > 0;
        }

        public static bool Delete(int maHoaDon, int maSP)
        {
            string sql = "DELETE FROM ChiTietHoaDon WHERE MaHoaDon=@MaHoaDon AND MaSP=@MaSP";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@MaHoaDon", maHoaDon),
                new MySqlParameter("@MaSP", maSP)
            );
            return res > 0;
        }

        private static ChiTietHoaDon Map(DataRow row)
        {
            return new ChiTietHoaDon
            {
                MaHoaDon = Convert.ToInt32(row["MaHoaDon"]),
                MaSP = Convert.ToInt32(row["MaSP"]),
                SoLuong = Convert.ToInt32(row["SoLuong"]),
                DonGia = Convert.ToDecimal(row["DonGia"])
            };
        }
    }
}
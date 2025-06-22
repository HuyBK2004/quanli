using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DataAccess
{
    public class ChiTietDonHangDAO
    {
        public static List<ChiTietDonHang> GetByDonHang(int maDonHang)
        {
            string sql = "SELECT * FROM ChiTietDonHang WHERE MaDonHang=@ID";
            var dt = DBHelper.ExecuteQuery(sql, new MySqlParameter("@ID", maDonHang));
            var list = new List<ChiTietDonHang>();
            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));
            return list;
        }

        public static bool Insert(ChiTietDonHang ct)
        {
            string sql = @"INSERT INTO ChiTietDonHang (MaDonHang, MaSP, SoLuong, DonGia)
                        VALUES (@MaDonHang, @MaSP, @SoLuong, @DonGia)";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@MaDonHang", ct.MaDonHang),
                new MySqlParameter("@MaSP", ct.MaSP),
                new MySqlParameter("@SoLuong", ct.SoLuong),
                new MySqlParameter("@DonGia", ct.DonGia)
            );
            return res > 0;
        }

        public static bool Update(ChiTietDonHang ct)
        {
            string sql = @"UPDATE ChiTietDonHang SET SoLuong=@SoLuong, DonGia=@DonGia 
                           WHERE MaDonHang=@MaDonHang AND MaSP=@MaSP";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@SoLuong", ct.SoLuong),
                new MySqlParameter("@DonGia", ct.DonGia),
                new MySqlParameter("@MaDonHang", ct.MaDonHang),
                new MySqlParameter("@MaSP", ct.MaSP)
            );
            return res > 0;
        }

        public static bool Delete(int maDonHang, int maSP)
        {
            string sql = "DELETE FROM ChiTietDonHang WHERE MaDonHang=@MaDonHang AND MaSP=@MaSP";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@MaDonHang", maDonHang),
                new MySqlParameter("@MaSP", maSP)
            );
            return res > 0;
        }

        private static ChiTietDonHang Map(DataRow row)
        {
            return new ChiTietDonHang
            {
                MaDonHang = Convert.ToInt32(row["MaDonHang"]),
                MaSP = Convert.ToInt32(row["MaSP"]),
                SoLuong = Convert.ToInt32(row["SoLuong"]),
                DonGia = Convert.ToDecimal(row["DonGia"])
            };
        }
    }
}
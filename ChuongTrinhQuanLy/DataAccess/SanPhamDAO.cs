using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DataAccess
{
    /// <summary>
    /// DAO cho các thao tác với bảng SanPham
    /// </summary>
    public class SanPhamDAO
    {
        public static List<SanPham> GetAll()
        {
            string sql = "SELECT * FROM SanPham";
            var table = DBHelper.ExecuteQuery(sql);
            var list = new List<SanPham>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(Map(row));
            }
            return list;
        }

        public static SanPham GetById(int id)
        {
            string sql = "SELECT * FROM SanPham WHERE MaSP = @ID";
            var table = DBHelper.ExecuteQuery(sql, new MySqlParameter("@ID", id));
            if (table.Rows.Count == 0) return null;
            return Map(table.Rows[0]);
        }

        public static bool Insert(SanPham sp)
        {
            string sql = @"INSERT INTO SanPham (TenSP, MoTa, GiaBan, DonViTinh, TrangThai)
                        VALUES (@TenSP, @MoTa, @GiaBan, @DonViTinh, @TrangThai)";
            int res = DBHelper.ExecuteNonQuery(sql,
                    new MySqlParameter("@TenSP", sp.TenSP),
                    new MySqlParameter("@MoTa", (object)sp.MoTa ?? DBNull.Value),
                    new MySqlParameter("@GiaBan", sp.GiaBan),
                    new MySqlParameter("@DonViTinh", (object)sp.DonViTinh ?? DBNull.Value),
                    new MySqlParameter("@TrangThai", sp.TrangThai)
            );
            return res > 0;
        }

        public static bool Update(SanPham sp)
        {
            string sql = @"UPDATE SanPham SET TenSP=@TenSP, MoTa=@MoTa, GiaBan=@GiaBan, DonViTinh=@DonViTinh, TrangThai=@TrangThai
                           WHERE MaSP=@ID";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@TenSP", sp.TenSP),
                new MySqlParameter("@MoTa", (object)sp.MoTa ?? DBNull.Value),
                new MySqlParameter("@GiaBan", sp.GiaBan),
                new MySqlParameter("@DonViTinh", (object)sp.DonViTinh ?? DBNull.Value),
                new MySqlParameter("@TrangThai", sp.TrangThai),
                new MySqlParameter("@ID", sp.MaSP)
            );
            return res > 0;
        }

        public static bool Delete(int id)
        {
            string sql = "DELETE FROM SanPham WHERE MaSP=@ID";
            int res = DBHelper.ExecuteNonQuery(sql, new MySqlParameter("@ID", id));
            return res > 0;
        }

        public static List<SanPham> Search(string keyword, string trangThai = null)
        {
            string sql = "SELECT * FROM SanPham WHERE TenSP LIKE @kw";
            if (!string.IsNullOrEmpty(trangThai))
                sql += " AND TrangThai=@TrangThai";
            var list = new List<SanPham>();
            var dt = DBHelper.ExecuteQuery(sql,
                new MySqlParameter("@kw", "%" + keyword + "%"),
                new MySqlParameter("@TrangThai", (object)trangThai ?? DBNull.Value)
            );
            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));
            return list;
        }

        private static SanPham Map(DataRow row)
        {
            return new SanPham
            {
                MaSP = Convert.ToInt32(row["MaSP"]),
                TenSP = row["TenSP"].ToString(),
                MoTa = row["MoTa"] == DBNull.Value ? null : row["MoTa"].ToString(),
                GiaBan = Convert.ToDecimal(row["GiaBan"]),
                DonViTinh = row["DonViTinh"] == DBNull.Value ? null : row["DonViTinh"].ToString(),
                TrangThai = row["TrangThai"].ToString()
            };
        }
    }
}
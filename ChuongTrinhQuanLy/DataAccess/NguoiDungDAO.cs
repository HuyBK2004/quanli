using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DataAccess
{
    /// <summary>
    /// DAO cho các thao tác với bảng NguoiDung
    /// </summary>
    public class NguoiDungDAO
    {
        public static List<NguoiDung> GetAll()
        {
            string sql = "SELECT * FROM NguoiDung";
            var table = DBHelper.ExecuteQuery(sql);
            var list = new List<NguoiDung>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(Map(row));
            }
            return list;
        }

        public static NguoiDung GetByUsername(string username)
        {
            string sql = "SELECT * FROM NguoiDung WHERE Username = @Username";
            var table = DBHelper.ExecuteQuery(sql, new MySqlParameter("@Username", username));
            if (table.Rows.Count == 0) return null;
            return Map(table.Rows[0]);
        }

        public static NguoiDung GetById(int id)
        {
            string sql = "SELECT * FROM NguoiDung WHERE MaNguoiDung = @ID";
            var table = DBHelper.ExecuteQuery(sql, new MySqlParameter("@ID", id));
            if (table.Rows.Count == 0) return null;
            return Map(table.Rows[0]);
        }

        public static bool Insert(NguoiDung user)
        {
            string sql = @"INSERT INTO NguoiDung (HoTen, Username, MatKhau, Email, SoDienThoai, VaiTro, TrangThai)
                        VALUES (@HoTen, @Username, @MatKhau, @Email, @SoDienThoai, @VaiTro, @TrangThai)";
            int res = DBHelper.ExecuteNonQuery(sql,
                    new MySqlParameter("@HoTen", user.HoTen),
                    new MySqlParameter("@Username", user.Username),
                    new MySqlParameter("@MatKhau", user.MatKhau),
                    new MySqlParameter("@Email", (object)user.Email ?? DBNull.Value),
                    new MySqlParameter("@SoDienThoai", (object)user.SoDienThoai ?? DBNull.Value),
                    new MySqlParameter("@VaiTro", user.VaiTro),
                    new MySqlParameter("@TrangThai", user.TrangThai)
            );
            return res > 0;
        }

        public static bool Update(NguoiDung user)
        {
            string sql = @"UPDATE NguoiDung SET HoTen=@HoTen, MatKhau=@MatKhau, Email=@Email, SoDienThoai=@SoDienThoai, VaiTro=@VaiTro, TrangThai=@TrangThai
                           WHERE MaNguoiDung=@ID";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@HoTen", user.HoTen),
                new MySqlParameter("@MatKhau", user.MatKhau),
                new MySqlParameter("@Email", (object)user.Email ?? DBNull.Value),
                new MySqlParameter("@SoDienThoai", (object)user.SoDienThoai ?? DBNull.Value),
                new MySqlParameter("@VaiTro", user.VaiTro),
                new MySqlParameter("@TrangThai", user.TrangThai),
                new MySqlParameter("@ID", user.MaNguoiDung)
            );
            return res > 0;
        }

        public static bool Delete(int id)
        {
            string sql = "DELETE FROM NguoiDung WHERE MaNguoiDung=@ID";
            int res = DBHelper.ExecuteNonQuery(sql, new MySqlParameter("@ID", id));
            return res > 0;
        }

        public static List<NguoiDung> Search(string keyword, string vaiTro = null)
        {
            string sql = "SELECT * FROM NguoiDung WHERE (HoTen LIKE @kw OR Username LIKE @kw)";
            if (!string.IsNullOrEmpty(vaiTro))
                sql += " AND VaiTro=@VaiTro";
            var list = new List<NguoiDung>();
            var dt = DBHelper.ExecuteQuery(sql,
                new MySqlParameter("@kw", "%" + keyword + "%"),
                new MySqlParameter("@VaiTro", (object)vaiTro ?? DBNull.Value)
            );
            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));
            return list;
        }

        private static NguoiDung Map(DataRow row)
        {
            return new NguoiDung
            {
                MaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]),
                HoTen = row["HoTen"].ToString(),
                Username = row["Username"].ToString(),
                MatKhau = row["MatKhau"].ToString(),
                Email = row["Email"] == DBNull.Value ? null : row["Email"].ToString(),
                SoDienThoai = row["SoDienThoai"] == DBNull.Value ? null : row["SoDienThoai"].ToString(),
                VaiTro = row["VaiTro"].ToString(),
                NgayTao = Convert.ToDateTime(row["NgayTao"]),
                TrangThai = row["TrangThai"].ToString()
            };
        }

        public static NguoiDung GetByEmail(string email)
        {
            string sql = "SELECT * FROM NguoiDung WHERE Email = @Email";
            var table = DBHelper.ExecuteQuery(sql, new MySqlParameter("@Email", email));
            if (table.Rows.Count == 0) return null;
            return Map(table.Rows[0]);
        }
    }
}
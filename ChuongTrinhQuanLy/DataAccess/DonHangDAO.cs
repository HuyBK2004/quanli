using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DataAccess
{
    public class DonHangDAO
    {
        public static List<DonHang> GetAll()
        {
            string sql = "SELECT * FROM DonHang";
            var dt = DBHelper.ExecuteQuery(sql);
            var list = new List<DonHang>();
            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));
            return list;
        }

        public static DonHang GetById(int id)
        {
            string sql = "SELECT * FROM DonHang WHERE MaDonHang=@ID";
            var dt = DBHelper.ExecuteQuery(sql, new MySqlParameter("@ID", id));
            if (dt.Rows.Count == 0) return null;
            return Map(dt.Rows[0]);
        }

        public static int Insert(DonHang dh)
        {
            string sql = @"INSERT INTO DonHang (NgayDat, MaNguoiDung, TrangThai, TongTien)
                           VALUES (@NgayDat, @MaNguoiDung, @TrangThai, @TongTien)";
            DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@NgayDat", dh.NgayDat),
                new MySqlParameter("@MaNguoiDung", dh.MaNguoiDung),
                new MySqlParameter("@TrangThai", dh.TrangThai),
                new MySqlParameter("@TongTien", dh.TongTien)
            );
            return Convert.ToInt32(DBHelper.ExecuteScalar("SELECT LAST_INSERT_ID()"));
        }

        public static bool Update(DonHang dh)
        {
            string sql = @"UPDATE DonHang SET NgayDat=@NgayDat, MaNguoiDung=@MaNguoiDung, TrangThai=@TrangThai, TongTien=@TongTien
                           WHERE MaDonHang=@ID";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@NgayDat", dh.NgayDat),
                new MySqlParameter("@MaNguoiDung", dh.MaNguoiDung),
                new MySqlParameter("@TrangThai", dh.TrangThai),
                new MySqlParameter("@TongTien", dh.TongTien),
                new MySqlParameter("@ID", dh.MaDonHang)
            );
            return res > 0;
        }

        public static bool Delete(int id)
        {
            string sql = "DELETE FROM DonHang WHERE MaDonHang=@ID";
            int res = DBHelper.ExecuteNonQuery(sql, new MySqlParameter("@ID", id));
            return res > 0;
        }

        public static List<DonHang> Search(DateTime? from, DateTime? to, int? maNguoiDung = null)
        {
            string sql = "SELECT * FROM DonHang WHERE 1=1";
            var param = new List<MySqlParameter>();
            if (from.HasValue)
            {
                sql += " AND NgayDat >= @from";
                param.Add(new MySqlParameter("@from", from.Value));
            }
            if (to.HasValue)
            {
                sql += " AND NgayDat <= @to";
                param.Add(new MySqlParameter("@to", to.Value));
            }
            if (maNguoiDung.HasValue)
            {
                sql += " AND MaNguoiDung=@MaNguoiDung";
                param.Add(new MySqlParameter("@MaNguoiDung", maNguoiDung.Value));
            }
            var dt = DBHelper.ExecuteQuery(sql, param.ToArray());
            var list = new List<DonHang>();
            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));
            return list;
        }

        private static DonHang Map(DataRow row)
        {
            return new DonHang
            {
                MaDonHang = Convert.ToInt32(row["MaDonHang"]),
                NgayDat = Convert.ToDateTime(row["NgayDat"]),
                MaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]),
                TrangThai = row["TrangThai"].ToString(),
                TongTien = Convert.ToDecimal(row["TongTien"])
            };
        }
    }
}
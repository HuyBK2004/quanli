using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DataAccess
{
    public class HoaDonDAO
    {
        public static List<HoaDon> GetAll()
        {
            string sql = "SELECT * FROM HoaDon";
            var dt = DBHelper.ExecuteQuery(sql);
            var list = new List<HoaDon>();
            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));
            return list;
        }

        public static HoaDon GetById(int id)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaHoaDon=@ID";
            var dt = DBHelper.ExecuteQuery(sql, new MySqlParameter("@ID", id));
            if (dt.Rows.Count == 0) return null;
            return Map(dt.Rows[0]);
        }

        public static int Insert(HoaDon hd)
        {
            string sql = @"INSERT INTO HoaDon (NgayLap, MaNguoiDung, TongTien)
                           VALUES (@NgayLap, @MaNguoiDung, @TongTien)";
            DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@NgayLap", hd.NgayLap),
                new MySqlParameter("@MaNguoiDung", hd.MaNguoiDung),
                new MySqlParameter("@TongTien", hd.TongTien)
            );
            return Convert.ToInt32(DBHelper.ExecuteScalar("SELECT LAST_INSERT_ID()"));
        }

        public static bool Update(HoaDon hd)
        {
            string sql = @"UPDATE HoaDon SET NgayLap=@NgayLap, MaNguoiDung=@MaNguoiDung, TongTien=@TongTien
                           WHERE MaHoaDon=@ID";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@NgayLap", hd.NgayLap),
                new MySqlParameter("@MaNguoiDung", hd.MaNguoiDung),
                new MySqlParameter("@TongTien", hd.TongTien),
                new MySqlParameter("@ID", hd.MaHoaDon)
            );
            return res > 0;
        }

        public static bool Delete(int id)
        {
            string sql = "DELETE FROM HoaDon WHERE MaHoaDon=@ID";
            int res = DBHelper.ExecuteNonQuery(sql, new MySqlParameter("@ID", id));
            return res > 0;
        }

        public static List<HoaDon> Search(DateTime? from, DateTime? to)
        {
            string sql = "SELECT * FROM HoaDon WHERE 1=1";
            var param = new List<MySqlParameter>();
            if (from.HasValue)
            {
                sql += " AND NgayLap >= @from";
                param.Add(new MySqlParameter("@from", from.Value));
            }
            if (to.HasValue)
            {
                sql += " AND NgayLap <= @to";
                param.Add(new MySqlParameter("@to", to.Value));
            }
            var dt = DBHelper.ExecuteQuery(sql, param.ToArray());
            var list = new List<HoaDon>();
            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));
            return list;
        }

        private static HoaDon Map(DataRow row)
        {
            return new HoaDon
            {
                MaHoaDon = Convert.ToInt32(row["MaHoaDon"]),
                NgayLap = Convert.ToDateTime(row["NgayLap"]),
                MaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]),
                TongTien = Convert.ToDecimal(row["TongTien"])
            };
        }
    }
}
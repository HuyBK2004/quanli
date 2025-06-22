using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DataAccess
{
    public class PhieuNhapDAO
    {
        public static List<PhieuNhap> GetAll()
        {
            string sql = "SELECT * FROM PhieuNhap";
            var dt = DBHelper.ExecuteQuery(sql);
            var list = new List<PhieuNhap>();
            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));
            return list;
        }

        public static PhieuNhap GetById(int id)
        {
            string sql = "SELECT * FROM PhieuNhap WHERE MaPhieuNhap=@ID";
            var dt = DBHelper.ExecuteQuery(sql, new MySqlParameter("@ID", id));
            if (dt.Rows.Count == 0) return null;
            return Map(dt.Rows[0]);
        }

        public static List<PhieuNhap> GetByNguoiDung(int maNguoiDung)
        {
            string sql = "SELECT * FROM PhieuNhap WHERE MaNguoiDung=@MaNguoiDung ORDER BY NgayNhap DESC";
            var dt = DBHelper.ExecuteQuery(sql, new MySqlParameter("@MaNguoiDung", maNguoiDung));
            var list = new List<PhieuNhap>();
            foreach (DataRow row in dt.Rows)
            {
                var phieu = Map(row);
                phieu.ChiTietPhieuNhap = ChiTietPhieuNhapDAO.GetByPhieu(phieu.MaPhieuNhap);
                list.Add(phieu);
            }
            return list;
        }

        public static int Insert(PhieuNhap pn)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string sql = "INSERT INTO PhieuNhap (MaNguoiDung, TrangThai) VALUES (@MaNguoiDung, @TrangThai); SELECT LAST_INSERT_ID();";
                        var cmd = new MySqlCommand(sql, conn, trans);
                        cmd.Parameters.AddWithValue("@MaNguoiDung", pn.MaNguoiDung);
                        cmd.Parameters.AddWithValue("@TrangThai", pn.TrangThai);
                        int maPhieuNhap = Convert.ToInt32(cmd.ExecuteScalar());

                        if (pn.ChiTietPhieuNhap != null)
                        {
                            foreach (var ct in pn.ChiTietPhieuNhap)
                            {
                                ChiTietPhieuNhapDAO.Insert(ct, maPhieuNhap, conn, trans);
                            }
                        }

                        trans.Commit();
                        return maPhieuNhap;
                    }
                    catch
                    {
                        trans.Rollback();
                        return -1;
                    }
                }
            }
        }

        public static bool Update(PhieuNhap pn)
        {
            string sql = @"UPDATE PhieuNhap SET MaNguoiDung=@MaNguoiDung, TrangThai=@TrangThai WHERE MaPhieuNhap=@ID";
            int res = DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@MaNguoiDung", pn.MaNguoiDung),
                new MySqlParameter("@TrangThai", pn.TrangThai),
                new MySqlParameter("@ID", pn.MaPhieuNhap)
            );
            return res > 0;
        }

        public static bool Delete(int id)
        {
            string sql = "DELETE FROM PhieuNhap WHERE MaPhieuNhap=@ID";
            int res = DBHelper.ExecuteNonQuery(sql, new MySqlParameter("@ID", id));
            return res > 0;
        }

        public static List<PhieuNhap> Search(DateTime? from, DateTime? to, string trangThai = null)
        {
            string sql = "SELECT * FROM PhieuNhap WHERE 1=1";
            var param = new List<MySqlParameter>();
            if (from.HasValue)
            {
                sql += " AND NgayNhap >= @from";
                param.Add(new MySqlParameter("@from", from.Value));
            }
            if (to.HasValue)
            {
                sql += " AND NgayNhap <= @to";
                param.Add(new MySqlParameter("@to", to.Value));
            }
            if (!string.IsNullOrEmpty(trangThai))
            {
                sql += " AND TrangThai=@TrangThai";
                param.Add(new MySqlParameter("@TrangThai", trangThai));
            }
            var dt = DBHelper.ExecuteQuery(sql, param.ToArray());
            var list = new List<PhieuNhap>();
            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));
            return list;
        }

        private static PhieuNhap Map(DataRow row)
        {
            return new PhieuNhap
            {
                MaPhieuNhap = Convert.ToInt32(row["MaPhieuNhap"]),
                NgayNhap = Convert.ToDateTime(row["NgayNhap"]),
                MaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]),
                TrangThai = row["TrangThai"].ToString()
            };
        }
    }
}
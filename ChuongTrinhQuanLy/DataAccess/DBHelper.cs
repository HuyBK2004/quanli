using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    /// <summary>
    /// DBHelper: Lớp tiện ích kết nối và thực thi truy vấn MySQL.
    /// </summary>
    public class DBHelper
    {
        private static string _connectionString = "Server=127.0.0.1;Port=3306;Database=Ver1;Uid=root;Pwd=huy2004;SslMode=none;";

        /// <summary>
        /// Lấy chuỗi kết nối hiện tại hoặc thiết lập chuỗi mới (có thể cấu hình từ file).
        /// </summary>x
        public static string ConnectionString
        {
            get => _connectionString;
            set => _connectionString = value;
        }

        /// <summary>
        /// Tạo và mở kết nối mới đến MySQL.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        /// <summary>
        /// Thực thi truy vấn SELECT, trả về DataTable.
        /// </summary>
        public static DataTable ExecuteQuery(string sql, params MySqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                using (var da = new MySqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// Thực thi truy vấn INSERT/UPDATE/DELETE, trả về số dòng ảnh hưởng.
        /// </summary>
        public static int ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Thực thi truy vấn trả về giá trị đơn (ví dụ SELECT COUNT(*)), trả về object.
        /// </summary>
        public static object ExecuteScalar(string sql, params MySqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Thực thi transaction nhiều câu lệnh (vd: dùng cho nghiệp vụ phức tạp).
        /// </summary>
        public static bool ExecuteTransaction(Func<MySqlConnection, MySqlTransaction, bool> action)
        {
            using (var conn = GetConnection())
            using (var tr = conn.BeginTransaction())
            {
                try
                {
                    bool result = action(conn, tr);
                    if (result) tr.Commit();
                    else tr.Rollback();
                    return result;
                }
                catch
                {
                    tr.Rollback();
                    throw;
                }
            }
        }
    }
}
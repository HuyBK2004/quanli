using System;
using System.Collections.Generic;
using DTO;
using DataAccess;
using Utils;

namespace BUS
{
    public class NguoiDungBUS
    {
        public static List<NguoiDung> GetAll() => NguoiDungDAO.GetAll();

        public static NguoiDung GetByUsername(string username) => NguoiDungDAO.GetByUsername(username);

        public static NguoiDung GetById(int id) => NguoiDungDAO.GetById(id);

        public static bool Register(NguoiDung user, string confirmPassword, out string message)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.MatKhau) ||
                string.IsNullOrWhiteSpace(user.HoTen) || string.IsNullOrWhiteSpace(user.Email))
            {
                message = "Vui lòng nhập đầy đủ các trường bắt buộc (bao gồm Email).";
                return false;
            }
            if (user.MatKhau != confirmPassword)
            {
                message = "Mật khẩu xác nhận không khớp.";
                return false;
            }
            if (NguoiDungDAO.GetByUsername(user.Username) != null)
            {
                message = "Username đã tồn tại.";
                return false;
            }
            if (NguoiDungDAO.GetByEmail(user.Email) != null)
            {
                message = "Email đã tồn tại.";
                return false;
            }
            user.MatKhau = PasswordHelper.HashPassword(user.MatKhau);
            if (string.IsNullOrWhiteSpace(user.VaiTro))
                user.VaiTro = "KH";
            user.TrangThai = "BinhThuong";
            bool success = NguoiDungDAO.Insert(user);
            message = success ? "Đăng ký thành công!" : "Đăng ký thất bại.";
            return success;
        }

        public static NguoiDung Login(string username, string password, out string message)
        {
            var user = NguoiDungDAO.GetByUsername(username);
            if (user == null)
            {
                message = "Sai tên đăng nhập hoặc mật khẩu.";
                return null;
            }
            if (user.TrangThai == "Khoa")
            {
                message = "Tài khoản đã bị khóa.";
                return null;
            }
            if (!PasswordHelper.VerifyPassword(password, user.MatKhau))
            {
                message = "Sai tên đăng nhập hoặc mật khẩu.";
                return null;
            }
            message = "Đăng nhập thành công!";
            return user;
        }

        public static bool ChangePassword(int userId, string oldPassword, string newPassword, out string message)
        {
            var user = NguoiDungDAO.GetById(userId);
            if (user == null)
            {
                message = "Người dùng không tồn tại.";
                return false;
            }
            if (!PasswordHelper.VerifyPassword(oldPassword, user.MatKhau))
            {
                message = "Mật khẩu cũ không đúng.";
                return false;
            }
            // Gán lại mật khẩu mới (không hash nữa)
            user.MatKhau = PasswordHelper.HashPassword(newPassword);
            bool success = NguoiDungDAO.Update(user);
            message = success ? "Đổi mật khẩu thành công!" : "Đổi mật khẩu thất bại.";
            return success;
        }

        public static bool Update(NguoiDung user)
        {
            return NguoiDungDAO.Update(user);
        }

        public static bool Delete(int id)
        {
            return NguoiDungDAO.Delete(id);
        }

        public static List<NguoiDung> Search(string keyword, string vaiTro = null)
        {
            return NguoiDungDAO.Search(keyword, vaiTro);
        }
    }
}
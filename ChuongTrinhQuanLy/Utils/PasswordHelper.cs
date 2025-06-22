using System;

namespace Utils
{
    public static class PasswordHelper
    {
        public static string HashPassword(string plainPassword)
        {
            // Không hash, trả về mật khẩu gốc
            return plainPassword;
        }

        public static bool VerifyPassword(string inputPassword, string hash)
        {
            // So sánh trực tiếp
            return inputPassword == hash;
        }
    }
}
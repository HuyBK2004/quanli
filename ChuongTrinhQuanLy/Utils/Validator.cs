using System.Text.RegularExpressions;

namespace Utils
{
    /// <summary>
    /// Hàm kiểm tra dữ liệu nhập cơ bản.
    /// </summary>
    public static class Validator
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            // Regex đơn giản, có thể thay đổi cho phù hợp
            return Regex.IsMatch(email, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
        }

        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            // Chỉ cho phép số, 9-11 ký tự
            return Regex.IsMatch(phone, @"^\d{9,11}$");
        }

        public static bool IsNumber(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }
    }
}
namespace Utils
{
    /// <summary>
    /// Tiện ích xử lý chuỗi, có thể mở rộng nếu cần.
    /// </summary>
    public static class StringHelper
    {
        public static string ToTitleCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            var words = input.ToLower().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            return string.Join(" ", words);
        }
    }
}
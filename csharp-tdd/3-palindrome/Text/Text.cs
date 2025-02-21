namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            if (s == null) return false;
            string cleaned = new string(s.ToLower().Where(char.IsLetterOrDigit).ToArray());
            return cleaned.SequenceEqual(cleaned.Reverse());
        }
    }
}

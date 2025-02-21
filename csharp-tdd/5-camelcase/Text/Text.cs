namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            return s.Count(char.IsUpper) + 1;
        }
    }
}

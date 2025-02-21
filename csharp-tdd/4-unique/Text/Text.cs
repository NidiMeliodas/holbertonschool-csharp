namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s)) return -1;
            var counts = new Dictionary<char, int>();
            foreach (char c in s) counts[c] = counts.ContainsKey(c) ? counts[c] + 1 : 1;
            for (int i = 0; i < s.Length; i++)
                if (counts[s[i]] == 1) return i;
            return -1;
        }
    }
}

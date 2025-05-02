using System;
using System.Collections.Generic;

namespace Text
{
	/// <summary>
	/// Provides string utility functions.
	/// </summary>
	public class Str
	{
		/// <summary>
		/// Returns index of first non-repeating character in string.
		/// </summary>
		/// <param name="s">Input string</param>
		/// <returns>Index of first unique char or -1 if none</returns>
		public static int UniqueChar(string s)
		{
			if (string.IsNullOrEmpty(s))
				return -1;

			Dictionary<char, int> freq = new Dictionary<char, int>();

			foreach (char c in s)
			{
				if (freq.ContainsKey(c))
					freq[c]++;
				else
					freq[c] = 1;
			}

			for (int i = 0; i < s.Length; i++)
			{
				if (freq[s[i]] == 1)
					return i;
			}

			return -1;
		}
	}
}

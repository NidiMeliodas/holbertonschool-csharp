using System;
using System.Text;

namespace Text
{
	/// <summary>
	/// Contains string utility methods.
	/// </summary>
	public class Str
	{
		/// <summary>
		/// Determines if a string is a palindrome, ignoring punctuation, spaces, and case.
		/// </summary>
		/// <param name="s">Input string</param>
		/// <returns>True if palindrome, false otherwise</returns>
		public static bool IsPalindrome(string s)
		{
			if (s == null)
				return false;

			StringBuilder cleaned = new StringBuilder();

			foreach (char c in s)
			{
				if (char.IsLetterOrDigit(c))
					cleaned.Append(char.ToLower(c));
			}

			string cleanedStr = cleaned.ToString();
			int left = 0, right = cleanedStr.Length - 1;

			while (left < right)
			{
				if (cleanedStr[left] != cleanedStr[right])
					return false;
				left++;
				right--;
			}

			return true;
		}
	}
}

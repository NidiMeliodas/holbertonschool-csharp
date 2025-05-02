using System;

namespace Text
{
	/// <summary>
	/// Provides string analysis functions.
	/// </summary>
	public class Str
	{
		/// <summary>
		/// Returns number of words in a camelCase string.
		/// </summary>
		/// <param name="s">The camelCase string.</param>
		/// <returns>Number of words in the string.</returns>
		public static int CamelCase(string s)
		{
			if (string.IsNullOrEmpty(s))
				return 0;

			int count = 1;

			foreach (char c in s)
			{
				if (char.IsUpper(c))
					count++;
			}

			return count;
		}
	}
}

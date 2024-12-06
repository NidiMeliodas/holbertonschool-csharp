using System;

class Character
{
	public static bool IsLower(char letter)
	{
		if (letter >= 'a' && letter <= 'z')
		{
			return true;
		}
		return false;
	}
}
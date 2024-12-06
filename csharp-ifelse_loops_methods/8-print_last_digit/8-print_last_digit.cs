using System;

class Number
{
	public static int PrintLastDigit(int number)
	{
		int lastNumber = number % 10;
		if (lastNumber < 0)
			lastNumber *= -1;
		Console.Write(lastNumber);

		return lastNumber;
	}
}
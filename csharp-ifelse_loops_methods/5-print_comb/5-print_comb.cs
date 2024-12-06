using System;

class Program
{
	static void Main(string[] args)
	{
		int number = 0;
		while (number <= 99)
		{
			if (number < 99)
				Console.Write($"{number:00}, ");
			else
				Console.WriteLine($"{number:00}");

			number++;
		}
	}
}

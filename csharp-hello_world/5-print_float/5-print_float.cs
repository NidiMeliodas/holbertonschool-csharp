using System;
// Print the float stored in the variable number with a precision of 2 digits
class Program
{
	static void Main(string[] args)
	{
		float number = 3.14159f;
		Console.WriteLine($"Float: {0:F2}", number);
	}
}
using System;
// Print the integer stored in the variable number, followed by Mission Street followed by a new line
class Program
{
	static void Main(string[] args)
	{
		int number = 972;
		Console.WriteLine(string.Format("{0} Mission Street", number));
	}
}
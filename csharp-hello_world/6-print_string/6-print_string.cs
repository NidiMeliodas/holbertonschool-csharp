using System;
// Print a string stored in the variable str 3 times, followed by its first 9 characters.
class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";

		string repeated = String.Concat(str, str, str);
		// Saves in the variable number of letters defined below
		string first9 = str.Substring(0, 9);
		// Repeats x time the word
		Console.WriteLine(repeated);
		// Prints the number of letters asked previously
		Console.WriteLine(first9);
	}
}
using System;
// Print Welcome to Holberton School! with Str1 and Str2
class Program
{
	static void Main(string[] args)
	{
		string str1 = "Holberton";
		string str2 = "School";
		string str1= String.Concat(str1, str2);
		Console.WriteLine("Welcome to {0}!", str1);
	}
}
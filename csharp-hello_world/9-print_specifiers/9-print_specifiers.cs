using System;
using System.Globalization;
class Program
{
	static void Main(string[] args)
	{
		double percent = .7553,currency = 98765.4321;   // This should be 75.53%
		CultureInfo culture = new CultureInfo("en-US");
		Console.WriteLine(string.Format(culture, "Percent: {0:P2}", percent));// Printing the percent with two decimal places in percentage format
		Console.WriteLine(string.Format(culture, "Currency: {0:C2}", currency));// Printing the currency with two decimal places in currency format
	}
}
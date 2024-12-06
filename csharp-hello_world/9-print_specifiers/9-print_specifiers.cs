using System;
using System.Globalization;
class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		CultureInfo culture = new CultureInfo("en-US");
		Console.WriteLine(string.Format(culture, "Percent: {0:P2} \nCurrency: {1:C2}\n", percent, currency));
	}
}
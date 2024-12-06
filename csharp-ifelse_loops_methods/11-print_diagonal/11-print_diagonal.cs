using System;

class Line
{
	public static void PrintDiagonal(int length)
	{
		if (length < 0)
			Console.WriteLine();
		else
		{
			string Space = "";
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine(Space + "\\");
				Space += " ";
			}
			Console.WriteLine();
		}
	}
}
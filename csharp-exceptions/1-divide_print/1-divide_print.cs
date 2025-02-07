using System;

class Int
{
	public static void divide(int a, int b)
	{
		int result = 0;
		bool divisionSuccessful = false;

		try
		{
			result = a / b;
			divisionSuccessful = true;
		}
		catch (DivideByZeroException)
		{
			Console.WriteLine("Cannot divide by zero");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Unexpected error: {ex.Message}");
		}
		finally
		{
			// Display the result if successful; otherwise, show a default value of 0
			Console.WriteLine($"{a} / {b} = {(divisionSuccessful ? result : 0)}");
		}
	}
}

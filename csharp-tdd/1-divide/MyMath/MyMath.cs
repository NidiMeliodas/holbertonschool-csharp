using System;

namespace MyMath
{
	/// <summary>
	/// Provides matrix-related operations
	/// </summary>
	public class Matrix
	{
		/// <summary>
		/// Divides all elements of a matrix by a number
		/// </summary>
		/// <param name="matrix">2D integer array</param>
		/// <param name="num">Divisor</param>
		/// <returns>New matrix with divided values, or null on error</returns>
		public static int[,] Divide(int[,] matrix, int num)
		{
			if (matrix == null)
				return null;

			try
			{
				int rows = matrix.GetLength(0);
				int cols = matrix.GetLength(1);
				int[,] result = new int[rows, cols];

				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < cols; j++)
					{
						result[i, j] = matrix[i, j] / num;
					}
				}

				return result;
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Num cannot be 0");
				return null;
			}
		}
	}
}

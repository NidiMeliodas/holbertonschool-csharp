using System;

namespace MatrixMath
{
    public class MatrixMath
    {
        /// <summary>
        /// Rotates a 2D square matrix by a given angle in radians.
        /// </summary>
        /// <param name="matrix">2D square matrix (must be 2x2)</param>
        /// <param name="angle">Angle in radians</param>
        /// <returns>Rotated matrix, or matrix with -1 if invalid size</returns>
        public static double[,] Rotate2D(double[,] matrix, double angle)
        {
            if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
                return new double[,] { { -1 } };

            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);

            // Rotation matrix
            double[,] rot = new double[,] {
                { cos, -sin },
                { sin,  cos }
            };

            // Result of multiplying rotation matrix with the input matrix
            double[,] result = new double[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = rot[i, 0] * matrix[0, j] + rot[i, 1] * matrix[1, j];
                }
            }

            return result;
        }
    }
}

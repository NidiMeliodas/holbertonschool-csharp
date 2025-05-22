using System;

class MatrixMath
{
    /// <summary>
    /// Rotates a 2D square matrix by a given angle in radians .
    /// </summary>
    /// <param name="matrix">The 2D square matrix to rotate.</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>The rotated matrix, or a matrix containing -1 if the input is invalid.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Validate that the input is a 2x2 matrix
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        // Compute rotation matrix values
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        double[,] rotationMatrix = new double[,]
        {
            { cosTheta, -sinTheta },
            { sinTheta,  cosTheta }
        };

        double[,] rotatedMatrix = new double[2, 2];

        // Multiply rotation matrix by the input matrix
        for (int i = 0; i < 2; i++) // Rows
        {
            for (int j = 0; j < 2; j++) // Columns
            {
                rotatedMatrix[i, j] = Math.Round(
                    matrix[i, 0] * rotationMatrix[0, j] +
                    matrix[i, 1] * rotationMatrix[1, j], 2
                );
            }
        }

        return rotatedMatrix;
    }
}

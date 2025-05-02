using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Test]
        public void Divide_NormalMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 4, 8 }, { 16, 20 } };
            int[,] expected = { { 2, 4 }, { 8, 10 } };
            int[,] result = Matrix.Divide(matrix, 2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ByZero_ReturnsNullAndPrintsMessage()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            int[,] result = Matrix.Divide(matrix, 0);

            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 2);
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NegativeDivisor_WorksCorrectly()
        {
            int[,] matrix = { { 6, -12 }, { 9, -3 } };
            int[,] expected = { { -3, 6 }, { -4, 1 } };
            int[,] result = Matrix.Divide(matrix, -2);

            Assert.AreEqual(expected, result);
        }
    }
}

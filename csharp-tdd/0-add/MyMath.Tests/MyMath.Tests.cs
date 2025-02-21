using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }
        [Test]
        public void TestDivide()
        {
            int[,] matrix = { { 4, 8 }, { 16, 20 } };
            int[,] expected = { { 2, 4 }, { 8, 10 } };
            CollectionAssert.AreEqual(expected, Matrix.Divide(matrix, 2));
        }
    }
}

using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class MyMathTests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        [Test]
        public void Add_NegativeAndPositiveNumber_ReturnsCorrectSum()
        {
            Assert.AreEqual(1, Operations.Add(-2, 3));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }

        [Test]
        public void Add_ZeroAndNumber_ReturnsSameNumber()
        {
            Assert.AreEqual(4, Operations.Add(0, 4));
        }
    }
}

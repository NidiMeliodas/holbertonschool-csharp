using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void Max_ListWithPositiveNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { 1, 2, 5, 3 };
            Assert.AreEqual(5, Operations.Max(nums));
        }

        [Test]
        public void Max_ListWithNegativeNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { -10, -3, -20, -5 };
            Assert.AreEqual(-3, Operations.Max(nums));
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            Assert.AreEqual(0, Operations.Max(nums));
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(null));
        }

        [Test]
        public void Max_ListWithOneElement_ReturnsElement()
        {
            List<int> nums = new List<int> { 42 };
            Assert.AreEqual(42, Operations.Max(nums));
        }
    }
}

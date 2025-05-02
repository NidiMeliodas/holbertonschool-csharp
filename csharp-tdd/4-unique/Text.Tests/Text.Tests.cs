using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void UniqueChar_AllRepeats_ReturnsMinus1()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabbcc"));
        }

        [Test]
        public void UniqueChar_OneUniqueAtStart_Returns1()
        {
            Assert.AreEqual(1, Str.UniqueChar("abcdefa"));
        }

        [Test]
        public void UniqueChar_OneUniqueAtMiddle_Returns5()
        {
            Assert.AreEqual(5, Str.UniqueChar("aabbcdc"));
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsMinus1()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }

        [Test]
        public void UniqueChar_NullString_ReturnsMinus1()
        {
            Assert.AreEqual(-1, Str.UniqueChar(null));
        }

        [Test]
        public void UniqueChar_OneCharString_Returns0()
        {
            Assert.AreEqual(0, Str.UniqueChar("z"));
        }
    }
}

using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void IsPalindrome_Racecar_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }

        [Test]
        public void IsPalindrome_SentenceWithPunctuation_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("Not a palindrome"));
        }

        [Test]
        public void IsPalindrome_Null_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome(null));
        }

        [Test]
        public void IsPalindrome_SingleChar_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("x"));
        }
    }
}

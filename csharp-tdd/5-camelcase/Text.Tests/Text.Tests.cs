using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void CamelCase_EmptyString_Returns0()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void CamelCase_SingleWord_Returns1()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        [Test]
        public void CamelCase_MultipleWords_Returns4()
        {
            Assert.AreEqual(4, Str.CamelCase("helloWorldThisIs"));
        }

        [Test]
        public void CamelCase_OnlyCapitals_Returns4()
        {
            Assert.AreEqual(4, Str.CamelCase("aBCF"));
        }

        [Test]
        public void CamelCase_Null_Returns0()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }
    }
}

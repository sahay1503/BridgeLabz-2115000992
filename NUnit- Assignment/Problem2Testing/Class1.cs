using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problem2;

namespace Problem2Testing
{

    [TestFixture]
    public class Class1
    {
        private StringUtils _stringUtils;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
        }
        [Test]
        public void Reverse_GivenString_ReturnsReversedString()
        {
            string input = "hello";
            string expected = "olleh";
            string result = _stringUtils.Reverse(input);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindrome_GivenPalindromeString_ReturnsTrue()
        {
            string input = "madam";
            bool result = _stringUtils.IsPalindrome(input);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_GivenNonPalindromeString_ReturnsFalse()
        {
            string input = "hello";
            bool result = _stringUtils.IsPalindrome(input);
            Assert.IsFalse(result);
        }

        [Test]
        public void ToUpperCase_GivenString_ReturnsUppercaseString()
        {
            string input = "hello";
            string expected = "HELLO";
            string result = _stringUtils.ToUpperCase(input);
            Assert.AreEqual(expected, result);
        }

    }
}


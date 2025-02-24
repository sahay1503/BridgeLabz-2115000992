using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problem6;

namespace Problem6Test
{
    [TestFixture]
    public class Class1
    {
        private MathOperations _maths;

        [SetUp]
        public void Setup()
        {
            _maths = new MathOperations();
        }
        [Test]
        public void IsEven_GivenNumber2_ReturnsTrue()
        {
            int number = 2;
            bool result = _maths.IsEven(number);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsEven_GivenNumber4_ReturnsTrue()
        {
            int number = 4;
            bool result = _maths.IsEven(number);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsEven_GivenNumber6_ReturnsTrue()
        {
            int number = 6;
            bool result = _maths.IsEven(number);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsEven_GivenNumber7_ReturnsFalse()
        {
            int number = 7;
            bool result = _maths.IsEven(number);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsEven_GivenNumber9_ReturnsFalse()
        {
            int number = 9;
            bool result = _maths.IsEven(number);
            Assert.IsFalse(result);
        }


    }
}

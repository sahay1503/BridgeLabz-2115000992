using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problem4;

namespace Problem4Test
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
        public void Divide_GivenZeroAsDivisor_ThrowsArithmeticException()
        {
            int a = 10;
            int b = 0;
            Assert.Throws<DivideByZeroException>(() => _maths.Divide(a, b));
        }

    }
}

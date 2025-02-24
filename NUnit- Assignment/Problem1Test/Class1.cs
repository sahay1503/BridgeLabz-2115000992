using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problem1;

namespace Problem1Test
{
    [TestFixture]
    public class Class1
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }
        [Test]
        public void Add_ValidInputs_ReturnsCorrectSum()
        {
            Assert.That(10,Is.EqualTo( _calculator.Add(4, 6)));
        }
        [Test]
        public void Subtract_ValidInputs_ReturnsCorrectDifference()
        {
            Assert.That(2, Is.EqualTo(_calculator.Subtract(8, 6)));
        }

        [Test]
        public void Multiply_ValidInputs_ReturnsCorrectProduct()
        {
            Assert.That(24, Is.EqualTo(_calculator.Multiply(4, 6))); ;
        }

        [Test]
        public void Divide_ValidInputs_ReturnsCorrectQuotient()
        {
            Assert.That(2, Is.EqualTo(_calculator.Divide(12, 6)));
        }
        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}

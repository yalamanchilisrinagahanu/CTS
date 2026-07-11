using NUnit.Framework;
using NUnitMoqHandsOn;
using System;

namespace NUnitMoqHandsOn.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int result = calculator.Add(10, 20);

            Assert.AreEqual(30, result);
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            int result = calculator.Subtract(20, 10);

            Assert.AreEqual(10, result);
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            int result = calculator.Multiply(5, 4);

            Assert.AreEqual(20, result);
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            int result = calculator.Divide(20, 5);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(
                () => calculator.Divide(10, 0)
            );
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }
    }
}

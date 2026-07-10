using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
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

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }

        [Test]
        public void Add_ReturnsCorrectResult()
        {
            int result = calculator.Add(10, 20);

            Assert.That(result, Is.EqualTo(30));
        }

        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(100, 200, 300)]
        public void Add_TestCases(int a, int b, int expected)
        {
            int result = calculator.Add(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
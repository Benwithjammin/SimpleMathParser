using System;
using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture]
    public class StackCalculatorTests
    {
        [Test]
        [TestCase("3 + 2 * 4", 20)]
        [TestCase("32 + 2 / 2", 17)]
        [TestCase("500 + 10 - 66 * 32", 14208)]
        [TestCase("(5 + 10) * 7 ", 70)]
        public void Test(string value, int expectedResult)
        {
            var calc = new StackCalculator();
            string result = calc.Parse(value);

            Assert.That(Int32.Parse(result), Is.EqualTo(expectedResult));
        }
    }
}

using System;
using System.Linq;
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
        [TestCase("3 + ( 4 * 66 ) - 32", 70)]
        public void Test(string value, int expectedResult)
        {
            var calc = new StackCalculator();
            var tokens = value.Split(new[] {" "}, StringSplitOptions.None).ToList();

            int result = calc.Parse(tokens);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

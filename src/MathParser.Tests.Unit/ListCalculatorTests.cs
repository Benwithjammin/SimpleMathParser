﻿using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture]
    public class ListCalculatorTests
    {
        private ListCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = CalculatorFactory.BuildListCalculator();
        }

        [Test]
        [TestCase("3a2c4", 20)]
        [TestCase("32a2d2", 17)]
        [TestCase("500a10b66c32", 14208)]
        [TestCase("3ae4c66fb32", 235)]
        [TestCase("3c4d2aee2a4c41fc4f", 990)]
        public void GivenAValueThenTheExpectedResultShouldBeReturned(string input, int expectedValue)
        {
            int result = _calculator.CalculateResult(input);

            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture]
    public class StringTokeniserTests
    {
        private List<string> _tokens;

        [SetUp]
        public void SetUp()
        {
            string input = "500+10+(5/1)";
            var tokeniser = new StringTokeniser();
            _tokens = tokeniser.Convert(input).ToList();
        }

        [Test]
        public void TheCorrectNumberOfTokensShouldBeReturned()
        {
            Assert.That(_tokens.Count, Is.EqualTo(9));
        }

        [Test]
        public void MultipleDigitNumbersShouldBeRespected()
        {
            Assert.That(_tokens.First(), Is.EqualTo("500"));
        }

        [Test]
        public void SingleDigitNumbersShouldBeRespected()
        {
            Assert.That(_tokens[7], Is.EqualTo("1"));
        }

        [Test]
        public void ThereShouldBeTwoAdditionOperators()
        {
            Assert.That(_tokens.Count(t => t.Equals("+")), Is.EqualTo(2));
        }

        [Test]
        public void ThereShouldBeTwoBrackets()
        {
            Assert.That(_tokens.Count(t => t.Equals("+")), Is.EqualTo(2));
        }

        [Test]
        [TestCase("500", 0)]
        [TestCase("+", 1)]
        [TestCase("10", 2)]
        [TestCase("+", 3)]
        [TestCase("(", 4)]
        [TestCase("5", 5)]
        [TestCase("/", 6)]
        [TestCase("1", 7)]
        [TestCase(")", 8)]
        public void OrderShouldBeRespected(string expectedValue, int index)
        {
            Assert.That(_tokens[index], Is.EqualTo(expectedValue));
        }
    }
}

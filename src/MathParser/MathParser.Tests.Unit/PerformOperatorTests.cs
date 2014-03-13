using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture]
    public class PerformOperatorTests
    {
        [Test]
        public void GivenTheAdditonOperatorThenTheTwoNumbersAreAdded()
        {
            int result = Operators.CalculateOperatation(2, 5, "+");

            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void GivenTheSubtractionOperatorThenTheTwoNumbersAreSubtracted()
        {
            int result = Operators.CalculateOperatation(5, 2, "-");

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void GivenTheDivisonOperatorThenTheTwoNumbersAreDivided()
        {
            int result = Operators.CalculateOperatation(4, 2, "/");

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GivenTheMulitplicationOperatorThenTheTwoNumbersAreMulitplied()
        {
            int result = Operators.CalculateOperatation(4, 2, "*");

            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        [TestCase("+")]
        [TestCase("-")]
        [TestCase("/")]
        [TestCase("*")]
        public void GivenAValidOperatorThenIsOperatorShouldReturnTrue(string op)
        {
            bool result = Operators.IsOperator(op);

            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("(")]
        [TestCase(")")]
        public void GivenAValidOperatorThenIsOperatorShouldReturnFalse(string op)
        {
            bool result = Operators.IsOperator(op);

            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("+", 4)]
        [TestCase("-", 3)]
        [TestCase("*", 2)]
        [TestCase("/", 1)]
        public void GivenAValidOperatorThenReturnPrecedenceShouldReturnTheExpectedValue(string op, int expectedValue)
        {
            int result = Operators.GetPrecedence(op);

            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}

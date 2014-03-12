using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture]
    public class PerformOperatorTests
    {
        [Test]
        public void GivenTheAdditonOperatorThenTheTwoNumbersAreAdded()
        {
            int result = PerformOperator.CalculateOperatation(2, 5, "+");

            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void GivenTheSubtractionOperatorThenTheTwoNumbersAreSubtracted()
        {
            int result = PerformOperator.CalculateOperatation(5, 2, "-");

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void GivenTheDivisonOperatorThenTheTwoNumbersAreDivided()
        {
            int result = PerformOperator.CalculateOperatation(4, 2, "/");

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GivenTheMulitplicationOperatorThenTheTwoNumbersAreMulitplied()
        {
            int result = PerformOperator.CalculateOperatation(4, 2, "*");

            Assert.That(result, Is.EqualTo(8));
        }
    }
}

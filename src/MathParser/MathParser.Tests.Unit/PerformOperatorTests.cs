using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture]
    public class PerformOperatorTests
    {
        [Test]
        public void GivenThenAdditonOperatorThenTheTwoNumbersAreAdded()
        {
            int result = PerformOperator.CalculateOpetation(2, 5, "+");

            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void GivenThenSubtractionOperatorThenTheTwoNumbersAreSubtracted()
        {
            int result = PerformOperator.CalculateOpetation(5, 2, "-");

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void GivenThenDivisonOperatorThenTheTwoNumbersAreDivided()
        {
            int result = PerformOperator.CalculateOpetation(4, 2, "/");

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GivenThenMulitplicationOperatorThenTheTwoNumbersAreMulitplied()
        {
            int result = PerformOperator.CalculateOpetation(4, 2, "*");

            Assert.That(result, Is.EqualTo(8));
        }
    }
}

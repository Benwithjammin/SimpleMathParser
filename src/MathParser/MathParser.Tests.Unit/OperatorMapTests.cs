using System.Linq;
using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture]
    public class OperatorMapTests
    {
        [Test]
        [TestCase("a", '+')]
        [TestCase("A", '+')]
        [TestCase("b", '-')]
        [TestCase("B", '-')]
        [TestCase("c", '*')]
        [TestCase("C", '*')]
        [TestCase("d", '/')]
        [TestCase("D", '/')]
        public void GivenAnOperatorCharacterThenThisShouldBecomeTheRelevantOperator(string input, char expected)
        {
            var results = OperatorMapper.Convert(input);

            Assert.That(results.First(), Is.EqualTo(expected));
        }

        public void GivenAValidOperatorThenThisShouldBeMappable()
        {
            string input = "a";

            bool isOperator = OperatorMapper.IsOperator(input);

            Assert.That(isOperator, Is.True);
        }

        [TestCase("z")]
        [TestCase("100")]
        [TestCase("1")]
        public void GivenAnInvalidOperatorThenThisShouldNotBeMappable(string input)
        {
            bool isOperator = OperatorMapper.IsOperator(input);

            Assert.That(isOperator, Is.False);
        }
    }
}

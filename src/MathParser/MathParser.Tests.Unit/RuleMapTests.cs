using System.Linq;
using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture]
    public class RuleMapTests
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
        [TestCase("e", '(')]
        [TestCase("E", '(')]
        [TestCase("f", ')')]
        [TestCase("F", ')')]
        public void GivenAnRuleCharacterThenThisShouldBecomeTheRelevantMathValue(string input, char expected)
        {
            var results = RuleMapper.Convert(input);

            Assert.That(results.First(), Is.EqualTo(expected));
        }

        public void GivenAValidRuleCharacterThenThisShouldBeMappable()
        {
            string input = "a";

            bool isOperator = RuleMapper.IsRule(input);

            Assert.That(isOperator, Is.True);
        }

        [TestCase("z")]
        [TestCase("100")]
        [TestCase("1")]
        public void GivenAnInvalidRuleCharacterThenThisShouldNotBeMappable(string input)
        {
            bool isOperator = RuleMapper.IsRule(input);

            Assert.That(isOperator, Is.False);
        }
    }
}

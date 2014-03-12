using System.Linq;
using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture]
    public class InputTranslatorTests
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
        [TestCase("f", '(')]
        [TestCase("F", ')')]
        public void GivenAnOperatorCharacterThenThisShouldBecomeTheRelevantOperator(string input, char expected)
        {
            var results = InputTranslator.Tokenise(input);

            Assert.That(results.First(), Is.EqualTo(expected));
        }
    }
}

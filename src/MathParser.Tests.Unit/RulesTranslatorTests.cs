using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture]
    public class RulesTranslatorTests
    {
        [Test]
        [TestCase("3a2c4", "3+2*4")]
        [TestCase("32a2d2", "32+2/2")]
        [TestCase("500a10b66c32", "500+10-66*32")]
        [TestCase("3ae4c66fb32", "3+(4*66)-32")]
        public void GivenAnIntialInputStringThisShouldBeConvertedIntoAHumanReadableInput(string input, string expectedValue)
        {
            string translated = RulesTranslator.Translate(input);

            Assert.That(translated, Is.EqualTo(expectedValue));
        }
    }
}

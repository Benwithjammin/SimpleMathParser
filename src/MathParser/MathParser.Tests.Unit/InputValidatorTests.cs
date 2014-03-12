using System.IO;
using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture, Description("Rules are a = '+', b = '-', c = '*', d = '/', e = '(', f = ')' and integer values only")]
    public class InputValidatorTests
    {
       [Test]
       [TestCase("3a2c4")]
       [TestCase("32a2d2")]
       [TestCase("500a10b66c32")]
       [TestCase("3ae4c66fb32")]
       [TestCase("3c4d2aee2a4c41fc4f")]
       public void GivenAValidInputStringThenNoErrorsShouldBeThrown(string input)
       {
           InputValidator.AssertInputIsValid(input);

           Assert.Pass();
       }

       [Test]
       [TestCase("")]
       [TestCase("   ")]
       [TestCase(" ")]
       public void GivenAnEmptyStringThenAnErrorShouldBeThrown(string input)
       {
           Assert.Throws<InvalidDataException>(() => InputValidator.AssertInputIsValid(input));
       }

       [Test]
       [TestCase("3.1Ze9")]
       [TestCase("9xxxyZ")]
       [TestCase("Z")]
       public void GivenAnInvalidInputStringThenAnErrorShouldBeThrown(string input)
       {
           Assert.Throws<InvalidDataException>(() => InputValidator.AssertInputIsValid(input));
       }

    }
}

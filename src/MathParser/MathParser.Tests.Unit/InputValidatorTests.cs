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
       public void GivenAValidInputStringThenNoErrorsShouldBeThrown()
       {
           
       }

       [Test]
       public void GivenAnEmptyStringThenAnErrorShouldBeThrown()
       {
           
       }

       [Test]
       [TestCase("3.1Ze9")]
       [TestCase("9xxxyZ")]
       [TestCase("Z")]
       public void GivenAnInvalidInputStringThenAnErrorShouldBeThrown()
       {
           
       }
    }
}

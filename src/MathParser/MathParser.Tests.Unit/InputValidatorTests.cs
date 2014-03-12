using NUnit.Framework;

namespace MathParser.Tests.Unit
{
    [TestFixture, Description("Rules are a = '+', b = '-', c = '*', d = '/', e = '(', f = ')' and integer values only")
    public class InputValidatorTests
    {
       [Test]
       public void GivenAValidInputStringThenNoErrorsShouldBeThrown()
       {
           
       }

       [Test]
       public void GivenAnInvalidInputStringThenAnErrorShouldBeThrown()
       {
           
       }
    }
}

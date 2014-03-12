using System.Linq;
using MathParser.ShuntingYard;

namespace MathParser
{
    public class Calculator
    {
        private readonly IStringTokeniser _tokeniser;

        public Calculator(IStringTokeniser tokeniser)
        {
            _tokeniser = tokeniser;
        }

        public int CalculateResult(string input)
        {
            var shuntingYardMath = new ShuntingYardSimpleMath();
            string convertedInput = RulesTranslator.Translate(input);
            var tokens = _tokeniser.Convert(convertedInput);

            var result = shuntingYardMath.Execute(tokens.ToList(), null);

            return (int)result;
        }
    }
}

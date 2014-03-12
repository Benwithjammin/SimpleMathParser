namespace MathParser
{
    public class CalculatorFactory
    {
        public static Calculator Build()
        {
            var tokeniser = new StringTokeniser();

            return new Calculator(tokeniser);
        }
    }
}

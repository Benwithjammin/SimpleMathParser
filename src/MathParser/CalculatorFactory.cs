namespace MathParser
{
    public class CalculatorFactory
    {
        public static ShuntingYardCalculator BuildShuntingYardCalculator()
        {
            var tokeniser = new StringTokeniser();

            return new ShuntingYardCalculator(tokeniser);
        }

        public static StackCalculator BuildStackCalculator()
        {
            var tokeniser = new StringTokeniser();

            return new StackCalculator(tokeniser);
        }

        public static ListCalculator BuildListCalculator()
        {
            var tokeniser = new StringTokeniser();

            return new ListCalculator(tokeniser);
        }
    }
}

namespace MathParser
{
    public class PerformOperator
    {
        public static int CalculateOpetation(int valueOne, int valueTwo, string op)
        {
            switch (op)
            {
                case "*":
                    return valueOne * valueTwo;
                case "/":
                    return valueOne / valueTwo;
                case "+":
                    return valueOne + valueTwo;
                case "-":
                    return valueOne - valueTwo;
                default:
                    return 0;
            }
        }
    }
}

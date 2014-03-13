namespace MathParser
{
    public class Operators
    {
        public const string OPEN_PARENTHESES = "(";
        public const string CLOSE_PARENTHESES = ")";

        //TODO - refactor with Dictionary, op as key, new type with Func and presendense in

        public static int CalculateOperatation(int leftValue, int rightValue, string op)
        {
            switch (op)
            {
                case "+":
                    return leftValue + rightValue;
                case "-":
                    return leftValue - rightValue;
                case "*":
                    return leftValue * rightValue;
                case "/":
                    return leftValue / rightValue;
                default:
                    return 0;
            }
        }

        public static bool IsOperator(string op)
        {
            switch (op)
            {
                case "+":
                    return true;
                case "-":
                    return true;
                case "*":
                    return true;
                case "/":
                    return true;
                default:
                    return false;
            }
        }

        public static int GetPrecedence(string op)
        {
            switch (op)
            {
                case "+":
                    return 4;
                case "-":
                    return 3;
                case "*":
                    return 2;
                case "/":
                    return 1;
                default:
                    return 0;
            }
        }
    }
}

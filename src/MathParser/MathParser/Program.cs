using System;

namespace MathParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your formula. Enter 'Q' to quit");      //Very rough REPL at the minute!
            string input = "";
            var calculator = CalculatorFactory.BuildListCalculator();

            while (!input.Equals("Q"))
            {
                input = Console.ReadLine();

                try
                {
                    InputValidator.AssertInputIsValid(input);
                    int result = calculator.CalculateResult(input);

                    Console.WriteLine("Success! Your result is - {0}", result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}

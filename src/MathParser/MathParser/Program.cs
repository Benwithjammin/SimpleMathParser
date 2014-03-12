using System;

namespace MathParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your formula. Enter 'Q' to quit");      //Very rough REPL at the minute!
            string input = "";

            while (!input.Equals("Q"))
            {
                input = Console.ReadLine();

                try
                {
                    InputValidator.AssertInputIsValid(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}

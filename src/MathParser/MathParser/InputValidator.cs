using System;
using System.IO;

namespace MathParser
{
    //We should do a simple first pass of the string to check its validaty within the given rules - a = '+', b = '-', c = '*', d = '/', e = '(', f = ')' and integers
    public class InputValidator
    {
        private static readonly char[] ValidOperators = new [] {'a', 'b', 'c', 'd', 'e', 'f'};

        public static void AssertInputIsValid(string input)
        {
            if (input.Trim().Length == 0)
            {
                throw new InvalidDataException("Input cannot be empty!");
            }

            foreach (char c in input)
            {
                AssertCharIsValid(c);
            }
        }

        private static void AssertCharIsValid(char currentCharacter)
        {
            int dummyOut;

            if (Array.Exists(ValidOperators, c => c == currentCharacter) || Int32.TryParse(currentCharacter.ToString(), out dummyOut))
            {
                return;
            }

            throw new InvalidDataException(String.Format("The character '{0}' is not valid", currentCharacter));
        }
    }
}

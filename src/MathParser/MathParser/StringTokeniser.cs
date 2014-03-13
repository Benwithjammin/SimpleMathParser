using System;
using System.Collections.Generic;

namespace MathParser
{
    //Basically a split and keep, abstracted to interface as need to add a cleaner / quicker implementation. Also different calculators may need different tokens
    public class StringTokeniser : IStringTokeniser
    {
        private readonly char[] Operators = new[] { '+', '-', '*', '/', '(', ')' };

        public IEnumerable<String> Convert(string input)
        {
            int start = 0;
            var tokens = new List<string>();

            for (int index = 0; index < input.Length; index++)
            {
                for (int seperator = 0; seperator < Operators.Length; seperator++)
                {
                    if (Operators[seperator].Equals(input[index]))
                    {
                        if (start != index)
                        {
                            tokens.Add(input.Substring(start, index - start));
                        }

                        start = index + 1;
                        tokens.Add(Operators[seperator].ToString());

                        break;
                    }
                }
            }

            if (start != input.Length)
            {
                tokens.Add(input.Substring(start, input.Length - start));
            }

            return tokens.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;

namespace MathParser
{
    //Final step once we have a list of tokens
    public class TokenCalculator
    {
        public static int CalculateFromTokens(List<String> tokens)
        {
            var total = int.Parse(tokens[0]); //Start

            for (int i = 1; i + 1 < tokens.Count; i++)
            {
                int rightIndex = i + 1;
                int rightValue = Int32.Parse(tokens[rightIndex]);

                total = Operators.CalculateOperatation(total, rightValue, tokens[i]);

                i += 1; 
            }

            return total;
        }
    }
}

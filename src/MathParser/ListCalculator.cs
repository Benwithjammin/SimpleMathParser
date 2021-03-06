﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MathParser
{
    //3rd time lucky - focus on the Parentheses! Use Lists to help find Parentheses, we have indexOf and last index of, plus actual index values :)
    public class ListCalculator : ICalculator
    {
        private readonly IStringTokeniser _stringTokeniser;

        public ListCalculator(IStringTokeniser tokeniser)
        {
            _stringTokeniser = tokeniser;
        }

        public int CalculateResult(string input)
        {
            string convertedInput = RulesTranslator.Translate(input);
            var tokens = _stringTokeniser.Convert(convertedInput).ToList();

            var total = CalculateTotal(tokens);

            return total;
        }

        private int CalculateTotal(List<String> tokens)
        {
            tokens = ParseParentheses(tokens);
            var total = TokenCalculator.CalculateFromTokens(tokens);

            return total;
        }

        private List<String> ParseParentheses(List<String> tokens)
        {
            int openingParenthesesIndex = tokens.LastIndexOf(Operators.OPEN_PARENTHESES);

            while (openingParenthesesIndex >= 0)
            {
                int closingParenthesesIndex = tokens.IndexOf(Operators.CLOSE_PARENTHESES);

                tokens = Unwind(tokens, openingParenthesesIndex, closingParenthesesIndex);

                openingParenthesesIndex = tokens.LastIndexOf(Operators.OPEN_PARENTHESES);
            }

            return tokens;
        }

        private List<string> Unwind(List<String> tokens, int startIndex, int endIndex)
        {
            int unwoundInnerTotal = GetUnwoundInnerTotal(tokens, startIndex, endIndex);

            var unwoundTokens = new List<String>();

            for (int i = 0; i < tokens.Count; i++)
            {
                if (IsOutsideParentheses(startIndex, endIndex, i))
                {
                    unwoundTokens.Add(tokens[i]);
                }
            }

            unwoundTokens.Insert(startIndex, unwoundInnerTotal.ToString()); //Replace opening bracket with inner total

            return unwoundTokens;
        }

        private int GetUnwoundInnerTotal(List<string> tokens, int openingParenthesesIndex, int closingParenthesesIndex)
        {
            var unwoundArray = UnwindTokensWithinParentheses(tokens, openingParenthesesIndex, closingParenthesesIndex);
            int unwoundInnerTotal = TokenCalculator.CalculateFromTokens(unwoundArray);

            return unwoundInnerTotal;
        }

        private bool IsOutsideParentheses(int startIndex, int endIndex, int currentIndex)
        {
            return currentIndex < startIndex || currentIndex > endIndex;
        }

        private List<String> UnwindTokensWithinParentheses(List<String> tokens, int openingParathensisIndex, int closingParenthesesIndex)
        {
            var totalParathensisLength = CalculateTotalParathensisLength(openingParathensisIndex, closingParenthesesIndex);
            var unwoundParentheses = new List<String>();

            for (int i = openingParathensisIndex + 1; i < (openingParathensisIndex + 1) + totalParathensisLength; i++)
            {
                unwoundParentheses.Add(tokens[i]);
            }

            return unwoundParentheses;
        }

        private int CalculateTotalParathensisLength(int openingParenthesesIndex, int closingParenthesesIndex)
        {
            int length = closingParenthesesIndex - openingParenthesesIndex;
            length -= 1;

            return length;
        }
    }
}

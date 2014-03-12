using System;
using System.Collections.Generic;

namespace MathParser
{
    /*Convert the input into human readable collection of tokens based on the rules provided - a = '+', b = '-', c = '*', d = '/', e = '(', f = ')'
     * maybe an uneeded step but seems sensible!*/
    public class RuleMapper
    {
        private static readonly Dictionary<String, String> OperatorMap = new Dictionary<String, String>()
        {
            { "a", "+" },
            { "b", "-" },
            { "c", "*" },
            { "d", "/" },
            { "e", "(" },
            { "f", ")" },
        };

        public static string Convert(string input)
        {
            return OperatorMap[input.ToLower()];
        }

        public static bool IsRule(string input)
        {
            return OperatorMap.ContainsKey(input.ToLower());
        }
    }
}

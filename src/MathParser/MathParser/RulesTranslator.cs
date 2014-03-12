using System.Text;

namespace MathParser
{
    public class RulesTranslator
    {
        public static string Translate(string input)
        {
            var sb = new StringBuilder(512);

            foreach (var value in input)
            {
                if (RuleMapper.IsRule(value.ToString()))
                {
                    string mappedOperator = RuleMapper.Convert(value.ToString());
                    sb.Append(mappedOperator);
                }
                else
                {
                    sb.Append(value);
                }
            }

            return sb.ToString();
        }
    }
}

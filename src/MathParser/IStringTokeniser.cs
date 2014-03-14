using System.Collections.Generic;

namespace MathParser
{
    public interface IStringTokeniser
    {
        IEnumerable<string> Convert(string input);
    }
}
using System;
using System.Collections.Generic;

namespace MathParser
{
    //Inspired by the shunting yard algorithim, without the confusing RPN / postfix
    public class StackCalculator
    {
        public int Parse(List<String> tokens)
        {
            var stack = new Stack<String>();
            int currentPrecedence = 0;

            foreach (var token in tokens)
            {
                if (!Operators.IsOperator(token))
                {
                    stack.Push(token);
                }
                else
                {
                    if (Operators.GetPrecedence(token) <= currentPrecedence)
                    {
                        RewindStack(stack);
                        stack.Push(token);
                    }
                    else
                    {
                        currentPrecedence = Operators.GetPrecedence(token);
                        stack.Push(token);
                    }
                }
            }

            RewindStack(stack);

            return int.Parse(stack.Pop());
        }

        private void RewindStack(Stack<String> stack)
        {
            int valueRight = Int32.Parse(stack.Pop());
            string op = stack.Pop();
            int valueLeft = Int32.Parse(stack.Pop());

            int result = Operators.CalculateOperatation(valueLeft, valueRight, op);

            stack.Push(result.ToString());
        }
    }
}

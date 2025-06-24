using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0020_ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>(){
                {'(',')'},
                {'{','}'},
                {'[',']'}
            };

            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                    stack.Push(c);
                else if (stack.Count > 0 && dict[stack.Peek()] == c)
                    stack.Pop();
                else
                    return false;
            }
            return stack.Count == 0;
        }
    }
}

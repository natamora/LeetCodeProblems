using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0013_RomanToInteger
{
    public class Solution : ISolution
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 },
            };

            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && dict[s[i]] < dict[s[i + 1]])
                {
                    sum -= dict[s[i]];
                }
                else
                {
                    sum += dict[s[i]];
                }
            }

            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0013_RomanToInteger
{
    public class Solution2 : ISolution
    {
        public int RomanToInt(string s)
        {

            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && getValue(s[i]) < getValue(s[i + 1]))
                {
                    sum += getValue(s[i + 1]) - getValue(s[i]);
                    i++;
                }
                else
                {
                    sum += getValue(s[i]);
                }
            }
            return sum;
        }

        public int getValue(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            };
            return 0;
        }
    }
}

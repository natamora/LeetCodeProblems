using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0008_StringToIntegerAtoi
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            int sign = 1;
            int num = 0;
            // 1. Whitespace
            s = s.Trim();
            if (string.IsNullOrEmpty(s)) return 0;

            int i = 0;
            // 2. Check sign
            if (s[0] == '-' || s[0] == '+')
            {
                sign = (s[0] == '-') ? -1 : 1;
                i++;
            }

            // 3. Conversion
            for (; i < s.Length && char.IsDigit(s[i]); i++)
            {
                int digit = s[i] - '0';
                // 4. Rounding
                if (num > (int.MaxValue - digit) / 10)
                {
                    return sign > 0 ? int.MaxValue : int.MinValue;
                }
                num = num * 10 + digit;
            }

            return sign * num;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0009_PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            List<int> num = new List<int>();

            while (x > 0)
            {
                int digit = x % 10;
                num.Add(digit);
                x = x / 10;
            }

            for (int i = 0; i < num.Count / 2; i++)
            {
                if (num[i] != num[num.Count - 1 - i]) return false;
            }
            return true;
        }
    }
}

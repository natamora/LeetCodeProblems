using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0125_ValidPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var cleanString = s.ToLower().Where(x => char.IsLetterOrDigit(x)).ToArray();
            for (int i = 0, j = cleanString.Length - 1; i < j; i++, j--)
            {
                if (cleanString[i] != cleanString[j]) return false;
            }
            return true;
        }
    }
}

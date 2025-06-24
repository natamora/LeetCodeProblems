using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0005_LongestPalindromicSubstring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length < 1) return s;

            string maxStr = s[0..1];

            for (int i = 0; i < s.Length - 1; i++)
            {
                string odd = Expand(s, i, i);
                string even = Expand(s, i, i + 1);

                maxStr = maxStr.Length < odd.Length ? odd : maxStr;
                maxStr = maxStr.Length < even.Length ? even : maxStr;
            }
            return maxStr;
        }
        public string Expand(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--; right++;
            }
            return s[(left + 1)..right];  // revert to the longest palindrome found (l + 1, r +1) 
                                          // but substring works with r + 1 (because r is excluded from string)
        }
    }
}

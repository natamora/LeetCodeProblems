using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0003_LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var dict = new Dictionary<char, int>();  // letter, latest index
            int maxLen = 0;
            // iter with right to look for the longest substring
            for (int left = 0, right = 0; right < s.Length; right++)
            {
                char c = s[right];
                // if we already found this letter before we need to move left pointer to the position of last occurence
                if (dict.ContainsKey(c))
                {
                    left = Math.Max(dict[c] + 1, left); //move left to the next char after the one that repeat 
                                                        //(or stay with left index if we already skipped this position)
                }
                // update or add letter to dict
                dict[c] = right;
                maxLen = maxLen < (right - left + 1) ? (right - left + 1) : maxLen;
            }
            return maxLen;
        }
    }
}

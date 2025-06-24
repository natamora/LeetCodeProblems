using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0014_LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string shortestWord = strs.OrderBy(s => s.Length).First();

            for (int i = 0; i < shortestWord.Length; i++)
            {
                if (strs.Any(s => s[i] != shortestWord[i]))
                    return shortestWord[..i];
            }
            return shortestWord;
        }
    }
}

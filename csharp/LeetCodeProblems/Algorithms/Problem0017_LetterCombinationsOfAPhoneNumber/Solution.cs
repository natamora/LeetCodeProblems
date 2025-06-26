using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0017_LetterCombinationsOfAPhoneNumber
{
    public class Solution
    {
        private Dictionary<char, string> dict = new Dictionary<char, string>()
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };

        public IList<string> LetterCombinations(string digits)
        {
            // Idea: Create tree of digits with all combinations, then DFS to create 
            List<string> result = [];

            if (String.IsNullOrEmpty(digits)) return result;

            Dfs(digits, 0, "", result);
            return result;
        }

        public void Dfs(string digits, int curr, string word, List<string> result)
        {
            if(curr == digits.Length)
            {
                result.Add(word);
                return;
            }

            foreach (char c in dict[digits[curr]])
            {
                Dfs(digits, curr + 1, word + c, result);
            }
        }
    }
}

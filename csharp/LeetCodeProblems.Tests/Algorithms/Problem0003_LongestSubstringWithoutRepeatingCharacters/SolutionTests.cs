using LeetCodeProblems.Algorithms.Problem0003_LongestSubstringWithoutRepeatingCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0003_LongestSubstringWithoutRepeatingCharacters
{
    public class SolutionTests
    {
        [Fact]
        public void LongestSubstringWithoutRepeatingCharactersTest1()
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring("abcabcbb");
            Assert.Equal(3, result);
        }

        [Fact]
        public void LongestSubstringWithoutRepeatingCharactersTest2()
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring("bbbbb");
            Assert.Equal(1, result);
        }

        [Fact]
        public void LongestSubstringWithoutRepeatingCharactersTest3()
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring("pwwkew");
            Assert.Equal(3, result);
        }
    }
}

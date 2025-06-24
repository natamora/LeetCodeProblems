using LeetCodeProblems.Algorithms.Problem0005_LongestPalindromicSubstring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0005_LongestPalindromicSubstring
{
    public class SolutionTests
    {
        [Fact]
        public void LongestPalindromicSubstringTest1()
        {
            var solution = new Solution();
            var result = solution.LongestPalindrome("babad");
            Assert.Equal("bab", result);
        }

        [Fact]
        public void LongestPalindromicSubstringTest2()
        {
            var solution = new Solution();
            var result = solution.LongestPalindrome("cbbd");
            Assert.Equal("bb", result);
        }
    }
}

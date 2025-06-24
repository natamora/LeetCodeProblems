using LeetCodeProblems.Algorithms.Problem0014_LongestCommonPrefix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0014_LongestCommonPrefix
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        public void LongestCommonPrefixTest(string[] input, string expected)
        {
            var solution = new Solution();
            var result = solution.LongestCommonPrefix(input);
            Assert.Equal(expected, result);
        }
    }
}

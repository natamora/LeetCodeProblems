using LeetCodeProblems.Algorithms.Problem0020_ValidParentheses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0020_ValidParentheses
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([])", true)]
        public void ValidParenthesesTest(string input, bool expected)
        {
            var solution = new Solution();
            var result = solution.IsValid(input);
            Assert.Equal(expected, result);
        }
    }
}

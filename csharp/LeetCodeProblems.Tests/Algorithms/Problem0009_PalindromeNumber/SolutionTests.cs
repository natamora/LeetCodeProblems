using LeetCodeProblems.Algorithms.Problem0009_PalindromeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0009_PalindromeNumber
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void PalindromeNumberTest(int input, bool expected)
        {
            var solution = new Solution();
            var result = solution.IsPalindrome(input);
            Assert.Equal(expected, result);
        }
    }
}

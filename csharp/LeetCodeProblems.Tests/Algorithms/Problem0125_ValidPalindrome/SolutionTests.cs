using Xunit;
using LeetCodeProblems.Algorithms.Problem0125_ValidPalindrome;

namespace LeetCodeProblems.Tests.Algorithms.Problem0125_ValidPalindrome
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        public void ValidPalindromeTest1(string input, bool expected)
        {
            var solution = new Solution();
            bool result = solution.IsPalindrome(input);

            Assert.Equal(expected, result);
        }
    }
}

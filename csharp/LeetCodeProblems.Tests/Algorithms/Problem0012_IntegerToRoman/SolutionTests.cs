using Xunit;
using LeetCodeProblems.Algorithms.Problem0012_IntegerToRoman;

namespace LeetCodeProblems.Tests.Algorithms.Problem0012_IntegerToRoman
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3749, "MMMDCCXLIX")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        public void IntegerToRomanTest1(int input, string expected)
        {
            var solution = new Solution();
            var result = solution.IntToRoman(input);
            Assert.Equal(expected, result);
        }
    }
}

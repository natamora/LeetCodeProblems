using Xunit;
using LeetCodeProblems.Algorithms.Problem0136_SingleNumber;

namespace LeetCodeProblems.Tests.Algorithms.Problem0136_SingleNumber
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [InlineData(new int[] { 1 }, 1)]
        public void SingleNumberTest1(int[] input, int expected)
        {
            var solution = new Solution();
            int result = solution.SingleNumber(input);

            Assert.Equal(expected, result);
        }
    }
}

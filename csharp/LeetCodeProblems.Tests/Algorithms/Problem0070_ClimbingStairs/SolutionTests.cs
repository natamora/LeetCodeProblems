using Xunit;
using LeetCodeProblems.Algorithms.Problem0070_ClimbingStairs;

namespace LeetCodeProblems.Tests.Algorithms.Problem0070_ClimbingStairs
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]

        public void ClimbingStairsTest1(int input, int expected)
        {
            var solution = new Solution();
            var result = solution.ClimbStairs(input);
            Assert.Equal(expected, result);
        }
    }
}

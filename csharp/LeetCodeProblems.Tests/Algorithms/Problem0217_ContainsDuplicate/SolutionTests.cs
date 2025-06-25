using Xunit;
using LeetCodeProblems.Algorithms.Problem0217_ContainsDuplicate;

namespace LeetCodeProblems.Tests.Algorithms.Problem0217_ContainsDuplicate
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void ContainsDuplicateTest1(int[] input, bool expected)
        {
            var solution = new Solution();
            var result = solution.ContainsDuplicate(input);

            Assert.Equal(expected, result);
        }
    }
}

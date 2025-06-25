using Xunit;
using LeetCodeProblems.Algorithms.Problem0027_RemoveElement;

namespace LeetCodeProblems.Tests.Algorithms.Problem0027_RemoveElement
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2 })]
        [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new[] { 0, 1, 3, 0, 4 })]
        public void RemoveElementTest1(int[] nums, int val, int[] expected)
        {
            var solution = new Solution();

            int k = solution.RemoveElement(nums, val);
            var actual = nums.Take(k).OrderBy(x => x).ToArray();
            var sortedExpected = expected.OrderBy(x => x).ToArray();

            Assert.Equal(sortedExpected.Length, k);
            Assert.Equal(sortedExpected, actual);
        }
    }
}

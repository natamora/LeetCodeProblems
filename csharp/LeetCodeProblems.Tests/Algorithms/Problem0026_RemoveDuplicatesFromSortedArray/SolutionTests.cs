using Xunit;
using LeetCodeProblems.Algorithms.Problem0026_RemoveDuplicatesFromSortedArray;

namespace LeetCodeProblems.Tests.Algorithms.Problem0026_RemoveDuplicatesFromSortedArray
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new[] { 1, 1, 2 }, new[] { 1, 2 })]
        [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new[] { 0, 1, 2, 3, 4 })]
        public void RemoveDuplicatesFromSortedArrayTest1(int[] input, int[] expected)
        {
            var solution = new Solution();
            var length = solution.RemoveDuplicates(input);
            var result = input.Take(length).ToArray();
            Assert.Equal(expected, result);
        }
    }
}

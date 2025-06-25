using Xunit;
using LeetCodeProblems.Algorithms.Problem0108_ConvertSortedArrayToBinarySearchTree;
using LeetCodeProblems.Algorithms.Common;

namespace LeetCodeProblems.Tests.Algorithms.Problem0108_ConvertSortedArrayToBinarySearchTree
{
    public class SolutionTests
    {
        [Fact]
        public void ConvertSortedArrayToBinarySearchTreeTest1()
        {
            var solution = new Solution();
            int[] input = new[] { -10, -3, 0, 5, 9 };

            var result = solution.SortedArrayToBST(input);

            var expected1 = new int?[] { 0, -10, 5, null, -3, null, 9 };
            var expected2 = new int?[] { 0, -3, 9, -10, null, 5 };

            Assert.True(TreeNode.ToList(result).SequenceEqual(expected1) || TreeNode.ToList(result).SequenceEqual(expected2));
        }

        [Fact]
        public void ConvertSortedArrayToBinarySearchTreeTest2()
        {
            var solution = new Solution();
            int[] input = new[] { 1, 3 };

            var result = solution.SortedArrayToBST(input);

            var expected1 = new int?[] { 1, null, 3 };
            var expected2 = new int?[] { 3, 1 };

            Assert.True(TreeNode.ToList(result).SequenceEqual(expected1) || TreeNode.ToList(result).SequenceEqual(expected2));
        }
    }
}

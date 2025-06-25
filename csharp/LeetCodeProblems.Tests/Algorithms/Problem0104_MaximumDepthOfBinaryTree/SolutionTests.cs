using Xunit;
using LeetCodeProblems.Algorithms.Problem0104_MaximumDepthOfBinaryTree;
using LeetCodeProblems.Algorithms.Common;

namespace LeetCodeProblems.Tests.Algorithms.Problem0104_MaximumDepthOfBinaryTree
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Solutions => new List<object[]>
        {
            new object[] { new SolutionBfs() },
            new object[] { new SolutionDfsRecursive() },
            new object[] { new SolutionDfsPreOrderIterative()}
        };

        [Theory]
        [MemberData(nameof(Solutions))]
        public void MaximumDepthOfBinaryTreeTest1(ISolution solution)
        {
            // Tree: [3, 9, 20, null, null, 15, 7]
            TreeNode root = TreeNode.FromList(new List<int?> { 3, 9, 20, null, null, 15, 7 });
            var result = solution.MaxDepth(root);
            var expected = 3;
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void MaximumDepthOfBinaryTreeTest2(ISolution solution)
        {
            // Tree: [1, null, 2]
            TreeNode root = TreeNode.FromList(new List<int?> { 1, null, 2 });
            var result = solution.MaxDepth(root);
            var expected = 2;
            Assert.Equal(expected, result);
        }
    }
}

using Xunit;
using LeetCodeProblems.Algorithms.Problem0094_BinaryTreeInorderTraversal;
using LeetCodeProblems.Algorithms.Common;

namespace LeetCodeProblems.Tests.Algorithms.Problem0094_BinaryTreeInorderTraversal
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Solutions => new List<object[]>
        {
            new object[] { new Solution() },
            new object[] { new Solution2() }
        };

        [Theory]
        [MemberData(nameof(Solutions))]
        public void BinaryTreeInorderTraversalTest1(ISolution solution)
        {
            // Tree: [1, null, 2, 3]
            TreeNode root = TreeNode.FromList(new List<int?> { 1, null, 2, 3 });

            var result = solution.InorderTraversal(root);
            var expected = new List<int> { 1, 3, 2 };

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void BinaryTreeInorderTraversalTest2(ISolution solution)
        {
            // Tree: [1, 2, 3, 4, 5, null, 8, null, null, 6, 7, 9]
            TreeNode root = TreeNode.FromList(new List<int?> { 1, 2, 3, 4, 5, null, 8, null, null, 6, 7, 9 });

            var result = solution.InorderTraversal(root);
            var expected = new List<int> { 4, 2, 6, 5, 7, 1, 3, 9, 8 };

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void BinaryTreeInorderTraversalTest3(ISolution solution)
        {
            // Tree: []
            TreeNode root = TreeNode.FromList(new List<int?> { });

            var result = solution.InorderTraversal(root);
            var expected = new List<int> { };

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void BinaryTreeInorderTraversalTest4(ISolution solution)
        {
            // Tree: [1]
            TreeNode root = TreeNode.FromList(new List<int?> { 1 });

            var result = solution.InorderTraversal(root);
            var expected = new List<int> { 1 };

            Assert.Equal(expected, result);
        }
    }
}

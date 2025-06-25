using Xunit;
using LeetCodeProblems.Algorithms.Problem0101_SymmetricTree;
using LeetCodeProblems.Algorithms.Common;

namespace LeetCodeProblems.Tests.Algorithms.Problem0101_SymmetricTree
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Solutions => new List<object[]>
        {
            new object[] { new SolutionBfs() },
            new object[] { new SolutionDfsRecursive() },
            new object[] { new SolutionDfsInOrder() }
        };

        [Theory]
        [MemberData(nameof(Solutions))]
        public void SymmetricTreeTest1(ISolution solution)
        {
            // Tree: [1, 2, 2, 3, 4, 4, 3]
            TreeNode root = TreeNode.FromList(new List<int?> { 1, 2, 2, 3, 4, 4, 3 });
            var result = solution.IsSymmetric(root);
            var expected = true;
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void SymmetricTreeTest2(ISolution solution)
        {
            // Tree: [1, 2, 2, null, 3, null, 3]
            TreeNode root = TreeNode.FromList(new List<int?> { 1, 2, 2, null, 3, null, 3 });
            var result = solution.IsSymmetric(root);
            var expected = false;
            Assert.Equal(expected, result);
        }
    }
}

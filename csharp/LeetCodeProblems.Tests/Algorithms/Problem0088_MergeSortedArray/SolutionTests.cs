using Xunit;
using LeetCodeProblems.Algorithms.Problem0088_MergeSortedArray;

namespace LeetCodeProblems.Tests.Algorithms.Problem0088_MergeSortedArray
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Solutions => new List<object[]>
        {
            new object[] {new Solution()},
            new object[] {new Solution2()}
        };

        [Theory]
        [MemberData(nameof(Solutions))]
        public void MergeSortedArrayTest1(ISolution solution)
        {
            int[] l1 = [1, 2, 3, 0, 0, 0];
            int[] l2 = [2, 5, 6];
            solution.Merge(l1, 3, l2, 3);
            Assert.Equal([1, 2, 2, 3, 5, 6], l1);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void MergeSortedArrayTest2(ISolution solution)
        {
            int[] l1 = [1];
            int[] l2 = [];
            solution.Merge(l1, 1, l2, 0);
            Assert.Equal([1], l1);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void MergeSortedArrayTest3(ISolution solution)
        {
            int[] l1 = [0];
            int[] l2 = [1];
            solution.Merge(l1, 0, l2, 1);
            Assert.Equal([1], l1);
        }
    }
}

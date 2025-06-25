using Xunit;
using LeetCodeProblems.Algorithms.Problem0021_MergeTwoSortedLists;
using LeetCodeProblems.Algorithms.Common;

namespace LeetCodeProblems.Tests.Algorithms.Problem0021_MergeTwoSortedLists
{
    public class SolutionTests
    {

        [Fact]
        public void MergeTwoSortedListsTest1()
        {
            var l1 = ListNode.CreateList([1, 2, 4]);
            var l2 = ListNode.CreateList([1, 3, 4]);
            var expected = new[] { 1, 1, 2, 3, 4, 4 };

            var solution = new Solution();
            var result = solution.MergeTwoLists(l1, l2);
            Assert.Equal(expected, ListNode.ToArray(result));
        }

        [Fact]
        public void MergeTwoSortedListsTest2()
        {
            var l1 = ListNode.CreateList([]);
            var l2 = ListNode.CreateList([]);
            var expected = Array.Empty<int>();

            var solution = new Solution();
            var result = solution.MergeTwoLists(l1, l2);
            Assert.Equal(expected, ListNode.ToArray(result));
        }

        [Fact]
        public void MergeTwoSortedListsTest3()
        {
            var l1 = ListNode.CreateList([]);
            var l2 = ListNode.CreateList([0]);
            var expected = new[] { 0 };

            var solution = new Solution();
            var result = solution.MergeTwoLists(l1, l2);
            Assert.Equal(expected, ListNode.ToArray(result));
        }
    }
}

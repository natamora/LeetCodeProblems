using Xunit;
using LeetCodeProblems.Algorithms.Problem0021_MergeTwoSortedLists;
using LeetCodeProblems.Algorithms.Common;

namespace LeetCodeProblems.Tests.Algorithms.Problem0021_MergeTwoSortedLists
{
    public class SolutionTests
    {
        private int[] ToArray(ListNode? node)
        {
            var result = new List<int>();
            while (node != null)
            {
                result.Add(node.val);
                node = node.next;
            }
            return result.ToArray();
        }

        private ListNode CreateList(int[] values)
        {
            var dummy = new ListNode();
            var current = dummy;
            foreach (var v in values)
            {
                current.next = new ListNode(v);
                current = current.next;
            }
            return dummy.next!;
        }

        [Fact]
        public void MergeTwoSortedListsTest1()
        {
            var l1 = CreateList([1, 2, 4]);
            var l2 = CreateList([1, 3, 4]);
            var expected = new[] { 1, 1, 2, 3, 4, 4 };

            var solution = new Solution();
            var result = solution.MergeTwoLists(l1, l2);
            Assert.Equal(expected, ToArray(result));
        }

        [Fact]
        public void MergeTwoSortedListsTest2()
        {
            var l1 = CreateList([]);
            var l2 = CreateList([]);
            var expected = Array.Empty<int>();

            var solution = new Solution();
            var result = solution.MergeTwoLists(l1, l2);
            Assert.Equal(expected, ToArray(result));
        }

        [Fact]
        public void MergeTwoSortedListsTest3()
        {
            var l1 = CreateList([]);
            var l2 = CreateList([0]);
            var expected = new[] { 0 };

            var solution = new Solution();
            var result = solution.MergeTwoLists(l1, l2);
            Assert.Equal(expected, ToArray(result));
        }
    }
}

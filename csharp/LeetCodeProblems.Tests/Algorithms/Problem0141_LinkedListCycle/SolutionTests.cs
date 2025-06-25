using Xunit;
using LeetCodeProblems.Algorithms.Problem0141_LinkedListCycle;
using LeetCodeProblems.Algorithms.Common;

namespace LeetCodeProblems.Tests.Algorithms.Problem0141_LinkedListCycle
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Solutions => new List<object[]>
        {
            new object[] { new SolutionFloyd() },
            new object[] { new SolutionHashSet() }
        };

        [Theory]
        [MemberData(nameof(Solutions))]
        public void LinkedListCycleTest1(ISolution solution)
        {
            var node1 = new ListNode(3);
            var node2 = new ListNode(2);
            var node3 = new ListNode(0);
            var node4 = new ListNode(-4);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node2;

            var result = solution.HasCycle(node1);

            Assert.True(result);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void LinkedListCycleTest2(ISolution solution)
        {
            var node1 = new ListNode(1);
            var node2 = new ListNode(2);

            node1.next = node2;
            node2.next = node1;

            var result = solution.HasCycle(node1);

            Assert.True(result);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void LinkedListCycleTest3(ISolution solution)
        {
            var node1 = new ListNode(1);
            var result = solution.HasCycle(node1);

            Assert.False(result);
        }
    }
}

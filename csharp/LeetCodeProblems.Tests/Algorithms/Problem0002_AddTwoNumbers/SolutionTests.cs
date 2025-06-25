using LeetCodeProblems.Algorithms.Common;
using LeetCodeProblems.Algorithms.Problem0002_AddTwoNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0002_AddTwoNumbers
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
        public void AddTwoNumbersTest1(ISolution solution)
        {
            // [2,4,3] + [5,6,4] = [7,0,8]
            var l1 = ListNode.CreateList([2, 4, 3]);
            var l2 = ListNode.CreateList([5, 6, 4]);
            var expected = new[] { 7, 0, 8 };

            var result = solution.AddTwoNumbers(l1, l2);
            Assert.Equal(expected, ListNode.ToArray(result));

        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void AddTwoNumbersTest2(ISolution solution)
        {
            // [0] + [0] = [0]
            var l1 = ListNode.CreateList([0]);
            var l2 = ListNode.CreateList([0]);
            var expected = new[] { 0 };

            var result = solution.AddTwoNumbers(l1, l2);
            Assert.Equal(expected, ListNode.ToArray(result));

        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void AddTwoNumbersTest3(ISolution solution)
        {

            // [9,9,9,9,9,9,9] + [9,9,9,9] = [8,9,9,9,0,0,0,1]
            var l1 = ListNode.CreateList([9, 9, 9, 9, 9, 9, 9]);
            var l2 = ListNode.CreateList([9, 9, 9, 9]);
            var expected = new[] { 8, 9, 9, 9, 0, 0, 0, 1 };

            var result = solution.AddTwoNumbers(l1, l2);
            Assert.Equal(expected, ListNode.ToArray(result));
        }
    }
}

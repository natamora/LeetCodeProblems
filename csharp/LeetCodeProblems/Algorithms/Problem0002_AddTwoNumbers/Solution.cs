using LeetCodeProblems.Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0002_AddTwoNumbers
{
    public class Solution : ISolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dumbNode = new ListNode();
            ListNode curr1 = l1;
            ListNode curr2 = l2;
            int next = 0;
            ListNode temp = dumbNode;
            while (curr1 != null && curr2 != null)
            {
                int res = curr1.val + curr2.val + next;
                next = (res - res % 10) / 10;
                temp.next = new ListNode(res % 10);
                temp = temp.next;
                curr1 = curr1.next;
                curr2 = curr2.next;
            }
            while (curr1 != null)
            {
                int res = curr1.val + next;
                next = (res - res % 10) / 10;
                temp.next = new ListNode(res % 10);
                temp = temp.next;
                curr1 = curr1.next;
            }
            while (curr2 != null)
            {
                int res = curr2.val + next;
                next = (res - res % 10) / 10;
                temp.next = new ListNode(res % 10);
                temp = temp.next;
                curr2 = curr2.next;
            }
            if (next > 0)
            {
                temp.next = new ListNode(next);
            }
            return dumbNode.next;
        }
    }

}

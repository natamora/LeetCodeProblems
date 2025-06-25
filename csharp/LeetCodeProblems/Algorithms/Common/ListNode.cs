using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Common
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public static ListNode CreateList(int[] values)
        {
            if (values == null || values.Length == 0)
                return null;

            var dummy = new ListNode();
            var current = dummy;
            foreach (var v in values)
            {
                current.next = new ListNode(v);
                current = current.next;
            }
            return dummy.next!;
        }

        public static int[] ToArray(ListNode? node)
        {
            var result = new List<int>();
            while (node != null)
            {
                result.Add(node.val);
                node = node.next;
            }
            return result.ToArray();
        }
    }
}

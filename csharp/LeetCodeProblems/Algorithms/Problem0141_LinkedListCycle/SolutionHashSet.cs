using LeetCodeProblems.Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0141_LinkedListCycle
{
    public class SolutionHashSet : ISolution
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();
            ListNode curr = head;
            while (curr != null)
            {
                if (visited.Contains(curr)) return true;
                visited.Add(curr);
                curr = curr.next;
            }
            return false;
        }
    }
}

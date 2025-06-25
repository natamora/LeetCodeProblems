using LeetCodeProblems.Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0021_MergeTwoSortedLists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode curr1, ListNode curr2)
        {
            ListNode final = new ListNode();

            if (curr1 == null) return curr2;
            if (curr2 == null) return curr1;

            ListNode tempFinal = final;
            while (curr1 != null && curr2 != null)
            {
                if (curr1.val < curr2.val)
                {
                    tempFinal.next = curr1;
                    curr1 = curr1.next;
                }
                else
                {
                    tempFinal.next = curr2;
                    curr2 = curr2.next;
                }
                tempFinal = tempFinal.next;
            }

            tempFinal.next = curr1 ?? curr2;

            return final.next;
        }
    }
}

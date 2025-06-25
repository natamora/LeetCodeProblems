using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0088_MergeSortedArray
{
    public class Solution2 : ISolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m, j = 0; j < n; j++, i++)
            {
                nums1[i] = nums2[j];
            }
            Array.Sort(nums1);
        }
    }
}

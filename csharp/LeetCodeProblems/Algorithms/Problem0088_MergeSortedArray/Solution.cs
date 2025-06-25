using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0088_MergeSortedArray
{
    public class Solution : ISolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0) return;

            int iter = nums1.Length - 1;

            while (m > 0 && n > 0)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[iter] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[iter] = nums2[n - 1];
                    n--;
                }
                iter--;
            }

            while (n > 0)
            {
                nums1[iter] = nums2[n - 1];
                n--;
                iter--;
            }
        }
    }
}

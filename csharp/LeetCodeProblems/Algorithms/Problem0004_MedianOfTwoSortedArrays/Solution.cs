using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0004_MedianOfTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Two Pointer Approach
            return FindMedianTwoPointer(nums1, nums2);

        }

        public double FindMedianTwoPointer(int[] nums1, int[] nums2)
        {
            int i = 0;
            int j = 0;
            List<int> merged = new List<int>();
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    merged.Add(nums1[i++]);
                }
                else
                {
                    merged.Add(nums2[j++]);
                }
            }

            while (i < nums1.Length)
            {
                merged.Add(nums1[i++]);
            }
            while (j < nums2.Length)
            {
                merged.Add(nums2[j++]);
            }

            if (merged.Count % 2 == 0)
            {
                return (double)(merged[merged.Count / 2 - 1] + merged[merged.Count / 2]) / 2.0;
            }
            else
            {
                return merged[merged.Count / 2];
            }
        }
    }
}

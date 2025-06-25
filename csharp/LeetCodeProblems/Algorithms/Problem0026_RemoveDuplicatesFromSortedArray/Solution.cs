using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0026_RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 1;
            if (nums.Length > 1)
            {
                foreach (int n in nums)
                {
                    if (n > nums[k - 1])
                        nums[k++] = n;
                }
            }
            return k;
        }
    }
}

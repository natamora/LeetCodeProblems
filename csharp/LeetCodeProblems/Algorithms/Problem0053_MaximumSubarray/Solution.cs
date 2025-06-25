using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0053_MaximumSubarray
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue;
            int currSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currSum += nums[i];
                maxSum = Math.Max(maxSum, currSum);
                currSum = currSum < 0 ? 0 : currSum;
            }

            return maxSum;
        }
    }
}

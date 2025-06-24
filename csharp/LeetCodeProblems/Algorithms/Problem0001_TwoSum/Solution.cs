using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0001_TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int[] ints = nums.Select((x, j) => x.Equals(target - nums[i]) ? j : -1)
                    .Where(j => j != i && j >= 0)
                    .ToArray();
                if (ints.Length != 0) 
                    return new int[] { i, ints[0] };
            }
            return Array.Empty<int>();
        }
    }
}

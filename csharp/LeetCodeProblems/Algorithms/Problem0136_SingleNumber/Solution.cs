using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0136_SingleNumber
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int res = 0;
            foreach (int num in nums)
            {
                res = res ^ num;    // XOR operation
            }
            return res;
        }
    }
}

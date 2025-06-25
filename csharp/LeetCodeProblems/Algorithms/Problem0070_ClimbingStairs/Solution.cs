using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0070_ClimbingStairs
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            int[] tmp = new int[n + 1];
            Array.Fill(tmp, -1);
            return Climb(n, tmp);
        }

        public int Climb(int n, int[] tmp)
        {
            if (n <= 1) return 1;
            if (tmp[n] != -1) return tmp[n];

            tmp[n] = Climb(n - 1, tmp) + Climb(n - 2, tmp);
            return tmp[n];
        }
    }
}

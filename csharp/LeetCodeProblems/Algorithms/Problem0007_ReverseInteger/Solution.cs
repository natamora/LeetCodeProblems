using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0007_ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            int res = 0;
            while (x != 0)
            {
                int d = x % 10;
                int tmp = res * 10 + d;
                if ((tmp - d) / 10 != res) return 0;
                res = tmp;
                x = x / 10;
            }
            return res;
        }
    }
}

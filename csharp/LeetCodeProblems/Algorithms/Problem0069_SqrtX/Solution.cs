using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0069_SqrtX
{
    //bruteforce
    public class Solution : ISolution
    {
        public int MySqrt(int x)
        {
            if (x == 0) return 0;
            for (int i = 1; i <= x / i; i++)
            {
                if (i <= x / i && (i + 1) > x / (i + 1))
                {
                    return Convert.ToInt32(i);
                }
            }
            return 0;
        }
    }
}

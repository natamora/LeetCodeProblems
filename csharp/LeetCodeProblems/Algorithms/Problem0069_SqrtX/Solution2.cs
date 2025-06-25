using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0069_SqrtX
{
    //binarySearch
    public class Solution2 : ISolution
    {
        public int MySqrt(int x)
        {
            if (x == 0) return 0;

            int left = 1;
            int right = x;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int sqrt = x / mid;
                if (sqrt == mid)
                    return mid;
                else if (sqrt < mid)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return right;
        }
    }
}

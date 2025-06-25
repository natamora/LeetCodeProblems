using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0066_PlusOne
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int i = digits.Length - 1;
            while (i >= 0 && digits[i] == 9)
            {
                digits[i] = 0;
                i--;
            }
            if (i < 0)
            {
                int[] newArr = new int[digits.Length + 1];
                newArr[0] = 1;
                return newArr;
            }
            else
            {
                digits[i]++;
                return digits;
            }
        }
    }
}

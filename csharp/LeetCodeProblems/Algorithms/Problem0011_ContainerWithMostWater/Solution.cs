using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0011_ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int w = right - left;
                int h = Math.Min(height[left], height[right]);
                int currArea = w * h;
                maxArea = Math.Max(currArea, maxArea);
                if (height[left] > height[right])
                    right--;
                else if (height[left] < height[right])
                    left++;
                else
                {
                    right--; left++;
                }
            }
            return maxArea;
        }
    }
}

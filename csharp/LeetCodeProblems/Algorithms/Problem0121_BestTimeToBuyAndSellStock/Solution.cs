using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0121_BestTimeToBuyAndSellStock
{
    public class Solution : ISolution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int currMin = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                // find minimum Price
                if (prices[i] < currMin) currMin = prices[i];
                int currProfit = prices[i] - currMin;
                if (maxProfit < currProfit) maxProfit = currProfit;
            }
            return maxProfit;
        }
    }
}

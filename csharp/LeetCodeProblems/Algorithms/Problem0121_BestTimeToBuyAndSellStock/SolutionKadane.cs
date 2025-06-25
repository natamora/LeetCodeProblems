using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0121_BestTimeToBuyAndSellStock
{
    public class SolutionKadane : ISolution
    {
        // Algorytm Kadane (problem największej podtablicy - znajdź taką podtablicę, która ma największą sumę) 
        public int MaxProfit(int[] prices)
        {
            int maxCurr = 0;
            int maxGlobal = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                maxCurr = Math.Max(0, maxCurr += (prices[i] - prices[i - 1])); // calculate difference
                maxGlobal = Math.Max(maxCurr, maxGlobal);
            }
            return maxGlobal;
        }
    }
}

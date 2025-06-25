using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0118_PascalsTriangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            var prev = new List<int>() { 1 };
            result.Add(prev);
            for (int i = 0; i < numRows - 1; i++)
            {
                List<int> curr = new List<int>();
                curr.Add(1);
                for (int j = 0; j < prev.Count - 1; j++)
                {
                    curr.Add(prev[j] + prev[j + 1]);
                }
                curr.Add(1);
                result.Add(curr);
                prev = curr;
            }
            return result;
        }
    }
}

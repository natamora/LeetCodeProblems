using Xunit;
using LeetCodeProblems.Algorithms.Problem0121_BestTimeToBuyAndSellStock;

namespace LeetCodeProblems.Tests.Algorithms.Problem0121_BestTimeToBuyAndSellStock
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Solutions => new List<object[]>
        {
            new object[] { new Solution() },
            new object[] { new SolutionKadane() }
        };

        [Theory]
        [MemberData(nameof(Solutions))]
        public void BestTimeToBuyAndSellStockTest1(ISolution solution)
        {
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int result = solution.MaxProfit(prices);
            int expected = 5;

            Assert.Equal(expected,result);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void BestTimeToBuyAndSellStockTest2(ISolution solution)
        {
            int[] prices = new int[] { 7, 6, 4, 3, 1 };
            int result = solution.MaxProfit(prices);
            int expected = 0;

            Assert.Equal(expected, result);
        }
    }
}

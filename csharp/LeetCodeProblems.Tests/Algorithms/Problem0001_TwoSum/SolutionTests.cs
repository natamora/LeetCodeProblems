using LeetCodeProblems.Algorithms.Problem0001_TwoSum;

namespace LeetCodeProblems.Tests.Algorithms.Problem0001_TwoSum
{
    public class SolutionTests
    {
        [Fact]
        public void TwoSumTest1()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new[] { 0, 1 }, result);

        }

        [Fact]
        public void TwoSumTest2()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new[] { 3, 2, 4 }, 6);
            Assert.Equal(new[] { 1, 2 }, result);

        }

        [Fact]
        public void TwoSumTest3()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new[] { 3, 3 }, 6);
            Assert.Equal(new[] { 0, 1 }, result);

        }
    }
}

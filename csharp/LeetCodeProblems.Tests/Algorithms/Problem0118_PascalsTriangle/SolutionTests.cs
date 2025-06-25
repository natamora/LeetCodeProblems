using Xunit;
using LeetCodeProblems.Algorithms.Problem0118_PascalsTriangle;

namespace LeetCodeProblems.Tests.Algorithms.Problem0118_PascalsTriangle
{
    public class SolutionTests
    {
        [Fact]
        public void PascalsTriangleTest1()
        {
            int input = 5;
            var solution = new Solution();

            var result = solution.Generate(input);

            var expected = new List<IList<int>>
            {
                new List<int> {1},
                new List<int> {1, 1},
                new List<int> {1, 2, 1},
                new List<int> {1, 3, 3, 1},
                new List<int> {1, 4, 6, 4, 1}
            };

            Assert.Equal(expected.Count, result.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Fact]
        public void PascalsTriangleTest2()
        {
            int input = 1;
            var solution = new Solution();

            var result = solution.Generate(input);

            var expected = new List<IList<int>>
            {
                new List<int> {1}
            };

            Assert.Equal(expected.Count, result.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
}

using LeetCodeProblems.Algorithms.Problem0011_ContainerWithMostWater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0011_ContainerWithMostWater
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new[] { 1, 1 }, 1)]
        public void ContainerWithMostWaterTest(int[] input, int expected)
        {
            var solution = new Solution();
            var result = solution.MaxArea(input);
            Assert.Equal(expected, result);
        }
    }
}

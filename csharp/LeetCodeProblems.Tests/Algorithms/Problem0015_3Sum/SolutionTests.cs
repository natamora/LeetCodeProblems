using LeetCodeProblems.Algorithms.Problem0015_3Sum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0015_3Sum
{
    public class SolutionTests
    {
        [Fact]
        public void ThreeSumTest1()
        {
            var solution = new Solution();
            var result = solution.ThreeSum([-1, 0, 1, 2, -1, -4]);
            Assert.Equal([[-1, -1, 2], [-1, 0, 1]], result);
        }

        [Fact]
        public void ThreeSumTest2()
        {
            var solution = new Solution();
            var result = solution.ThreeSum([0, 1, 1]);
            Assert.Equal([], result);
        }

        [Fact]
        public void ThreeSumTest3()
        {
            var solution = new Solution();
            var result = solution.ThreeSum([0, 0, 0]);
            Assert.Equal([[0, 0, 0]], result);
        }
    }
}

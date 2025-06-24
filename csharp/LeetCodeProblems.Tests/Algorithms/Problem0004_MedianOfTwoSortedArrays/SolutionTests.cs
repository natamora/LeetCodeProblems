using LeetCodeProblems.Algorithms.Problem0004_MedianOfTwoSortedArrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0004_MedianOfTwoSortedArrays
{
    public class SolutionTests
    {
        [Fact]
        public void MedianOfTwoSortedArraysTest1()
        {
            var solution = new Solution();
            var result = solution.FindMedianSortedArrays([1, 3], [2]);
            Assert.Equal(2.0, result);
        }

        [Fact]
        public void MedianOfTwoSortedArraysTest2()
        {
            var solution = new Solution();
            var result = solution.FindMedianSortedArrays([1, 2], [3, 4]);
            Assert.Equal(2.5, result);
        }
    }
}

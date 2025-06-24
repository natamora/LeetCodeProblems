using LeetCodeProblems.Algorithms.Problem0007_ReverseInteger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0007_ReverseInteger
{
    public class SolutionTests
    {
        [Fact]
        public void ReverseIntegerTest1()
        {
            var solution = new Solution();
            var result = solution.Reverse(123);
            Assert.Equal(321, result);
        }

        [Fact]
        public void ReverseIntegerTest2()
        {
            var solution = new Solution();
            var result = solution.Reverse(-123);
            Assert.Equal(-321, result);
        }

        [Fact]
        public void ReverseIntegerTest3()
        {
            var solution = new Solution();
            var result = solution.Reverse(120);
            Assert.Equal(21, result);
        }
    }
}

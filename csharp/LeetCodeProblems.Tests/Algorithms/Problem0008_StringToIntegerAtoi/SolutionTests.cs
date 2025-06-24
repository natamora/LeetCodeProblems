using LeetCodeProblems.Algorithms.Problem0008_StringToIntegerAtoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0008_StringToIntegerAtoi
{
    public class SolutionTests 
    {
        [Theory]
        [InlineData("42",42)]
        [InlineData("   -042", -42)]
        [InlineData("1337c0d3", 1337)]
        [InlineData("0-1", 0)]
        [InlineData("words and 987", 0)]
        public void StringToIntegerAtoiTest(string input, int expected)
        {
            var solution = new Solution();
            var result = solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }
    }
}

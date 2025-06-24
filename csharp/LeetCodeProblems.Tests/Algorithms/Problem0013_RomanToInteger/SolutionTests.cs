using LeetCodeProblems.Algorithms.Problem0013_RomanToInteger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Algorithms.Problem0013_RomanToInteger
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Solutions => new List<object[]>
        {
            new object[] {new Solution()},
            new object[] {new Solution2()}
        };

        [Theory]
        [MemberData(nameof(Solutions))]
        public void RomanToIntegerTest1(ISolution solution)
        {
            var result = solution.RomanToInt("III");
            Assert.Equal(3, result);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void RomanToIntegerTest2(ISolution solution)
        {
            var result = solution.RomanToInt("LVIII");
            Assert.Equal(58, result);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void RomanToIntegerTest3(ISolution solution)
        {
            var result = solution.RomanToInt("MCMXCIV");
            Assert.Equal(1994, result);
        }
    }
}

using Xunit;
using LeetCodeProblems.Algorithms.Problem0069_SqrtX;

namespace LeetCodeProblems.Tests.Algorithms.Problem0069_SqrtX
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
        public void SqrtXTest1(ISolution solution)
        {
            var result = solution.MySqrt(4);
            Assert.Equal(2, result);
        }

        [Theory]
        [MemberData(nameof(Solutions))]
        public void SqrtXTest2(ISolution solution)
        {
            var result = solution.MySqrt(8);
            Assert.Equal(2, result);
        }
    }
}

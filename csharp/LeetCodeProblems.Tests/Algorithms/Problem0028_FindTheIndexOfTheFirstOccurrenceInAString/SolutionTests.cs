using Xunit;
using LeetCodeProblems.Algorithms.Problem0028_FindTheIndexOfTheFirstOccurrenceInAString;

namespace LeetCodeProblems.Tests.Algorithms.Problem0028_FindTheIndexOfTheFirstOccurrenceInAString
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        public void FindTheIndexOfTheFirstOccurrenceInAStringTest1(string haystack, string needle, int expected)
        {
            var solution = new Solution();
            var result = solution.StrStr(haystack, needle);
            Assert.Equal(expected, result);
        }
    }
}

using Xunit;
using LeetCodeProblems.Algorithms.Problem0017_LetterCombinationsOfAPhoneNumber;

namespace LeetCodeProblems.Tests.Algorithms.Problem0017_LetterCombinationsOfAPhoneNumber
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [InlineData("", new string[] { })]
        [InlineData("2", new string[] { "a", "b", "c" })]
        public void LetterCombinationsOfAPhoneNumberTest1(string input, string[] expected)
        {
            var solution = new Solution();
            IList<string> result = solution.LetterCombinations(input);
            Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
        }
    }
}

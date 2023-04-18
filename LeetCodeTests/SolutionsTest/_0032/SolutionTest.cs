using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0032;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0032;

public class SolutionTest
{
    [Theory]
    [InlineData("(()", 2)]
    [InlineData(")()())", 4)]
    [InlineData("", 0)]
    public void LongestValidParenthesesTest(string s, int expected)
    {
        int actual = new Solution().LongestValidParentheses(s);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

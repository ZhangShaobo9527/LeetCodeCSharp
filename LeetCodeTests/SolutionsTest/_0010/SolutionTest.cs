using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0010;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0010;

public class SolutionTest
{
    [Theory]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "a*", true)]
    [InlineData("ab", ".*", true)]
    [InlineData("aab", "c*a*b", true)]
    [InlineData("mississippi", "mis*is*p*.", false)]
    [InlineData("aaa", "ab*a", false)]
    [InlineData("mississippi", "mis*is*ip*.", true)]
    public void IsMatchTest(string s, string p, bool expected)
    {
        bool actual = new Solution().IsMatch(s, p);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0044;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0044;

public class SolutionTest
{
    [Theory]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "*", true)]
    [InlineData("cb", "?a", false)]
    [InlineData("adceb", "*a*b", true)]
    public void IsMatchTest(string s, string p, bool expected)
    {
        bool actual = new Solution().IsMatch(s, p);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0005;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0005;

public class SolutionTest
{
    [Theory]
    [InlineData("babad", "bab")]
    [InlineData("cbbd", "bb")]
    public void LongestPalindromeTest(string s, string expected)
    {
        string actual = new Solution().LongestPalindrome(s);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0009;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0009;

public class SolutionTest
{
    [Theory]
    [InlineData(3, true)]
    [InlineData(33, true)]
    [InlineData(10, false)]
    [InlineData(0, true)]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    public void IsPalindromeTest(int x, bool expected)
    {
        bool actual = new Solution().IsPalindrome(x);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0008;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0008;

public class SolutionTest
{
    [Theory]
    [InlineData("", 0)]
    [InlineData(" ", 0)]
    [InlineData(" +", 0)]
    [InlineData(" -", 0)]
    [InlineData("42", 42)]
    [InlineData("    -42", -42)]
    [InlineData("    -  42", 0)]
    [InlineData("    +  422", 0)]
    [InlineData("4193 with words", 4193)]
    [InlineData("2147483647", 2147483647)]
    [InlineData("2147483648", 2147483647)]
    [InlineData("3147483648", 2147483647)]
    [InlineData("-2147483648", -2147483648)]
    [InlineData("-2147483649", -2147483648)]
    [InlineData("-3147483649", -2147483648)]
    [InlineData("   +78", 78)]
    public void myAtoiTest(string s, int expected)
    {
        int actual = new Solution().MyAtoi(s);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

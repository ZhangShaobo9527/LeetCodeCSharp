using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0013;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0013;

public class SolutionTest
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToIntTest(string s, int expected)
    {
        int actual = new Solution().RomanToInt(s);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

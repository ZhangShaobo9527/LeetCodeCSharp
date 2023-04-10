using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0012;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0012;

public class SolutionTest
{
    [Theory]
    [InlineData(3, "III")]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    public void IntToRomanTest(int num, string expected)
    {
        string actual = new Solution().IntToRoman(num);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

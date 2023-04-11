using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0029;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0029;

public class SolutionTest
{
    [Theory]
    [InlineData(10, 3, 3)]
    [InlineData(7, -3, -2)]
    [InlineData(int.MinValue, -1, int.MaxValue)]
    [InlineData(int.MaxValue, 2, int.MaxValue / 2)]
    [InlineData(-16, 2, -8)]
    [InlineData(16, 1, 16)]
    public void DivideTest(int dividend, int divisor, int expected)
    {
        int actual = new Solution().Divide(dividend, divisor);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

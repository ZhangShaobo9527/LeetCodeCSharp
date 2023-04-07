using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0007;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0007;

public class SolutionTest
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(2100000003, 0)]
    [InlineData(-2100000003, 0)]
    [InlineData(0, 0)]
    [InlineData(100000000, 1)]
    [InlineData(-100000000, -1)]
    public void ReverseTest(int x, int expected)
    {
        int actual = new Solution().Reverse(x);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

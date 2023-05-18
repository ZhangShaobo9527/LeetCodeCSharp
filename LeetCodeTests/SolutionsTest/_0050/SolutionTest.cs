using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0050;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0050;

public class SolutionTest
{
    [Theory]
    [InlineData(2.0, 10, 1024.0)]
    [InlineData(2.1, 3, 9.261)]
    [InlineData(2.0, -2, 0.25)]
    public void MyPowTest(double x, int n, double expected)
    {
        double actual = new Solution().MyPow(x, n);
        Assert.Equal(
            expected: expected,
            actual: actual,
            comparer: new DoubleEqualityComparer());
    }
}

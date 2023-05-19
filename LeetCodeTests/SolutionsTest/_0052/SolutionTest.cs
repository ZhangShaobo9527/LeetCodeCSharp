using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0052;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0052;

public class SolutionTest
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 0)]
    [InlineData(3, 0)]
    [InlineData(4, 2)]
    [InlineData(5, 10)]
    [InlineData(6, 4)]
    [InlineData(7, 40)]
    [InlineData(8, 92)]
    [InlineData(9, 352)]
    public void TotalNQueensTest(int n, int expected)
    {
        int actual = new Solution().TotalNQueens(n);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0011;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0011;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new int[] { 1, 1 }, 1)]
    [InlineData(new int[] { 1, 2, 1 }, 2)]
    [InlineData(new int[] { 4, 3, 2, 1, 4 }, 16)]
    public void MaxAreaTest(int[] height, int expected)
    {
        int actual = new Solution().MaxArea(height);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

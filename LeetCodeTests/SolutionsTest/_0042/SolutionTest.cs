using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0042;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0042;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    [InlineData(new int[] { 4, 2, 0, 3, 2, 5 }, 9)]
    public void TrapTest(int[] height, int expected)
    {
        int actual = new Solution().Trap(height);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

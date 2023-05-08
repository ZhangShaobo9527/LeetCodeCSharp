using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0041;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0041;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 0 }, 3)]
    [InlineData(new int[] { 3, 4, -1, 1 }, 2)]
    [InlineData(new int[] { 7, 8, 9, 11, 12 }, 1)]
    public void FirstMissingPositiveTest(int[] nums, int expected)
    {
        int actual = new Solution().FirstMissingPositive(nums);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

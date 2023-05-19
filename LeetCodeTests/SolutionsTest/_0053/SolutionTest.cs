using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0053;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0053;

public class SolutionTest
{
    [Theory]
    [InlineData(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 5, 4, -1, 7, 8 }, 23)]
    [InlineData(new[] { 5, -1, -1, -1, -1, 25 }, 26)]
    [InlineData(new[] { -2, -1, -2, -1, -2 }, -1)]
    public void MaxSubArrayTest(int[] nums, int expected)
    {
        int actual = new Solution().MaxSubArray(nums);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

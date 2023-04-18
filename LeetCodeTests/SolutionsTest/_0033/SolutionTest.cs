using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0033;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0033;

public class SolutionTest
{
    [Theory]
    [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    [InlineData(new[] { 1 }, 0, -1)]
    [InlineData(new[] { 1, 3}, 3, 1)]
    public void SearchTest(int[] nums, int target, int expected)
    {
        int actual = new Solution().Search(nums, target);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

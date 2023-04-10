using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0016;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0016;

public class SolutionTest
{
    [Theory]
    [InlineData(new[] { -1, 2, 1, -4}, 1, 2)]
    [InlineData(new[] { 0, 0, 0 }, 1, 0)]
    public void ThreeSumClosestTest(int[] nums, int target, int expected)
    {
        int actual = new Solution().ThreeSumClosest(nums, target);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

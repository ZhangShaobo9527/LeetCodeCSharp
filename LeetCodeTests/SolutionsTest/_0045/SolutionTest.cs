using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0045;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0045;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 1, 1, 4 }, 2)]
    [InlineData(new int[] { 2, 3, 0, 1, 4 }, 2)]
    [InlineData(new int[] { 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 90, 3}, 1)]
    public void JumpTest(int[] nums, int expected)
    {
        int actual = new Solution().Jump(nums);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0035;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0035;

public class SolutionTest
{
    [Theory]
    [InlineData(new[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new[] { 1, 3, 5, 6 }, 7, 4)]
    public void SearchInsertTest(int[] nums, int target, int expected)
    {
        int actual = new Solution().SearchInsert(nums, target);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

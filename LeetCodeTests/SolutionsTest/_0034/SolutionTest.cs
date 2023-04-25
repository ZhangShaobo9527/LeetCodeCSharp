using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0034;
using LeetCodeTests.TestHelper;
using System;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0034;

public class SolutionTest
{
    [Theory]
    [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 })]
    [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 })]
    [InlineData(new int[0], 0, new[] { -1, -1 })]
    public void SearchRangeTest(int[] nums, int target, int[] expected)
    {
        int[] actual = new Solution().SearchRange(nums, target);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

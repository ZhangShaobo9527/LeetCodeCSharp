using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0004;
using LeetCodeTests.TestHelper;
using System;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0004;

public class SolutionTest
{
    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 2 }, 2.0)]
    [InlineData(new[] { 1, 3 }, new[] { 2, 7 }, 2.5)]
    [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
    [InlineData(new int[0], new[] { 1 }, 1)]
    public void FindMedianSortedArraysTest(int[] nums1, int[] nums2, double expected)
    {
        double actual = new Solution().FindMedianSortedArrays(nums1, nums2);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

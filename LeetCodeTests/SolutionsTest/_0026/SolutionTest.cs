using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0026;
using LeetCodeTests.TestHelper;
using System;
using System.Linq;
using System.Reflection.Metadata;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0026;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[0], new int[0])]
    [InlineData(new[] { 1}, new[] { 1})]
    [InlineData(new[] { 1, 1, 2 }, new[] { 1, 2 })]
    [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new[] { 0, 1, 2, 3, 4 })]
    public void RemoveDuplicatesTest(int[] nums, int[] expectedNums)
    {
        int k = new Solution().RemoveDuplicates(nums);
        Assert.Equal(expected: expectedNums, actual: nums.Skip(0).Take(k).ToArray());
    }
}

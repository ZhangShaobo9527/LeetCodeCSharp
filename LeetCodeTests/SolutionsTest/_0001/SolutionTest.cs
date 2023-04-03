using LeetCodeSolutions.Solutions._0001;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0001;

public class SolutionTest
{
    [Theory]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    public void TwoSumTest(int[] nums, int target, int[] expected)
    {
        int[] actual = new Solution().TwoSum(nums, target);
        Assert.Equal(
            expected: expected,
            actual: actual,
            comparer: new ArrayEqualityComparerIgnoreOrder<int>());
    }
}

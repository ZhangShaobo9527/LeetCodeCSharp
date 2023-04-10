using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0027;
using LeetCodeTests.TestHelper;
using System.Linq;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0027;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[0], 3, new int[0])]
    [InlineData(new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2 })]
    [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new[] { 0, 1, 4, 0, 3 })]
    public void RemoveElementTest(int[] nums, int val, int[] expectedNums)
    {
        int k = new Solution().RemoveElement(nums, val);
        Assert.Equal(
            expected: expectedNums.ToList(),
            actual: nums.Skip(0).Take(k).ToList(),
            comparer: new ListEqualityComparerIgnoreOrder<int>());
    }
}

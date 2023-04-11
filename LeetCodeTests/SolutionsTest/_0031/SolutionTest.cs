using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0031;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0031;

public class SolutionTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 3, 2 })]
    [InlineData(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 1, 5 }, new[] { 1, 5, 1 })]
    public void NextPermutationTest(int[] nums, int[] expected)
    {
        new Solution().NextPermutation(nums);
        Assert.Equal(
            expected: expected,
            actual: nums);
    }
}

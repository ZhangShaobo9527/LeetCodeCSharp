using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0018;
using LeetCodeTests.TestHelper;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0018;

public class SolutionTest
{
    [Theory]
    [InlineData("[1,0,-1,0,-2,2]", 0, "[[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]")]
    [InlineData("[2,2,2,2,2]", 8, "[[2,2,2,2]]")]
    [InlineData("[1000000000,1000000000,1000000000,1000000000]", -294967296, "[]")]
    public void FourSumTest(string stringifyNums, int target, string stringifyExpected)
    {

        int[] nums = ListHelper<int>.ParseListFromString(stringifyNums, int.Parse).ToArray();
        IList<IList<int>> expected = ListHelper<int>.ParseNestedListFromString(stringifyExpected, int.Parse);
        IList<IList<int>> actual = new Solution().FourSum(nums, target);
        Assert.Equal(
            expected: expected,
            actual: actual,
            comparer: new NestedListEqualityComparerIgnoreOrder<int>());
    }
}

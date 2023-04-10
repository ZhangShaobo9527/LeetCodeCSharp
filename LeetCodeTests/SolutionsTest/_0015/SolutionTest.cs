using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0015;
using LeetCodeTests.TestHelper;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0015;

public class SolutionTest
{
    [Theory]
    [InlineData("[-1,0,1,2,-1,-4]", "[[-1,-1,2],[-1,0,1]]")]
    [InlineData("[0,1,1]", "[]")]
    [InlineData("[0,0,0]", "[[0,0,0]]")]
    public void ThreeSumTest(string stringifyNums, string stringifyExpected)
    {
        int[] nums = ListHelper<int>.ParseListFromString(stringifyNums, int.Parse).ToArray();
        IList<IList<int>> expected = ListHelper<int>.ParseNestedListFromString(stringifyExpected, int.Parse);
        IList<IList<int>> actual = new Solution().ThreeSum(nums);
        Assert.Equal(
            expected: expected,
            actual: actual,
            comparer: new NestedListEqualityComparerIgnoreOrder<int>());
    }
}

using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0040;
using LeetCodeTests.TestHelper;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0040;

public class SolutionTest
{
    public static IEnumerable<object[]> GetTestCases()
    {
        int[] candidates1 = new int[] { 10, 1, 2, 7, 6, 1, 5 };
        int target1 = 8;
        int[][] output1 = new int[][] {
            new int[]{ 1, 1, 6 },
            new int[]{ 1, 2, 5 },
            new int[]{ 1, 7 },
            new int[]{ 2, 6 }
        };

        yield return new object[] { candidates1, target1, output1 };

        int[] candidates2 = new int[] { 2, 5, 2, 1, 2 };
        int target2 = 5;
        int[][] output2 = new int[][] { 
            new int[]{ 1, 2, 2 },
            new int[]{ 5 },
        };

        yield return new object[] { candidates2, target2, output2 };
    }

    [Theory]
    [MemberData(nameof(GetTestCases))]
    public void CombinationSum2Test(int[] candidates, int target, IList<IList<int>> expected)
    {
        IList<IList<int>> actual = new Solution().CombinationSum2(candidates, target);
        Assert.Equal(
            expected: expected,
            actual: actual,
            comparer: new NestedListEqualityComparerIgnoreOrder<int>());
    }
}

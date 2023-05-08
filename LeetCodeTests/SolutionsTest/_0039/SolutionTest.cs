using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0039;
using LeetCodeTests.TestHelper;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0039;

public class SolutionTest
{
    public static IEnumerable<object[]> GetTestCases()
    {
        int[] candidates1 = new int[] { 2, 3, 6, 7 };
        int target1 = 7;
        int[][] output1 = new int[][] {
            new int[]{ 2, 2, 3 },
            new int[]{ 7 }
        };

        yield return new object[] { candidates1, target1, output1 };

        int[] candidates2 = new int[] { 2, 3, 5 };
        int target2 = 8;
        int[][] output2 = new int[][] { 
            new int[]{ 2, 2, 2, 2 },
            new int[]{ 2, 3, 3 },
            new int[]{ 3, 5 }
        };

        yield return new object[] { candidates2, target2, output2 };

        int[] candidates3 = new int[] { 2 };
        int target3 = 1;
        int[][] output3 = new int[][] { };

        yield return new object[] { candidates3, target3, output3 };

    }

    [Theory]
    [MemberData(nameof(GetTestCases))]
    public void CombinationSumTest(int[] candidates, int target, IList<IList<int>> expected)
    {
        IList<IList<int>> actual = new Solution().CombinationSum(candidates, target);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

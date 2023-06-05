using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0054;
using LeetCodeTests.TestHelper;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0054;

public class SolutionTest
{
    public static IEnumerable<object[]> GetTestCases()
    {
        int[][] matrix1 = new int[][]
        {
            new int[]{ 1,2,3},
            new int[]{ 4,5,6,},
            new int[]{ 7,8,9}
        };
        int[] output1 = new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

        yield return new object[] { matrix1, output1 };

        int[][] matrix2 = new int[][]
        {
            new int[]{ 1,2,3, 4},
            new int[]{ 5,6,7,8},
            new int[]{ 9,10,11,12}
        };
        int[] output2 = new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };

        yield return new object[] { matrix2, output2 };
    }

    [Theory]
    [MemberData(nameof(GetTestCases))]
    public void SpiralOrderTest(int[][] matrix, IList<int> expected)
    {
        IList<int> actual = new Solution().SpiralOrder(matrix);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

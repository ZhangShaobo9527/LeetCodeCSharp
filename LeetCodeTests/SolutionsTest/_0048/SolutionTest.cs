using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0048;
using LeetCodeTests.TestHelper;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0048;

public class SolutionTest
{
    public static IEnumerable<object[]> GetTestCases()
    {
        int[][] matrix1 = new int[][]
        {
            new int[]{ 1, 2, 3 },
            new int[]{ 4, 5, 6 },
            new int[]{ 7, 8, 9 },
        };

        int[][] rotatedMatrix1 = new int[][]
        {
            new int[]{ 7, 4, 1 },
            new int[]{ 8, 5, 2 },
            new int[]{ 9, 6, 3 },
        };

        yield return new object[] { matrix1, rotatedMatrix1 };

        int[][] matrix2 = new int[][]
        {
            new int[]{ 5, 1, 9, 11 },
            new int[]{ 2, 4, 8, 10 },
            new int[]{ 13, 3, 6, 7 },
            new int[]{ 15, 14, 12, 16 },
        };

        int[][] rotatedMatrix2 = new int[][]
        {
            new int[]{ 15, 13, 2, 5 },
            new int[]{ 14, 3, 4, 1},
            new int[]{ 12, 6, 8, 9},
            new int[]{ 16, 7, 10, 11}
        };

        yield return new object[] { matrix2, rotatedMatrix2 };

        int[][] matrix3 = new int[][]
        {
            new int[]{ 1,2,3,4,5 },
            new int[]{ 6,7,8,9,10 },
            new int[]{ 11,12,13,14,15 },
            new int[]{ 16,17,18,19,20 },
            new int[]{ 21,22,23,24,25 },
        };

        int[][] rotatedMatrix3 = new int[][]
        {
            new int[]{21,16,11,6,1 },
            new int[]{22,17,12,7,2 },
            new int[]{23,18,13,8,3 },
            new int[]{24,19,14,9,4 },
            new int[]{25,20,15,10,5 },
        };

        yield return new object[] { matrix3, rotatedMatrix3 };
    }

    [Theory]
    [MemberData(nameof(GetTestCases))]
    public void RotateTest(int[][] matrix, int[][] expected)
    {
        new Solution().Rotate(matrix);
        Assert.Equal(
            expected: expected,
            actual: matrix);
    }
}

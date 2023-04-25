using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0036;
using LeetCodeTests.TestHelper;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0036;

public class SolutionTest
{
    public static IEnumerable<object[]> GetTestCases()
    {
        char[][] input1 = new char[][] {
             new []{'5','3','.','.','7','.','.','.','.'}
            ,new []{'6','.','.','1','9','5','.','.','.'}
            ,new []{'.','9','8','.','.','.','.','6','.'}
            ,new []{'8','.','.','.','6','.','.','.','3'}
            ,new []{'4','.','.','8','.','3','.','.','1'}
            ,new []{'7','.','.','.','2','.','.','.','6'}
            ,new []{'.','6','.','.','.','.','2','8','.'}
            ,new []{'.','.','.','4','1','9','.','.','5'}
            ,new []{'.','.','.','.','8','.','.','7','9'}
        };
        bool output1 = true;
        yield return new object[] { input1, output1 };

        char[][] input2 = new char[][] { 
             new []{'8','3','.','.','7','.','.','.','.'}
            ,new []{'6','.','.','1','9','5','.','.','.'}
            ,new []{'.','9','8','.','.','.','.','6','.'}
            ,new []{'8','.','.','.','6','.','.','.','3'}
            ,new []{'4','.','.','8','.','3','.','.','1'}
            ,new []{'7','.','.','.','2','.','.','.','6'}
            ,new []{'.','6','.','.','.','.','2','8','.'}
            ,new []{'.','.','.','4','1','9','.','.','5'}
            ,new []{'.','.','.','.','8','.','.','7','9'}
        };

        bool output2 = false;
        yield return new object[] { input2, output2 };

        char[][] input3 = new char[][] {
             new []{'.','8','7','6','5','4','3','2','1'}
            ,new []{'2','.','.','.','.','.','.','.','.'}
            ,new []{'3','.','.','.','.','.','.','.','.'}
            ,new []{'4','.','.','.','.','.','.','.','.'}
            ,new []{'5','.','.','.','.','.','.','.','.'}
            ,new []{'6','.','.','.','.','.','.','.','.'}
            ,new []{'7','.','.','.','.','.','.','.','.'}
            ,new []{'8','.','.','.','.','.','.','.','.'}
            ,new []{'9','.','.','.','.','.','.','.','.'}
        };
        bool output3 = true;
        yield return new object[] { input3, output3 };
    }

    [Theory]
    [MemberData(nameof(GetTestCases))]
    public void IsValidSudokuTest(char[][] board, bool expected)
    {
        bool actual = new Solution().IsValidSudoku(board);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

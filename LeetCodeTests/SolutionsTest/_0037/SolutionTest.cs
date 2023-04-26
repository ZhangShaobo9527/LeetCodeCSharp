using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0037;
using LeetCodeTests.TestHelper;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0037;

public class SolutionTest
{
    public static IEnumerable<object[]> GetTestCases()
    {
        char[][] board1 = new char[][] { 
             new[] {'5','3','.','.','7','.','.','.','.'}
            ,new[] {'6','.','.','1','9','5','.','.','.'}
            ,new[] {'.','9','8','.','.','.','.','6','.'}
            ,new[] {'8','.','.','.','6','.','.','.','3'}
            ,new[] {'4','.','.','8','.','3','.','.','1'}
            ,new[] {'7','.','.','.','2','.','.','.','6'}
            ,new[] {'.','6','.','.','.','.','2','8','.'}
            ,new[] {'.','.','.','4','1','9','.','.','5'}
            ,new[] {'.','.','.','.','8','.','.','7','9'}
        };

        char[][] solved1 = new char[][] {
             new[] {'5','3','4','6','7','8','9','1','2'}
            ,new[] {'6','7','2','1','9','5','3','4','8'}
            ,new[] {'1','9','8','3','4','2','5','6','7'}
            ,new[] {'8','5','9','7','6','1','4','2','3'}
            ,new[] {'4','2','6','8','5','3','7','9','1'}
            ,new[] {'7','1','3','9','2','4','8','5','6'}
            ,new[] {'9','6','1','5','3','7','2','8','4'}
            ,new[] {'2','8','7','4','1','9','6','3','5'}
            ,new[] {'3','4','5','2','8','6','1','7','9'}
        };

        yield return new object[] { board1, solved1 };
    }

    [Theory]
    [MemberData(nameof(GetTestCases))]
    public void SolveSudokuTest(char[][] board, char[][] expectedSolvedBoard)
    {
        new Solution().SolveSudoku(board);
        Assert.Equal(
            expected: expectedSolvedBoard,
            actual: board);
    }
}

namespace LeetCodeSolutions.Solutions._0036;

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        // idx0 == the number parsed from char
        // idx1 == rowIndex
        // value == whether the number is exists in specified row
        // 
        // attention: number value is parsed by  (c - '1') instead of (c - '0')
        bool[,] existsInRow = new bool[9, 9];

        // idx0 == the number parsed from char
        // idx1 == columnIndex
        // value == whether the number is exists in specified column
        bool[,] existsInColumn = new bool[9, 9];

        // idx0 == the number parsed from char
        // idx1 == blockRowIndex
        // idx2 == blockColumnIndex
        // value == whether the number is exists in specified block
        // 
        // blockIndex = rowIndex/3, columnIndex/3
        bool[,,] existsInBlock = new bool[9, 3, 3];

        for(int row = 0; row < 9; ++row)
        {
            for(int column = 0; column < 9; ++column)
            {
                char c = board[row][column];
                if(c == '.')
                {
                    continue;
                }

                int number = c - '1';

                if (existsInRow[number, row] || existsInColumn[number, column] || existsInBlock[number, row / 3, column / 3])
                {
                    return false;
                }
                existsInRow[number, row] = existsInColumn[number, column] = existsInBlock[number, row / 3, column / 3] = true;
            }

        }

        return true;
    }
}

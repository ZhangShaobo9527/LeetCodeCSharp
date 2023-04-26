namespace LeetCodeSolutions.Solutions._0037;

public class Solution
{
    public void SolveSudoku(char[][] board)
    {
        FindNextUnsolvedPosition(board, 0, -1, out int startRow, out int startColumn);
        TrySolve(board, startRow, startColumn);
    }

    public static bool TrySolve(char[][] board, int row, int column)
    {
        if(row == -1 || column == -1)
        {
            return true;
        }

        var possibleAnswerOfCurrentPosition = FindPossibleAnswerOfPosition(board, row, column);

        if(possibleAnswerOfCurrentPosition.Count == 0)
        {
            return false;
        }

        FindNextUnsolvedPosition(board, row, column,  out int nextPositionRow, out int nextPositionColumn);

        foreach (var answer in possibleAnswerOfCurrentPosition)
        {
            board[row][column] = answer;

            if(TrySolve(board, nextPositionRow, nextPositionColumn))
            {
                return true;
            }

            board[row][column] = '.';
        }

        return false;
    }

    public static void FindNextUnsolvedPosition(char[][] board, int row, int column, out int ansRow, out int ansColumn)
    {
        do
        {
            column++;
            if (column >= 9)
            {
                column = 0;
                row++;
            }
        } while (row < 9 && column < 9 && board[row][column] != '.');

        if (row >= 9)
        {
            ansRow = -1;
            ansColumn = -1;
        }
        else
        {
            ansRow = row;
            ansColumn = column;
        }
    }

    public static HashSet<char> FindPossibleAnswerOfPosition(char[][] board, int row, int column)
    {
        var answer = new HashSet<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        for(int i = 0; i < 9; ++i)
        {
            if (board[row][i] != '.')
            {
                answer.Remove(board[row][i]);
            }

            if (board[i][column] != '.')
            {
                answer.Remove(board[i][column]);
            }
        }

        int blockRowIndexEnd = (row / 3) * 3 + 3;
        int blockColumnIndexEnd = (column / 3) * 3 + 3;

        for (int blockRowIndex = (row / 3) * 3; blockRowIndex < blockRowIndexEnd; ++blockRowIndex)
        {
            for (int blockColumnIndex = (column / 3) * 3; blockColumnIndex < blockColumnIndexEnd; ++blockColumnIndex)
            {
                if (board[blockRowIndex][blockColumnIndex] != '.')
                {
                    answer.Remove(board[blockRowIndex][blockColumnIndex]);
                }
            }
        }

        return answer;
    }
}

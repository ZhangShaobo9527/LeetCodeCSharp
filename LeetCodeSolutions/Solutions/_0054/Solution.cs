namespace LeetCodeSolutions.Solutions._0054;

public class Solution
{
    private static readonly Dictionary<string, int> direction = new Dictionary<string, int>
    {
        {"right", 0 },
        {"left", 1},
        {"down", 2},
        {"up", 3 }
    };

    private const int VISITED_MARK = 101;

    public IList<int> SpiralOrder(int[][] matrix)
    {

        List<int> res = new List<int>();

        int row = 0;
        int col = 0;
        int currentDirection = direction["right"];

        do
        {
            res.Add(matrix[row][col]);
            matrix[row][col] = VISITED_MARK;
        } while (NextStep(matrix, ref row, ref col, ref currentDirection));

        return res;
    }

    private static bool NextStep(int[][] matrix, ref int row, ref int col, ref int currentDirection)
    {
        int rowCount = matrix.Length;
        int colCount = matrix[0].Length;

        if(currentDirection == direction["right"])
        {
            if (col + 1 < colCount && matrix[row][col + 1] != VISITED_MARK)
            {
                col++;
                return true;
            }

            currentDirection = direction["down"];
            if (row + 1 < rowCount && matrix[row + 1][col] != VISITED_MARK)
            {
                row++;
                return true;
            }

            return false;
        }
        else if(currentDirection == direction["left"])
        {
            if (col - 1 >= 0 && matrix[row][col - 1] != VISITED_MARK)
            {
                col--;
                return true;
            }

            currentDirection = direction["up"];
            if (row - 1 >= 0 && matrix[row - 1][col] != VISITED_MARK)
            {
                row--;
                return true;
            }

            return false;
        }
        else if(currentDirection == direction["down"])
        {
            if(row+1 < rowCount && matrix[row + 1][col] != VISITED_MARK)
            {
                row++;
                return true;
            }

            currentDirection = direction["left"];
            if (col - 1 >= 0 && matrix[row][col - 1] != VISITED_MARK)
            {
                col--;
                return true;
            }

            return false;
        }
        else if(currentDirection == direction["up"])
        {
            if(row-1 >= 0 && matrix[row - 1][col] != VISITED_MARK)
            {
                row--;
                return true;
            }

            currentDirection = direction["right"];
            if(col + 1 < colCount && matrix[row][col+1] != VISITED_MARK)
            {
                col++;
                return true;
            }

            return false;
        }

        return false;
    }
}

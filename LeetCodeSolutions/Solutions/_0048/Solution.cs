namespace LeetCodeSolutions.Solutions._0048;

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        for(int n = matrix.Length, offset = 0 ; n > 1; n -=2, offset++)
        {
            int upLeftRow = offset;
            int upLeftCol = offset;

            int upRightRow = offset;
            int upRightCol = matrix.Length - offset - 1;

            int bottomLeftRow = matrix.Length - offset - 1;
            int bottomLeftCol = offset;

            int bottomRightRow = matrix.Length - offset - 1;
            int bottomRightCol = matrix.Length - offset - 1;

            for (int i = 0; i < n - 1; i++)
            {
                int temp = matrix[upLeftRow][upLeftCol + i];
                matrix[upLeftRow][upLeftCol + i] = matrix[bottomLeftRow - i][bottomLeftCol];
                matrix[bottomLeftRow - i][bottomLeftCol] = matrix[bottomRightRow][bottomRightCol - i];
                matrix[bottomRightRow][bottomRightCol - i] = matrix[upRightRow + i][upRightCol];
                matrix[upRightRow + i][upRightCol] = temp;
            }
        }
    }
}

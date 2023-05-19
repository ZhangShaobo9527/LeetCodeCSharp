namespace LeetCodeSolutions.Solutions._0052;

public class Solution
{
    /*
        similar with #51
    */
    public int TotalNQueens(int n)
    {
        int solutionCount = 0;
        DFSAndRecall(ref solutionCount, new SortedDictionary<int, int>(), n);

        return solutionCount;
    }

    private void DFSAndRecall(ref int solutionCount, SortedDictionary<int, int> currentSolution, int n)
    {
        int currentRow = currentSolution.Count;

        if(currentRow == n)
        {
            solutionCount++;
            return;
        }

        HashSet<int> availableCols = FindAvailableColsForCurrentRow(currentSolution, currentRow, n);

        if(availableCols.Count == 0)
        {
            return;
        }

        foreach(int col in availableCols)
        {
            currentSolution.Add(currentRow, col);
            DFSAndRecall(ref solutionCount, currentSolution, n);
            currentSolution.Remove(currentRow);
        }
    }

    private HashSet<int> FindAvailableColsForCurrentRow(SortedDictionary<int, int> currentSolution, int currentRow, int n)
    {
        HashSet<int> result = new HashSet<int>();
        for(int col = 0; col < n; ++col)
        {
            result.Add(col);
        }

        foreach(var queen in currentSolution)
        {
            result.Remove(queen.Value);

            int rowDiff = currentRow - queen.Key;
            result.Remove(queen.Value + rowDiff);
            result.Remove(queen.Value - rowDiff);
        }

        return result;
    }

    /*
        and if you carefully read the problem description, you will find that
        the solution constraint told you that n will be in the range [1, 9].

        so there is another tricky solution for this problem.

        WTF: this damn solution only beats 56.67% submissions.
             what the fuck...
    */

    public int TotalNQueens_TrickySolution(int n)
    {
        switch (n)
        {
            case 1: return 1;
            case 2: return 0;
            case 3: return 0;
            case 4: return 2;
            case 5: return 10;
            case 6: return 4;
            case 7: return 40;
            case 8: return 92;
            case 9: return 352;
            default: throw new ArgumentOutOfRangeException(nameof(n));
        }
    }


}

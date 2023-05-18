namespace LeetCodeSolutions.Solutions._0051;

public class Solution
{
    /*
        DFS + Recall

        tips:
        1.
            each row must have one queen, so as each column
            so the DFS logic in each iteration is to "find the right col pos in next row"
            instead of "find next legal position in current row or column"
    */
    public IList<IList<string>> SolveNQueens(int n)
    {
        List<SortedDictionary<int, int>> solutions = new List<SortedDictionary<int, int>>();
        SortedDictionary<int, int> currentSolution = new SortedDictionary<int, int>();

        DFSAndRecall(solutions, currentSolution, n);

        return solutions.Select(sln => ConvertSolutionFormat(sln, n)).ToList();
    }
    
    private IList<string> ConvertSolutionFormat(SortedDictionary<int, int> solution, int n)
    {
        List<string> result = new List<string>();

        foreach(var queen in solution)
        {
            int col = queen.Value;

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < n; ++i)
            {
                if(i == col)
                {
                    sb.Append("Q");
                }
                else
                {
                    sb.Append(".");
                }
            }

            result.Add(sb.ToString());
        }

        return result;
    }

    private void DFSAndRecall(
        List<SortedDictionary<int, int>> solutions,
        SortedDictionary<int, int> currentSolution,
        int n
        )
    {
        int currentRow = currentSolution.Count;

        if(currentRow == n)
        {
            // add the dup instead of reference
            solutions.Add(new SortedDictionary<int, int>(currentSolution));
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
            DFSAndRecall(solutions, currentSolution, n);
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
}

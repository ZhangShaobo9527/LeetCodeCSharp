namespace LeetCodeSolutions.Solutions._0040;

public class Solution
{
    /*
        if you fully understand the DFS solution of problem 39,
        this problem is easy to solve. (just pay attention to the magical conditional skip)
    */
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);

        List<int> currentCombination = new List<int>();
        List<IList<int>> combinations = new List<IList<int>>();

        DFSAndRecall(candidates, target, 0, currentCombination, combinations);

        return combinations;
    }

    private void DFSAndRecall(
        int[] candidates,
        int target,
        int startIndex,
        IList<int> currentCombination,
        IList<IList<int>> combinations
        )
    {
        if(target < 0)
        {
            return;
        }

        if(target == 0)
        {
            combinations.Add(currentCombination.ToList());
            return;
        }

        for(int i = startIndex; i < candidates.Length; ++i)
        {
            /*
                this conditional skip worth 30 minutes to figure out😁
            */
            if (i > startIndex && candidates[i] == candidates[i - 1])
            {
                continue;
            }

            currentCombination.Add(candidates[i]);
            DFSAndRecall(candidates, target - candidates[i], i + 1, currentCombination, combinations);
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}

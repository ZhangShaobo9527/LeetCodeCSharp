namespace LeetCodeSolutions.Solutions._0039;

public class Solution
{
    /*
        a very interesting DFS problem
    */
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> combinations = new List<IList<int>>();
        List<int> currentCombination = new List<int>();

        DFSAndRecall(candidates, target, 0, currentCombination, combinations);

        return combinations;
    }

    private void DFSAndRecall(
        int[] candidates,
        int target,
        int startIndex,
        IList<int> currentCombination,
        IList<IList<int>> combinations)
    {
        if(target < 0)
        {
            return;
        }

        if(target == 0)
        {
            // attention here: we need to add the dup of `currentCombination` to `combinations`
            // instead of the original `currentCombination` because the `currentCombination` will
            // be changed in the following DFS calls
            combinations.Add(currentCombination.ToList());
            return;
        }

        for(int i = startIndex; i < candidates.Length; ++i)
        {
            currentCombination.Add(candidates[i]);
            DFSAndRecall(candidates, target - candidates[i], i, currentCombination, combinations);
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}

namespace LeetCodeSolutions.Solutions._0046;

public class Solution
{
    /*
        take a look of problem #31
    */
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        Array.Sort(nums);

        for (int[]? p = nums; p != null; p = NextPermutation(p))
        {
            res.Add(p);
        }

        return res;
    }

    private int[]? NextPermutation(int[] nums)
    {
        if(nums.Length <= 1)
        {
            return null;
        }

        int[] dupNums = nums.ToArray();

        int k = dupNums.Length - 2;

        while (k >= 0 && dupNums[k] >= dupNums[k + 1])
        {
            k--;
        }

        if(k < 0)
        {
            return null;
        }

        int l = dupNums.Length - 1;

        while(l > k && dupNums[l] <= dupNums[k])
        {
            l--;
        }

        (dupNums[k], dupNums[l]) = (dupNums[l], dupNums[k]);

        Reverse(dupNums, k + 1, dupNums.Length - 1);

        return dupNums;
    }

    private void Reverse(int[] nums, int startIndex, int endIndex)
    {
        for(int left = startIndex, right = endIndex; left < right; ++left, --right)
        {
            (nums[left], nums[right]) = (nums[right], nums[left]);
        }
    }
}

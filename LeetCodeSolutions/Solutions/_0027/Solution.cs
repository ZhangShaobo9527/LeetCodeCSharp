namespace LeetCodeSolutions.Solutions._0027;

public class Solution
{
    /*
    there should be a better way:
        1. sort the original num
        2. binary search first index of val
        3. remove vals

    but let's just keep things simple and stupid, this is just an "easy" problem
    */
    public int RemoveElement(int[] nums, int val)
    {
        int newArrayLastIdx = -1;
        int probeIdx = 0;

        while (probeIdx < nums.Length)
        {
            if (nums[probeIdx] != val)
            {
                nums[++newArrayLastIdx] = nums[probeIdx];
            }

            probeIdx++;
        }

        return newArrayLastIdx + 1;
    }
}

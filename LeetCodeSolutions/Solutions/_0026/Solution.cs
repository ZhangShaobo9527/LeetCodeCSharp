namespace LeetCodeSolutions.Solutions._0026;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if(nums.Length <= 1)
        {
            return nums.Length;
        }

        int probeIdx = 1;
        int newArrayLastIdx = 0;

        while(probeIdx < nums.Length)
        {
            if (nums[newArrayLastIdx] != nums[probeIdx])
            {
                nums[++newArrayLastIdx] = nums[probeIdx];
            }

            probeIdx++;
        }

        return newArrayLastIdx + 1;
    }
}

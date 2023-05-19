namespace LeetCodeSolutions.Solutions._0053;

public class Solution
{
    /*
        the solution below is what so called "Kadane's Algorithm"
        
        it actually not that simple as you think it is

        the code is short, but the idea is not that easy to understand
    */
    public int MaxSubArray(int[] nums)
    {
        int result = nums[0];
        int currentMax = nums[0];

        for(int i = 1; i < nums.Length; ++i)
        {
            if(currentMax < 0)
            {
                currentMax = nums[i];
            }
            else
            {
                currentMax += nums[i];
            }

            if(currentMax > result)
            {
                result = currentMax;
            }
        }

        return result;
    }
}

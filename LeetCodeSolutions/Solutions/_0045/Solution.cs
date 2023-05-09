namespace LeetCodeSolutions.Solutions._0045;

public class Solution
{
    /*
        this is one of the most classic dynamic-programming problem

        let's say, array minSteps[...] stores the minium steps to reach each position

        that is, minSteps[i] means to reach i, the minimum steps you have to take
        
        and the problem's answer is minSteps[nums.Length - 1]

        the equations are:
            1. minSteps[0] == 0 ---------- very natural, 0 is where you begin
            2. if you know minSteps[i], then to reach positions like [i+1, ..., i+nums[i]]
               the minSteps might be minSteps[i] + 1
            3. minStep[j] == Math.Min(
                    // i is the index which less than j, but i + nums[i] >= j
                    // that means from i to j, only need one move, one step
                    minStep[i]...
                ) + 1;

        so you can construct minSteps like this:

            minSteps[0] = 0, minSteps[1, ...] = nums.Length
            for(int i = 0; i < nums.Length; ++i)
            {
                for(int j = i+1; j <= i + nums[i]; ++j)
                {
                    minSteps[j] = Min(minSteps[j], minSteps[i]+1);
                }
            }
    */
    public int Jump(int[] nums)
    {
        int[] minSteps = new int[nums.Length];
        for(int i = 0; i < nums.Length; ++i)
        {
            // this worth 10 minutes to figure out 
            if (i > 0 && nums[i] < nums[i - 1])
            {
                continue;
            }

            for(int j = i + 1; j < nums.Length && j <= i + nums[i]; ++j)
            {
                if (minSteps[j] == 0)
                {
                    minSteps[j] = minSteps[i] + 1;
                }
                else
                {
                    minSteps[j] = Math.Min(minSteps[j], minSteps[i] + 1);
                }
            }
        }

        return minSteps[nums.Length - 1];
    }
}

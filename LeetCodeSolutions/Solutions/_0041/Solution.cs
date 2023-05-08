namespace LeetCodeSolutions.Solutions._0041;

public class Solution
{
    /*
        the solution seems like bucket sort, but actually not

        it's worth 30 minutes to think about it, and manually debugging the solution to see the process
    */
    public int FirstMissingPositive(int[] nums)
    {
        for(int i = 0; i < nums.Length; ++i)
        {
            while(true)
            {
                int number = nums[i];
                int numberShouldBePlaceAt = number - 1;

                if(numberShouldBePlaceAt < 0 || numberShouldBePlaceAt >= nums.Length)
                {
                    break;
                }

                if (nums[numberShouldBePlaceAt] == number)
                {
                    break;
                }

                (nums[i], nums[numberShouldBePlaceAt]) = (nums[numberShouldBePlaceAt], nums[i]);
            }
        }

        for(int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != i + 1)
            {
                return i + 1;
            }
        }

        return nums.Length + 1;
    }
}

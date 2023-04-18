namespace LeetCodeSolutions.Solutions._0033;

public class Solution
{
    /*
        step 1 : binary search the rotate point
        step 2 : binary search the answer
    */
    public int Search(int[] nums, int target)
    {
        int rotateIndex = searchRotatePoint(nums);

        int leftLogicIndex = 0;
        int rightLogicIndex = nums.Length - 1;

        while(leftLogicIndex <= rightLogicIndex)
        {
            int middleLogicIndex = (leftLogicIndex + rightLogicIndex) / 2;
            int middleIndex = (middleLogicIndex + rotateIndex) % nums.Length;

            if (nums[middleIndex] == target)
            {
                return middleIndex;
            }

            if (nums[middleIndex] < target)
            {
                leftLogicIndex = middleLogicIndex + 1;
            }
            else
            {
                rightLogicIndex = middleLogicIndex - 1;
            }
        }

        return -1;
    }

    private int searchRotatePoint(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while(left < right)
        {
            int middle = (left + right) / 2;

            if (nums[middle] < nums[right])
            {
                right = middle;
            }
            else if (nums[middle] > nums[right])
            {
                left = middle + 1;
            }
        }

        return left;
    }
}

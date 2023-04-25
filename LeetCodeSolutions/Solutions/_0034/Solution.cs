namespace LeetCodeSolutions.Solutions._0034;

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {

        int searchResult = BinarySearch(nums, 0, nums.Length - 1, target);
        if (searchResult == -1)
        {
            return new[] { -1, -1 };
        }

        int[] result = new[] { searchResult, searchResult };

        int startIndex = 0;
        int endIndex = searchResult - 1;

        while(true)
        {
            int tempSearchResult = BinarySearch(nums, startIndex, endIndex, target);
            if(tempSearchResult == -1)
            {
                break;
            }

            result[0] = tempSearchResult;

            endIndex = tempSearchResult - 1;
        }

        startIndex = searchResult + 1;
        endIndex = nums.Length - 1;

        while(true)
        {
            int tempSearchResult = BinarySearch(nums, startIndex, endIndex, target);

            if(tempSearchResult == -1)
            {
                break;
            }

            result[1] = tempSearchResult;

            startIndex = tempSearchResult + 1;
        }

        return result;
    }

    private int BinarySearch(int[] nums, int startIndex, int endIndex, int target)
    {
        int left = startIndex;
        int right = endIndex;

        while(left <= right)
        {
            int middle = (left + right) / 2;

            if (nums[middle] == target)
            {
                return middle;
            }

            if (nums[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }

}

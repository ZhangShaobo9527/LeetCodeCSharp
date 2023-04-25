namespace LeetCodeSolutions.Solutions._0035;

public class Solution
{
    /*
        the standard binary search has two variants:

        BinarySearch
        {
            left = startIndex;
            right = endIndex;
            while(left <= right)
            {
                switch(nums[middle])
                
                    case == target: 
                        FOUND!
                    case < target:
                        left = middle + 1;
                    case > target:
                        right = middle - 1;
            }

            //!!!variant 1 : if not exists, return -1
            return -1;

            //!!!variant 2 : if not exists, return insert position index
            return left;
        }

        if the array contains repeated elements, 
        both variants can not guarantee the result is the first or last result
    */
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while(left <= right)
        {
            int middle = (left + right) / 2;
            if (nums[middle] == target)
            {
                return middle;
            }

            if (nums[middle] > target)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return left;
    }
}

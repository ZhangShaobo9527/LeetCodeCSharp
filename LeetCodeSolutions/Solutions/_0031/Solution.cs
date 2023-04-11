namespace LeetCodeSolutions.Solutions._0031;

public class Solution
{
    /*
        https://en.wikipedia.org/wiki/Permutation
        
        the section "Generation in lexicographic order" describe exactly solution of this problem
    */
    public void NextPermutation(int[] nums)
    {
        // 1. find the largest k such that a[k] < a[k+1]
        int k = nums.Length - 2;
        while (k >= 0 && nums[k] >= nums[k+1])
        {
            k--;
        }

        if(k < 0)
        {
            ReverseArrayInPlace(nums, 0, nums.Length);
            return;
        }

        // 2. find the largest index i greater thank k such that a[k] < a[i]
        int i = nums.Length - 1;
        while (nums[k] >= nums[i])
        {
            i--;
        }

        // 3. swap a[k] with that of a[i]
        int temp = nums[k];
        nums[k] = nums[i];
        nums[i] = temp;

        // 4. reverse the sequence from a[k+1] up to and including the final element a[n]
        ReverseArrayInPlace(nums, k + 1, nums.Length - k - 1);
    }

    private void ReverseArrayInPlace<T>(T[] nums, int startIdx, int length)
    {
        int left = startIdx;
        int right = startIdx + length - 1;

        while(left < right)
        {
            T temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;

            left++;
            right--;
        }
    }
}

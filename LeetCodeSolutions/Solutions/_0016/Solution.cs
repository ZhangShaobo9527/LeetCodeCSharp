namespace LeetCodeSolutions.Solutions._0016;

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int? res = null;

        List<int> sortedNums = nums.ToList();
        sortedNums.Sort();

        for(int i = 0; i < nums.Length; ++i)
        {
            if(i > 0 && nums[i-1] == nums[i])
            {
                continue;
            }

            int A = nums[i];

            for(int j = i+1; j < nums.Length; ++j)
            {
                if(j > i + 1 && nums[j-1] == nums[j])
                {
                    continue;
                }
                int B = nums[j];

                for(int k = j + 1; k < nums.Length; ++k)
                {
                    if(k > j + 1 && nums[k-1] == nums[k])
                    {
                        continue;
                    }

                    int C = nums[k];

                    int threeSum = A + B + C;
                    if(threeSum == target)
                    {
                        return target;
                    }

                    if(res is null)
                    {
                        res = A + B + C;
                    }
                    else if(Math.Abs(threeSum - target) < Math.Abs(res.Value - target))
                    {
                        res = threeSum;
                    }
                }
            }
        }

        return res!.Value;
    }
}

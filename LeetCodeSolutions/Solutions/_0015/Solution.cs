namespace LeetCodeSolutions.Solutions._0015;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> res = new List<IList<int>>();

        List<int> sortedNums = nums.ToList();
        sortedNums.Sort();
        for(int i = 0; i < sortedNums.Count; ++i)
        {
            if(i > 0 && sortedNums[i-1] == sortedNums[i])
            {
                continue;
            }

            int A = sortedNums[i];

            int left = i + 1;
            int right = sortedNums.Count - 1;
            while(left < right)
            {
                int B = sortedNums[left];
                int C = sortedNums[right];

                if(A + B + C == 0)
                {
                    res.Add(new List<int>() { A, B, C });
                    while(left < sortedNums.Count && sortedNums[left] == B)
                    {
                        left++;
                    }
                    while(right > i && sortedNums[right] == C)
                    {
                        right--;
                    }
                }
                else if(A + B + C > 0)
                {
                    while(right > i && sortedNums[right] == C)
                    {
                        right--;
                    }
                }
                else
                {
                    while(left < sortedNums.Count && sortedNums[left] == B)
                    {
                        left++;
                    }
                }
            }
        }

        return res;
    }
}

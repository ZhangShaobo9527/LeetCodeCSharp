namespace LeetCodeSolutions.Solutions._0018;

public class Solution
{
    /*
        tip: 
            according to the problem descprition, A/B/C/D/target is in range [-10^9 .. 10^9]
            and considering that int.Max and int.Min is approximately 2.1*10^9 and -2.1*10^9
            that means A+B+C+D might overflow out of int range
    */
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> sortedNums = nums.ToList();
        sortedNums.Sort();

        for(int i = 0; i < sortedNums.Count; ++i)
        {
            int A = sortedNums[i];
            if(i > 0 && sortedNums[i] == sortedNums[i-1])
            {
                continue;
            }

            for(int j = i + 1; j < sortedNums.Count; ++j)
            {
                int B = sortedNums[j];
                if (j > i + 1 && sortedNums[j] == sortedNums[j - 1])
                {
                    continue;
                }

                for (int left = j + 1, right = sortedNums.Count - 1; left < right;)
                {
                    int C = sortedNums[left];
                    int D = sortedNums[right];

                    if(left > j + 1 && sortedNums[left] == sortedNums[left-1])
                    {
                        left++;
                        continue;
                    }

                    if (right < sortedNums.Count - 1 && sortedNums[right] == sortedNums[right + 1])
                    {
                        right--;
                        continue;
                    }

                    /*
                        the IDE intellisense might tell you that explicit cast before A/B/C/D is un-necessary
                        it is necessary actually.

                        if you write the following code:
                            long fourSum = A + B + C + D;
                        the expression right after equal sign will results to an <int> result first, then cast the result to <long>.
                        😑 god damn it!
                    */
                    long fourSum = (long)A + (long)B + (long)C + (long)D;
                    if(fourSum > target)
                    {
                        right--;
                    }
                    else if(fourSum < target)
                    {
                        left++;
                    }
                    else
                    {
                        res.Add(new List<int> { A, B, C, D });
                        left++;
                        right--;
                    }
                }

            }
        }

        return res;
    }
}

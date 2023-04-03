using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions.Solutions._0001;

public class Solution
{
    private static void RecordNumberIndex(Dictionary<int, List<int>> indexOfNumber, int number, int index)
    {
        if (indexOfNumber.ContainsKey(number))
        {
            indexOfNumber[number].Add(index);
        }
        else
        {
            indexOfNumber[number] = new List<int> { index };
        }
    }

    public int[] TwoSum(int[] nums, int target)
    {
        int[] res = new int[2];

        Dictionary<int, List<int>> indexesOfNumber = new Dictionary<int, List<int>>();

        for (int AIndex = 0; AIndex < nums.Length; ++AIndex)
        {
            int A = nums[AIndex];
            int B = target - A;

            RecordNumberIndex(indexesOfNumber, A, AIndex);

            if (!indexesOfNumber.ContainsKey(B))
            {
                continue;
            }

            if (A == B && indexesOfNumber[A].Count < 2)
            {
                continue;
            }

            res[0] = indexesOfNumber[A].First();
            res[1] = indexesOfNumber[B].Last();
            break;
        }

        return res;
    }
}

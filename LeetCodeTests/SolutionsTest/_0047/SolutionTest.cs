using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0047;
using LeetCodeTests.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0047;

public class SolutionTest
{
    public static IEnumerable<object[]> GetTestCases()
    {
        int[] nums1 = new int[] { 1, 2, 3 };
        int[][] output1 = new int[][] 
        {
            new int[]{ 1, 2, 3 },
            new int[]{ 1, 3, 2 },
            new int[]{ 2, 1, 3 },
            new int[]{ 2, 3, 1 },
            new int[]{ 3, 1, 2 },
            new int[]{ 3, 2, 1 },
        };

        yield return new object[] { nums1, output1 };

        int[] nums2 = new int[] { 1, 1, 2 };
        int[][] output2 = new int[][]
        {
            new int[]{ 1, 1, 2 },
            new int[]{ 1, 2, 1 },
            new int[]{ 2, 1, 1 },
        };

        yield return new object[] { nums2, output2 };
    }

    [Theory]
    [MemberData(nameof(GetTestCases))]
    public void PermuteUniqueTest(int[] nums, IList<IList<int>> expected)
    {
        IList<IList<int>> actual = new Solution().PermuteUnique(nums);

        Func<IList<int>, string> stringifyNumericList = (list) => 
        {
            StringBuilder sb = new StringBuilder();
            foreach(var e in list)
            {
                sb.Append($"{e},");
            }
            return sb.ToString();
        };

        Assert.Equal(
            expected: expected.Select(stringifyNumericList).ToList(),
            actual: actual.Select(stringifyNumericList).ToList(),
            comparer: new ListEqualityComparerIgnoreOrder<string>());
    }
}

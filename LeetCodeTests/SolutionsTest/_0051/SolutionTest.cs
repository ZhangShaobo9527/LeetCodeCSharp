using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0051;
using LeetCodeTests.TestHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0051;

public class SolutionTest
{
    public static IEnumerable<object[]> GetTestCases()
    {
        int n1 = 4;
        string[][] output1 = new string[][]
        {
            new string[]
            {
                ".Q..",
                "...Q",
                "Q...",
                "..Q."
            },
            new string[]
            {
                "..Q.",
                "Q...",
                "...Q",
                ".Q.."
            }
        };

        yield return new object[] { n1, output1 };

        int n2 = 1;
        string[][] output2 = new string[][]
        {
            new string[]
            {
                "Q"
            }
        };

        yield return new object[] { n2, output2 };
    }

    [Theory]
    [MemberData(nameof(GetTestCases))]
    public void SolveNQueensTest(int n, IList<IList<string>> expected)
    {
        IList<IList<string>> actual = new Solution().SolveNQueens(n);

        Func<IList<string>, string> stringifyStringList = (IList<string> stringList) =>
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in stringList)
            {
                sb.Append($"{s},");
            }
            return sb.ToString();
        };

        Assert.Equal(
            expected: expected.Select(stringList => stringifyStringList(stringList)).ToList(),
            actual: actual.Select(stringList => stringifyStringList(stringList)).ToList(),
            comparer: new ListEqualityComparerIgnoreOrder<string>());
    }
}

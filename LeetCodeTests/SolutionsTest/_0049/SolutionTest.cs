using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0049;
using LeetCodeTests.TestHelper;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0049;

public class SolutionTest
{
    public static IEnumerable<object[]> GetTestCases()
    {
        string[] input1 = new string[] {"eat","tea","tan","ate","nat","bat" };
        string[][] output1 = new string[][] 
        {
            new string[]{ "bat"},
            new string[]{ "nat", "tan"},
            new string[]{ "ate", "eat", "tea"}
        };

        yield return new object[] { input1, output1 };

        string[] input2 = new string[] { "" };
        string[][] output2 = new string[][]
        {
            new string[]{ ""}
        };

        yield return new object[] { input2, output2 };

        string[] input3 = new string[] { "a" };
        string[][] output3 = new string[][]
        {
            new string[]{ "a"}
        };

        yield return new object[] { input3, output3 };
    }

    [Theory]
    [MemberData(nameof(GetTestCases))]
    public void GroupAnagramsTest(string[] strs, IList<IList<string>> expected)
    {
        IList<IList<string>> actual = new Solution().GroupAnagrams(strs);
        Assert.Equal(
            expected: expected,
            actual: actual,
            comparer: new NestedListEqualityComparerIgnoreOrder<string>());
    }
}

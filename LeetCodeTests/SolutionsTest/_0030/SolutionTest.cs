using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0030;
using LeetCodeTests.TestHelper;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0030;

public class SolutionTest
{
    [Theory]

    [InlineData("barfoothefoobarman", new[] {"foo","bar" }, new[] { 0, 9})]
    [InlineData("wordgoodgoodgoodbestword", new[] { "word", "good", "best", "word" }, new int[0])]
    [InlineData("barfoofoobarthefoobarman", new[] { "bar", "foo", "the" }, new[] { 6, 9, 12 })]
    public void FindSubstringTest(string s, string[] words, IList<int> expected)
    {
        IList<int> actual = new Solution().FindSubstring(s, words);
        Assert.Equal(
            expected: expected,
            actual: actual,
            comparer: new ListEqualityComparerIgnoreOrder<int>());
    }
}

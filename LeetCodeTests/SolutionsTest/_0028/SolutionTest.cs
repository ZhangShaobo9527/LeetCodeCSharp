using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0028;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0028;

public class SolutionTest
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    public void StrStrTest(string haystack, string needle, int expected)
    {
        int actual = new Solution().StrStr(haystack, needle);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

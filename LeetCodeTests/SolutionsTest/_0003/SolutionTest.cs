using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0003;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0003;

public class SolutionTest
{
    [Theory]
    /*[InlineData]() */
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("ghzlmcbupghakjchubyguiosldfhghabcdefghijklmnopqrstuvwxyajklcmgthoxnbgbsiugbg", 25)]
    [InlineData("", 0)]
    public void LengthOfLongestSubstringTest(string s, int expected)
    {
        int actual = new Solution().LengthOfLongestSubstring(s);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0014;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0014;

public class SolutionTest
{
    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    public void LongestCommonPrefixTest(string[] strs, string expected)
    {
        string actual = new Solution().LongestCommonPrefix(strs);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

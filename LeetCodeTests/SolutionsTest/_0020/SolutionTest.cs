using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0020;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0020;

public class SolutionTest
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("()[]}", false)]
    [InlineData("", true)]
    [InlineData("(([[[[{{}}]]]]))()[[()]]", true)]
    public void IsValidTest(string s, bool expected)
    {
        bool actual = new Solution().IsValid(s);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

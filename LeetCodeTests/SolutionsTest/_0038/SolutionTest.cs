using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0038;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0038;

public class SolutionTest
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(4, "1211")]
    [InlineData(5, "111221")]
    [InlineData(6, "312211")]
    [InlineData(7, "13112221")]
    [InlineData(8, "1113213211")]
    [InlineData(9, "31131211131221")]
    [InlineData(10, "13211311123113112211")]
    [InlineData(11, "11131221133112132113212221")]
    [InlineData(12, "3113112221232112111312211312113211")]
    public void CountAndSayTest(int n, string expected)
    {
        string actual = new Solution().CountAndSay(n);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

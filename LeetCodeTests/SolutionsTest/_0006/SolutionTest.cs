using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0006;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0006;

public class SolutionTest
{
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    public void ConvertTest(string s, int numRows, string expected)
    {
        string actual = new Solution().Convert(s, numRows);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0043;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0043;

public class SolutionTest
{
    [Theory]
    [InlineData("2", "3", "6")]
    [InlineData("123", "456", "56088")]
    public void MultiplyTest(string num1, string num2, string expected)
    {
        string actual = new Solution().Multiply(num1, num2);
        Assert.Equal(
            expected: expected,
            actual: actual);
    }
}

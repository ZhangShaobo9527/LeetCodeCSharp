using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0022;
using LeetCodeTests.TestHelper;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0022;

public class SolutionTest
{
    [Theory]
    [InlineData(1, new[] { "()" })]
    [InlineData(2, new[] { "()()", "(())" })]
    [InlineData(3, new[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
    [InlineData(4, new[] { "(((())))", "((()()))", "((())())", "((()))()", "(()(()))", "(()()())", "(()())()", "(())(())", "(())()()", "()((()))", "()(()())", "()(())()", "()()(())", "()()()()" })]
    public void GenerateParenthesisTest(int n, IList<string> expected)
    {
        IList<string> actual = new Solution().GenerateParenthesis(n);
        Assert.Equal(
            expected: expected,
            actual: actual,
            comparer: new ListEqualityComparerIgnoreOrder<string>());
    }
}

using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0017;
using LeetCodeTests.TestHelper;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0017;

public class SolutionTest
{
    [Theory]
    [InlineData("23", new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
    [InlineData("", new string[0])]
    [InlineData("2", new[] { "a", "b", "c" })]
    public void LetterCombinationsTest(string digits, IList<string> expected)
    {
        IList<string> actual = new Solution().LetterCombinations(digits);
        Assert.Equal(
            expected: expected,
            actual: actual,
            comparer: new ListEqualityComparerIgnoreOrder<string>());
    }
}

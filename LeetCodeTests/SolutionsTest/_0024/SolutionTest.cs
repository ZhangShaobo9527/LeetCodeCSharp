using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0024;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0024;

public class SolutionTest
{
    [Theory]
    [InlineData("[1,2,3,4]", "[2,1,4,3]")]
    [InlineData("[]", "[]")]
    [InlineData("[1]", "[1]")]
    [InlineData("[2,5,3,4,6,2,2]", "[5,2,4,3,2,6,2]")]
    public void SwapPairsTest(string stringifyList, string stringifyExpected)
    {
        ListNode? actual = new Solution().SwapPairs(LinkedListHelper.ParseLinkedListFromString(stringifyList));
        Assert.Equal(
            expected: stringifyExpected,
            actual: LinkedListHelper.Stringify(actual),
            comparer: new StringifyLinkedListEqualityComparer());
    }
}

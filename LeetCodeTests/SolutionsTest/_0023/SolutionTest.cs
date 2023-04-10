using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0023;
using LeetCodeTests.TestHelper;
using System.Linq;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0023;

public class SolutionTest
{
    [Theory]
    [InlineData(new[] { "[1,4,5]", "[1,3,4]", "[2,6]" }, "[1,1,2,3,4,4,5,6]")]
    [InlineData(new string[0], "[]")]
    [InlineData(new[] { "[]" }, "[]")]
    public void MergeKListsTest(string[] stringifyLists, string stringifyExpectedList)
    {
        ListNode? actual = new Solution().MergeKLists(stringifyLists.Select(str => LinkedListHelper.ParseLinkedListFromString(str)).ToArray());
        Assert.Equal(
            expected: stringifyExpectedList,
            actual: LinkedListHelper.Stringify(actual),
            comparer: new StringifyLinkedListEqualityComparer());
    }
}

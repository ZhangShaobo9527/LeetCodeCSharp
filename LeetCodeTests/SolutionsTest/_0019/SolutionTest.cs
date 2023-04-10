using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0019;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0019;

public class SolutionTest
{
    [Theory]
    [InlineData("[1,2,3,4,5]", 2, "[1,2,3,5]")]
    [InlineData("[1]", 1, "[]")]
    [InlineData("[1,2]", 1, "[1]")]
    public void RemoveNthFromEndTest(string stringifyList, int n, string stringifyExpectedList)
    {
        ListNode head = LinkedListHelper.ParseLinkedListFromString(stringifyList)!;
        string actual = LinkedListHelper.Stringify(new Solution().RemoveNthFromEnd(head, n));
        Assert.Equal(
            expected: stringifyExpectedList,
            actual: actual,
            comparer: new StringifyLinkedListEqualityComparer());
    }
}

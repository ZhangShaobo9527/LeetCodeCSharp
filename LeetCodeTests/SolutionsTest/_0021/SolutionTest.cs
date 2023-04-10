using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0021;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0021;

public class SolutionTest
{
    [Theory]
    [InlineData("[1,2,4]", "[1,3,4]", "[1,1,2,3,4,4]")]
    [InlineData("[]", "[]", "[]")]
    [InlineData("[1,2]", "[3,4,5]", "[1,2,3,4,5]")]
    [InlineData("[]", "[0]", "[0 ]")]
    public void MergeTwoListsTest(string stringifyList1, string stringifyList2, string stringifyExpected)
    {
        ListNode? list1 = LinkedListHelper.ParseLinkedListFromString(stringifyList1);
        ListNode? list2 = LinkedListHelper.ParseLinkedListFromString(stringifyList2);
        string actual = LinkedListHelper.Stringify(new Solution().MergeTwoLists(list1, list2));
        Assert.Equal(
            expected: stringifyExpected,
            actual: actual,
            comparer: new StringifyLinkedListEqualityComparer());
    }
}

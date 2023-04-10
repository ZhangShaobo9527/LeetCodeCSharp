using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0025;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0025;

public class SolutionTest
{
    [Theory]
    [InlineData("[1,2,3,4,5]", 2, "[2,1,4,3,5]")]
    [InlineData("[1,2,3,4,5]", 3, "[3,2,1,4,5]")]
    public void ReverseKGroupTest(string stringifyList, int k, string stringifyExpected)
    {
        ListNode? actual = new Solution().ReverseKGroup(LinkedListHelper.ParseLinkedListFromString(stringifyList), k);
        Assert.Equal(
            expected: stringifyExpected,
            actual: LinkedListHelper.Stringify(actual),
            comparer: new StringifyLinkedListEqualityComparer());
    }
}

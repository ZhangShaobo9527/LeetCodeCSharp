using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._0002;
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._0002;

public class SolutionTest
{
    [Theory]
    [InlineData("[2, 4, 3]", "[5, 6, 4]", "[7, 0, 8]")]
    [InlineData("[0]", "[0]", "[0]")]
    [InlineData("[9,9,9,9,9,9,9]", "[9,9,9,9]", "[8,9,9,9,0,0,0,1]")]
    public void AddTwoNumbersTest(string l1Str, string l2Str, string expectedStr)
    {
        ListNode? actual = new Solution().AddTwoNumbers(
            LinkedListHelper.ParseLinkedListFromString(l1Str), 
            LinkedListHelper.ParseLinkedListFromString(l2Str));
        Assert.Equal(
            expected:expectedStr,
            actual: LinkedListHelper.Stringify(actual),
            comparer: new StringifyLinkedListEqualityComparer());
    }
}

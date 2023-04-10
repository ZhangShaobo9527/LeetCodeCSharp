using LeetCodeSolutions.Definitions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.TestHelper;

internal class StringifyLinkedListEqualityComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        if(x is null || y is null)
        {
            throw new Exception("stringify list should not be null");
        }

        ListNode? lx = LinkedListHelper.ParseLinkedListFromString(x);
        ListNode? ly = LinkedListHelper.ParseLinkedListFromString(y);

        return new LinkedListEqualityComparer().Equals(lx, ly);
    }

    public int GetHashCode([DisallowNull] string obj)
    {
        throw new NotImplementedException();
    }
}

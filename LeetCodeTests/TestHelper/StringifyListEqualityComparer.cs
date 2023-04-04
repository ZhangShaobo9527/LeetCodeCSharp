using LeetCodeSolutions.Definitions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.TestHelper
{
    internal class StringifyListEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if(x is null || y is null)
            {
                throw new Exception("stringify list should not be null");
            }

            ListNode? lx = ListHelper.ParseLinkedListFromString(x);
            ListNode? ly = ListHelper.ParseLinkedListFromString(y);

            return new ListEqualityComparer().Equals(lx, ly);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            throw new NotImplementedException();
        }
    }
}

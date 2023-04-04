using LeetCodeSolutions.Definitions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.TestHelper
{
    internal class ListEqualityComparer : IEqualityComparer<ListNode?>
    {
        public bool Equals(ListNode? l1, ListNode? l2)
        {
            if (l1 == null && l2 == null)
            {
                return true;
            }

            if (l1 == null || l2 == null)
            {
                return false;
            }

            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val)
                {
                    return false;
                }

                l1 = l1.next;
                l2 = l2.next;
            }

            if (l1 == null && l2 == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode([DisallowNull] ListNode obj)
        {
            throw new NotImplementedException();
        }
    }
}

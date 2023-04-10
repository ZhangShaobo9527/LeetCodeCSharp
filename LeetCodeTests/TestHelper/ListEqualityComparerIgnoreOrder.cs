using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.TestHelper;

internal class ListEqualityComparerIgnoreOrder<T> : IEqualityComparer<IList<T>> where T : IComparable<T>
{
    public bool Equals(IList<T>? x, IList<T>? y)
    {
        if(x is null && y is null)
        {
            return true;
        }

        if(x is null || y is null)
        {
            return false;
        }

        if(x.Count != y.Count)
        {
            return false;
        }

        var sortedX = x.Order().ToList();
        var sortedY = y.Order().ToList();

        for(int i = 0; i < sortedX.Count; ++i)
        {
            if (sortedX[i].CompareTo(sortedY[i]) != 0)
            {
                return false;
            }
        }

        return true;

    }

    public int GetHashCode([DisallowNull] IList<T> obj)
    {
        throw new NotImplementedException();
    }
}

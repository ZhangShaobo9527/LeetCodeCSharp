using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.TestHelper;

internal class ArrayEqualityComparerIgnoreOrder<T> : IEqualityComparer<T[]> where T : IComparable<T>
{
    public bool Equals(T[]? x, T[]? y)
    {
        if(x is null && y is null)
        {
            return true;
        }

        if(x is null || y is null)
        {
            return false;
        }

        if(x.Length != y.Length)
        {
            return false;
        }

        List<T> sortedX = x.ToList();
        sortedX.Sort();
        List<T> sortedY = y.ToList();
        sortedY.Sort();
        for(int i = 0; i < sortedX.Count; ++i)
        {
            if (sortedX[i].CompareTo(sortedY[i]) != 0)
            {
                return false;
            }
        }

        return true;
    }

    public int GetHashCode([DisallowNull] T[] obj)
    {
        throw new NotImplementedException();
    }
}

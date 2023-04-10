using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.TestHelper;

internal class NestedListEqualityComparerIgnoreOrder<T> : IEqualityComparer<IList<IList<T>>> where T : IComparable
{
    public bool Equals(IList<IList<T>>? x, IList<IList<T>>? y)
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

        List<List<T>> listX = x.Select(l => l.Order().ToList()).ToList();
        List<List<T>> listY = y.Select(l => l.Order().ToList()).ToList();

        Func<List<T>, string> stringifyList = (l) => 
        { 
            if(l is null)
            {
                return "null";
            }
            StringBuilder sb = new StringBuilder();
            foreach (var e in l)
            {
                sb.Append($"{e.ToString()}_");
            }
            return sb.ToString();

        };
        
        listX = listX.OrderBy(stringifyList).ToList();
        listY = listY.OrderBy(stringifyList).ToList();

        Func<List<List<T>>, string> stringifyNestedList = (ll) =>
        { 
            StringBuilder sb = new StringBuilder();
            foreach(var l in ll)
            {
                sb.Append($"{stringifyList(l)}_");
            }
            return sb.ToString();
        };

        return string.Compare(stringifyNestedList(listX), stringifyNestedList(listY)) == 0;
    }

    public int GetHashCode([DisallowNull] IList<IList<T>> obj)
    {
        throw new NotImplementedException();
    }
}

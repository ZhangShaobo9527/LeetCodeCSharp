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
        IList<int> xNodes = ListHelper<int>.ParseListFromString(x!, int.Parse);
        IList<int> yNodes = ListHelper<int>.ParseListFromString(y!, int.Parse);

        if(xNodes.Count != yNodes.Count)
        {
            return false;
        }

        for(int i = 0; i < xNodes.Count; ++i)
        {
            if (xNodes[i] != yNodes[i])
            {
                return false;
            }
        }

        return true;
    }

    public int GetHashCode([DisallowNull] string obj)
    {
        throw new NotImplementedException();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.TestHelper;

internal static class ListHelper<T>
{
    public static IList<T> ParseListFromString(string line, Func<string, T> parser)
    {
        List<T> res = new List<T>();
        if(string.IsNullOrEmpty(line))
        {
            return res;
        }

        line = line.Trim();
        var elementStrs = line.Substring(1, line.Length - 2)
            .Split(",")
            .Select(e => e.Trim())
            .Where(e => !string.IsNullOrEmpty(e));
        foreach(string e in elementStrs)
        {
            res.Add(parser.Invoke(e));
        }
        return res;
    }

    public static IList<IList<T>> ParseNestedListFromString(string line, Func<string, T> parser)
    {
        List<IList<T>> res = new List<IList<T>>();
        if(string.IsNullOrEmpty(line))
        {
            return res;
        }

        line = line.Trim();
        line = line.Substring(1, line.Length - 2).Trim();
        int startIdx = 0;

        for(
            int left = line.IndexOf('[', startIdx), right = line.IndexOf(']', startIdx);
            left != -1 && right != -1;
            left = line.IndexOf('[', startIdx), right = line.IndexOf(']', startIdx)
            )
        {
            res.Add(ParseListFromString(line.Substring(left, right - left + 1), parser));
            startIdx = right + 1;
            if(startIdx >= line.Length)
            {
                break;
            }
            while (line[startIdx] == ' ' || line[startIdx] == ',')
            {
                startIdx++;
            }
        }

        return res;
    }
}

namespace LeetCodeSolutions.Solutions._0010;

public class Solution
{

    /*
        tip: recursively
    */

    public bool IsMatch(string s, string p)
    {
        return IsMatch(s, 0, p, 0);
    }

    private bool IsMatch(string s, int si, string p, int pi)
    {
        int sLength = s.Length - si;
        int pLength = p.Length - pi;

        if(pLength <= 0)
        {
            return sLength <= 0;
        }

        if(pLength == 1)
        {
            if(sLength != 1)
            {
                return false;
            }

            if (s[si] == p[pi] || p[pi] == '.')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // pLength >= 2
        if (p[pi+1] != '*')
        {
            if(sLength <= 0)
            {
                return false;
            }

            if (s[si] != p[pi] && p[pi] != '.')
            {
                return false;
            }

            return IsMatch(s, si + 1, p, pi + 1);
        }

        // pLength >= 2 && p[pi + 1] == '*'
        if (p[pi] == '.')
        {
            for(int skipCharCount = 0; skipCharCount <= sLength; ++skipCharCount)
            {
                if(IsMatch(s, si+skipCharCount, p, pi+2))
                {
                    return true;
                }
            }
        }

        // pLength >= 2 && p[pi + 1] == '*'
        if (p[pi] != '.')
        {
            if(IsMatch(s, si, p, pi+2))
            {
                return true;
            }

            for(int skipCharCount = 1; skipCharCount <= sLength && s[si+skipCharCount-1] == p[pi]; ++skipCharCount)
            {
                if(IsMatch(s, si+skipCharCount, p, pi+2))
                {
                    return true;
                }
            }
        }

        return false;
    }
}

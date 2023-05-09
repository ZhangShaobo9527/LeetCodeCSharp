namespace LeetCodeSolutions.Solutions._0044;

public class Solution
{
    public bool IsMatch(string s, string p)
    {
        int si = 0, pi = 0;
        int recallSi = -1, recallPi = -1;

        while(si < s.Length)
        {
            // scenario 1: just matched or pi points to `?`
            if(pi < p.Length && (p[pi] == '?' || (p[pi] != '*' && p[pi] == s[si])))
            {
                si++;
                pi++;
                continue;
            }

            // scenario 2: pi points to `*`, DFS and store recall context
            if (pi < p.Length && p[pi] == '*')
            {
                pi++;
                if(pi == p.Length)
                {
                    // if code goes here, means `*` is the last char in `p`
                    // so no matter what the rest of `s` is, it will match
                    return true;
                }

                recallSi = si;
                recallPi = pi;
                continue;
            }

            // scenario 3: if code goes here, means match failed on current char
            //             recall context and try to match next char if it is possible
            if(recallSi != -1)
            {
                pi = recallPi;
                si = recallSi + 1;
                recallSi++;

                continue;
            }

            // scenario 4: if code goes here, means match failed and no recall context
            return false;
        }

        // if code goes here, means whole `s` had been matched
        // but `p` might not be matched completely
        while(pi < p.Length && p[pi] == '*')
        {
            pi++;
        }

        return pi == p.Length;
    }
}

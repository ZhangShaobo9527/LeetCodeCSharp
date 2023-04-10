namespace LeetCodeSolutions.Solutions._0028;

public class Solution
{
    /*
        although this is an "easy" problem, you can solve it in a simple & stupid way just like #27

        but I'm gonna solve this by KMP instead of that simple & stupid way, I have two reasons:
            1. we've already use the simple way in #27
            2. KMP is basically the "model answer" of string search problems

        and I have to confess that: I can not implement KMP without google.
        I had studied KMP for at least 10 times for the past 5 years, everytime, I had always thought that I understand it completely.
        but I always forget it in short than a month.
        always.... damn it.
    */
    public int StrStr(string haystack, string needle)
    {
        return KMP(haystack, needle, GenerateNextArrayForKMP(needle));
    }

    private static int[] GenerateNextArrayForKMP(string needle)
    {
        int[] next = new int[needle.Length];
        next[0] = -1;

        int i = 0;
        int j = -1;

        while(i < needle.Length - 1)
        {
            if(j != -1 && needle[i] != needle[j])
            {
                j = next[j];
                continue;
            }

            i++;
            j++;
            next[i] = j;
        }

        return next;
    }

    private static int KMP(string haystack, string needle, int[] next)
    {
        int i = 0;
        int j = 0;

        while(i < haystack.Length && j < needle.Length)
        {
            if(j != -1 && haystack[i] != needle[j])
            {
                j = next[j];
                continue;
            }

            i++;
            j++;
        }

        if(j == needle.Length)
        {
            return i - j;
        }
        else
        {
            return -1;
        }
    }
}

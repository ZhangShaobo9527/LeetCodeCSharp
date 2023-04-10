namespace LeetCodeSolutions.Solutions._0014;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if(strs.Length == 0)
        {
            return "";
        }
        if(strs.Length == 1)
        {
            return strs[0];
        }

        StringBuilder sb = new StringBuilder();

        int index = 0;

        while(index < strs[0].Length)
        {
            char str0CurrentChar = strs[0][index];

            for(int strsIdx = 1; strsIdx < strs.Length; ++strsIdx)
            {
                if (index >= strs[strsIdx].Length || strs[strsIdx][index] != str0CurrentChar)
                {
                    return sb.ToString();
                }
            }
            sb.Append(str0CurrentChar);
            index++;
        }
        return sb.ToString();
    }
}

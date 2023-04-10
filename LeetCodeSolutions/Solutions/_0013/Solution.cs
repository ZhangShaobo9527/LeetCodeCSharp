namespace LeetCodeSolutions.Solutions._0013;

public class Solution
{
    public int RomanToInt(string s)
    {
        SortedDictionary<int, string> romanNumerals = new SortedDictionary<int, string>()
        {
            { 1000, "M"},
            { 900, "CM"},
            { 500, "D"},
            { 400, "CD"},
            { 100, "C"},
            { 90, "XC"},
            { 50, "L"},
            { 40, "XL"},
            { 10, "X"},
            { 9, "IX"},
            { 5, "V"},
            { 4, "IV"},
            { 1, "I"}
        };

        int res = 0;
        int index = 0;

        foreach(KeyValuePair<int, string> kvp in romanNumerals.Reverse())
        {
            while(index < s.Length)
            {
                if (s.Substring(index).StartsWith(kvp.Value))
                {
                    res += kvp.Key;
                    index += kvp.Value.Length;
                }
                else
                {
                    break;
                }
            }
        }

        return res;
    }
}

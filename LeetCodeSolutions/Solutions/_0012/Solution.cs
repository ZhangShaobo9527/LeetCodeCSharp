namespace LeetCodeSolutions.Solutions._0012;

public class Solution
{
    public string IntToRoman(int num)
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

        StringBuilder sb = new StringBuilder();

        foreach(KeyValuePair<int, string> kvp in romanNumerals.Reverse())
        {
            while(num >= kvp.Key)
            {
                sb.Append(kvp.Value);
                num -= kvp.Key;
            }
        }

        return sb.ToString();
    }
}

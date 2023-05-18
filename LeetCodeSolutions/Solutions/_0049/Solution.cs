namespace LeetCodeSolutions.Solutions._0049;

public class Solution
{
    /*
        the tricky part is how to compare two strings are anagrams

        1. encode the appreance count of each chatacters into something
        2. compare that "something"

        like: 
            "eat" -> "1a1e1t"
            "ate" -> "1a1e1t"
    */
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        // key == "something"
        // value == list of strings
        Dictionary<string, IList<string>> res = new Dictionary<string, IList<string>>();

        foreach(string str in strs)
        {
            string something = Encode(str);
            if(res.ContainsKey(something))
            {
                res[something].Add(str);
            }
            else
            {
                res.Add(something, new List<string> { str });
            }
        }

        return res.Select(kvp => kvp.Value).ToList();
    }

    private string Encode(string str)
    {
        SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
        StringBuilder sb = new StringBuilder();
        foreach(char c in str)
        {
            if(!dict.ContainsKey(c))
            {
                dict.Add(c, 0);
            }
            dict[c]++;
        }
        foreach(KeyValuePair<char, int> kvp in dict)
        {
            sb.Append(kvp.Value);
            sb.Append(kvp.Key);
        }
        return sb.ToString();
    }
}

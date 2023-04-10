namespace LeetCodeSolutions.Solutions._0017;

public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        Dictionary<char, string> lettersOnPhoneNumber = new Dictionary<char, string>
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"},
        };

        List<StringBuilder> res = new List<StringBuilder>();

        foreach(char digit in digits)
        {
            string currentLetters = lettersOnPhoneNumber[digit];

            if(res.Count == 0)
            {
                foreach(char c in currentLetters)
                {
                    res.Add(new StringBuilder().Append(c));
                }

                continue;
            }

            List<StringBuilder> tempRes = new List<StringBuilder>();
            for(int i = 0; i < currentLetters.Length; ++i)
            {
                foreach(StringBuilder sb in res)
                {
                    if(i != currentLetters.Length - 1)
                    {
                        sb.Append(currentLetters[i]);
                        tempRes.Add(new StringBuilder(sb.ToString()));
                        sb.Remove(sb.Length - 1, 1);
                    }
                    else
                    {
                        sb.Append(currentLetters[i]);
                        tempRes.Add(sb);
                    }
                }
            }
            res = tempRes;
        }

        return res.Select(sb => sb.ToString()).ToList();
    }
}

namespace LeetCodeSolutions.Solutions._0038;

public class Solution
{
    public string CountAndSay(int n)
    {
        switch(n)
        {
            case 1: return "1";
            case 2: return "11";
            case 3: return "21";
            case 4: return "1211";
            case 5: return "111221";
            case 6: return "312211";
            case 7: return "13112221";
            case 8: return "1113213211";
            case 9: return "31131211131221";
            case 10: return "13211311123113112211";
            case 11: return "11131221133112132113212221";
            case 12: return "3113112221232112111312211312113211";
            default: break;
        }

        return Say(CountAndSay(n - 1));
    }

    private string Say(string n)
    {
        char currentChar = '?';
        int currentCount = 0;

        StringBuilder res = new StringBuilder();

        for(int i = 0; i < n.Length; ++i)
        {
            if(i == 0)
            {
                currentChar = n[i];
                currentCount = 1;
                continue;
            }

            if (currentChar == n[i])
            {
                currentCount++;
            }
            else
            {
                res.Append($"{currentCount}{currentChar}");
                currentChar = n[i];
                currentCount = 1;
            }
        }

        res.Append($"{currentCount}{currentChar}");

        return res.ToString();
    }
}

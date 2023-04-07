namespace LeetCodeSolutions.Solutions._0009;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if(x < 0)
        {
            return false;
        }

        if(x < 10)
        {
            return true;
        }

        List<int> digits = new List<int>();

        while(x > 0)
        {
            digits.Add(x % 10);
            x /= 10;
        }

        for(int i = 0; i < digits.Count/2; ++i)
        {
            if (digits[i] != digits[digits.Count - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}

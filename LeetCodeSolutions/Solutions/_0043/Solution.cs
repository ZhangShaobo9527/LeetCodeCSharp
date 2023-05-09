namespace LeetCodeSolutions.Solutions._0043;

public class Solution
{
    /*
        this is a solution that completely simulates how human handle multiply operation.
        it is very ineffcient, but it is more in line with the problem description.
    */
    public string Multiply(string num1, string num2)
    {
        string[] midRes = new string[num2.Length];

        for(int i = num2.Length - 1, j = 0; i >= 0; --i, ++j)
        {
            midRes[j] = NumberMultiplyDigit(num1, num2[i]);
            for(int k = 0; k < j; ++k)
            {
                midRes[j] += '0';
            }
        }

        string res = "0";

        foreach(string temp in midRes)
        {
            res = NumberAddNumber(res, temp);
        }

        int firstNonZeroDigitIndex = 0;
        while(firstNonZeroDigitIndex < res.Length && res[firstNonZeroDigitIndex] == '0')
        {
            ++firstNonZeroDigitIndex;
        }

        if(firstNonZeroDigitIndex == res.Length)
        {
            return "0";
        }
        else
        {
            return res.Substring(firstNonZeroDigitIndex);
        }
    }

    // key == num1, value.key == num2, value.value == addResult
    private readonly static Dictionary<char, Dictionary<char, string>> AddTable;

    // key == num2, value.key == num2, value.value == multiplyResult
    private readonly static Dictionary<char, Dictionary<char, string>> MultiplyTable;

    static Solution()
    {
        AddTable = new Dictionary<char, Dictionary<char, string>>();
        MultiplyTable = new Dictionary<char, Dictionary<char, string>>();
        for(char num1 = '0'; num1 <= '9'; ++num1)
        {
            AddTable.Add(num1, new Dictionary<char, string>());
            MultiplyTable.Add(num1, new Dictionary<char, string>());
            for(char num2 = '0'; num2 <= '9'; ++num2)
            {
                int numericNum1 = int.Parse($"{num1}");
                int numericNum2 = int.Parse($"{num2}");
                int addResult = numericNum1 + numericNum2;
                int multiplyResult = numericNum1 * numericNum2;
                AddTable[num1].Add(num2, $"{addResult}");
                MultiplyTable[num1].Add(num2, $"{multiplyResult}");
            }
        }
    }

    private string NumberMultiplyDigit(string num, char digit)
    {
        string res = "";
        char carry = '0';
        for (int i = num.Length - 1; i >= 0; --i)
        {
            string sum = MultiplyTable[digit][num[i]];
            sum = NumberAddNumber(sum, $"{carry}");

            carry = (sum.Length == 1) ? '0' : sum[0];
            res = $"{sum.Last()}{res}";
        }

        if (carry != '0')
        {
            res = $"{carry}{res}";
        }

        return res;
    }

    private string NumberAddNumber(string num1, string num2)
    {
        string res = "";
        char carry = '0';

        for(int i = num1.Length - 1, j = num2.Length - 1; i >= 0 || j >= 0; --i, --j)
        {
            string sum;
            if(i >= 0 && j >= 0)
            {
                sum = AddTable[num1[i]][num2[j]];
            }
            else if(i >= 0)
            {
                sum = $"{num1[i]}";
            }
            else
            {
                sum = $"{num2[j]}";
            }

            if(sum.Length == 1)
            {
                sum = AddTable[sum[0]][carry];
            }
            else
            {
                sum = $"{sum[0]}{AddTable[sum[1]][carry]}";
            }

            carry = (sum.Length == 1) ? '0' : sum[0];
            res = $"{sum.Last()}{res}";
        }

        if(carry != '0')
        {
            res = $"{carry}{res}";
        }

        return res;
    }
}

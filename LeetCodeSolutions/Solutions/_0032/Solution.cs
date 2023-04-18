namespace LeetCodeSolutions.Solutions._0032;

public class Solution
{
    public int LongestValidParentheses(string s)
    {
        int validParenthesesStartIndex = 0;
        int longestValidParenthesesLength = 0;

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
                continue;
            }

            if (stack.Count == 0)
            {
                validParenthesesStartIndex = i + 1;
                continue;
            }

            stack.Pop();

            if (stack.Count == 0)
            {
                int currentValidParenthesesLength = i - validParenthesesStartIndex + 1;
                if (currentValidParenthesesLength > longestValidParenthesesLength)
                {
                    longestValidParenthesesLength = currentValidParenthesesLength;
                }

                continue;
            }
            else
            {
                int currentValidParenthesesLength = i - stack.Peek();

                if (currentValidParenthesesLength > longestValidParenthesesLength)
                {
                    longestValidParenthesesLength = currentValidParenthesesLength;

                    continue;
                }
            }
        }

        return longestValidParenthesesLength;
    }
}

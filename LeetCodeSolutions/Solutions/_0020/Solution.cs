namespace LeetCodeSolutions.Solutions._0020;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s)
        {
            if(c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
                continue;
            }

            if(stack.Count == 0)
            {
                return false;
            }

            char stackTop = stack.Peek();
            if(IsPaired(stackTop, c))
            {
                stack.Pop();
                continue;
            }

            return false;
        }

        return stack.Count == 0;
    }

    private bool IsPaired(char left, char right)
    {
        if(left == '(' && right == ')')
        {
            return true;
        }

        if(left == '[' && right == ']')
        {
            return true;
        }

        if(left == '{' && right == '}')
        {
            return true;
        }

        return false;
    }

}

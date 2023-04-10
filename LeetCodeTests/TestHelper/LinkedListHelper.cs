using LeetCodeSolutions.Definitions;
using System.Text;

namespace LeetCodeTests.TestHelper;

internal class LinkedListHelper
{
    public static ListNode? ParseLinkedListFromString(string line)
    {
        ListNode? head = null;
        ListNode? tail = null;

        string[] elementStrs = line.Substring(1, line.Length - 2).Split(",");
        foreach (string elementStr in elementStrs)
        {
            if (string.IsNullOrEmpty(elementStr))
            {
                continue;
            }

            int number = int.Parse(elementStr);
            if (head == null)
            {
                tail = head = new ListNode(number, null);
            }
            else
            {
                tail!.next = new ListNode(number, null);
                tail = tail.next;
            }
        }

        return head;
    }

    public static string Stringify(ListNode? l)
    {
        if(l is null)
        {
            return "[]";
        }
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        while(l is not null)
        {
            if(l.next is null)
            {
                sb.Append($"{l.val}");
            }
            else
            {
                sb.Append($"{l.val}, ");
            }
            l = l.next;
        }
        sb.Append("]");
        return sb.ToString();
    }
}

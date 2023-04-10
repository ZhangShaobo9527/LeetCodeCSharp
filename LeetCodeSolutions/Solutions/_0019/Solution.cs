namespace LeetCodeSolutions.Solutions._0019;

public class Solution
{
    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        List<ListNode> nodes = new List<ListNode>();
        for(ListNode? i = head; i is not null; i = i.next)
        {
            nodes.Add(i);
        }

        if(n > nodes.Count)
        {
            return head;
        }

        if(n == nodes.Count)
        {
            return head.next;
        }

        nodes[nodes.Count - n - 1].next = nodes[nodes.Count - n].next;

        return head;
    }
}

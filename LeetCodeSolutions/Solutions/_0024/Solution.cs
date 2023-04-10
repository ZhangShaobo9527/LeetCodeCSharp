namespace LeetCodeSolutions.Solutions._0024;

public class Solution
{
    public ListNode? SwapPairs(ListNode? head)
    {
        if(head is null || head.next is null)
        {
            return head;
        }

        ListNode? nodeBeforeFirst = null;
        ListNode? res = null;
        ListNode? first = head;
        ListNode? second = head.next;

        while(true)
        {
            if(nodeBeforeFirst is null)
            {
                nodeBeforeFirst = first;
                res = second;
                first.next = second.next;
                second.next = first;
            }
            else
            {
                nodeBeforeFirst.next = second;
                first.next = second.next;
                second.next = first;
                nodeBeforeFirst = first;
            }

            if(first.next is null || first.next.next is null)
            {
                break;
            }

            second = first.next.next;
            first = first.next;
        }

        return res;
    }
}

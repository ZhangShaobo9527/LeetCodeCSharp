namespace LeetCodeSolutions.Solutions._0025;

public class Solution
{
    /*
        use a stack to store k nodes
    */
    public ListNode? ReverseKGroup(ListNode? head, int k)
    {
        ListNode? prev = null;
        ListNode? p = head;
        while(p is not null)
        {
            Stack<ListNode> kNodes = new Stack<ListNode>();

            ListNode? q = p;

            while(q is not null && kNodes.Count != k)
            {
                kNodes.Push(q);
                q = q.next;
            }

            if(kNodes.Count != k)
            {
                break;
            }

            if(prev is null)
            {
                head = kNodes.Peek();
            }
            else
            {
                prev.next = kNodes.Peek();
            }

            while(kNodes.Count != 0)
            {
                kNodes.Pop().next = kNodes.Count == 0 ? q : kNodes.Peek();
            }

            prev = p;

            p = p.next;
        }

        return head;
    }
}

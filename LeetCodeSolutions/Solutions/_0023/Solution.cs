namespace LeetCodeSolutions.Solutions._0023;

public class Solution
{
    public ListNode? MergeKLists(ListNode?[] lists)
    {
        if(lists is null || lists.Length == 0)
        {
            return null;
        }

        ListNode? res = null;
        ListNode? resTail = null;

        while(true)
        {
            int? minValue = null;
            int? minValueNodeIndex = null;

            for(int i = 0; i < lists.Length; ++i)
            {
                if (lists[i] is null)
                {
                    continue;
                }

                if(minValue is null || lists[i]!.val < minValue.Value)
                {
                    minValue = lists[i]!.val;
                    minValueNodeIndex = i;
                }
            }

            if(minValue is null)
            {
                break;
            }

            ListNode ? minValNode = lists[minValueNodeIndex!.Value];
            lists[minValueNodeIndex.Value] = lists[minValueNodeIndex.Value]!.next;

            if(res is null)
            {
                res = minValNode;
                resTail = minValNode;
            }
            else
            {
                resTail!.next = minValNode;
                resTail = resTail.next;
            }
        }

        return res;
    }
}

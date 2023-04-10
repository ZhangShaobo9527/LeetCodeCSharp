namespace LeetCodeSolutions.Solutions._0021;

public class Solution
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if(list1 is null && list2 is null)
        {
            return null;
        }

        if(list1 is null)
        {
            return list2;
        }

        if(list2 is null)
        {
            return list1;
        }

        ListNode res;
        ListNode resTailNode;

        if(list1.val < list2.val)
        {
            res = resTailNode = list1;
            list1 = list1.next;
        }
        else
        {
            res = resTailNode = list2;
            list2 = list2.next;
        }

        while(list1 is not null && list2 is not null)
        {
            if(list1.val < list2.val)
            {
                resTailNode.next = list1;
                list1 = list1.next;
            }
            else
            {
                resTailNode.next = list2;
                list2 = list2.next;
            }

            resTailNode = resTailNode.next;
        }

        if(list1 is not null)
        {
            resTailNode.next = list1;
        }

        if(list2 is not null)
        {
            resTailNode.next = list2;
        }

        return res;
    }
}

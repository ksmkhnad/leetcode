/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        return MergeKListsHelper(lists, 0, lists.Length - 1);
    }
    
    private ListNode MergeKListsHelper(ListNode[] lists, int low, int high)
    {
        if (low > high) return null;
        if (low == high) return lists[low];

        var mid = (high - low)/2 + low;
        var left = MergeKListsHelper(lists, low, mid);
        var right = MergeKListsHelper(lists, mid + 1, high);

        return Merge2List(left, right);
    }

    private ListNode Merge2List(ListNode left, ListNode right)
    {
        if (left == null) return right;
        if (right == null) return left;
        var fakehead = new ListNode(-1);
        var start = fakehead;
        while (left != null && right != null)
        {
            if (left.val < right.val)
            {
                start.next = left;
                start = start.next;

                left = left.next;
            }
            else
            {
                start.next = right;
                start = start.next;

                right = right.next;
            }
        }

        if (left != null)
        {
            start.next = left;
        }
        if (right != null)
        {
            start.next = right;
        }

        return fakehead.next;

    }
}
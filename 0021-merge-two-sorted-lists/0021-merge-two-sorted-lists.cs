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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        if(list1 == null){ return list2;}
        if(list2 == null){ return list1;}
        
        int[]res1 = convertToArr(list1);
        int[]res2 = convertToArr(list2);
  
        int[] combined = res1.Concat(res2).ToArray();
        Array.Sort(combined);
        
        return convertToListNode(combined);
    }
     
    
    public int[] convertToArr(ListNode x)
    {
        List<int>res = new List<int>();
        Console.WriteLine(x.next);
        while(x.next != null)
        {
            res.Add(x.val);
            x = x.next;
        }
        res.Add(x.val);
        
        return res.ToArray();
    }
    
    public ListNode convertToListNode(Int32[]y)
    {
        ListNode resNode = new ListNode();
        ListNode nowNode = null;

        
        if(y.Length > 0)
        {
            resNode.val = y[0];
            ListNode lastNode = resNode;
            
            for(int i = 1; i<y.Length;i++)
            {
                nowNode = new ListNode();
                nowNode.val = y[i];
                lastNode.next = nowNode;
                
                lastNode = nowNode;
            }
        }
        
        
        return resNode;
    }
}
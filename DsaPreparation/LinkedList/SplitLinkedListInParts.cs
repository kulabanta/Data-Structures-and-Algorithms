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
public class SortColors {
    private int Length(ListNode head)
    {
        int res = 0;
        ListNode curr = head;
        while(curr!=null)
        {
            res++;
            curr = curr.next;
        }
        return res;
    }
    public ListNode[] SplitListToParts(ListNode head, int k) {
        int n = Length(head);
        int p = n/k,q = n%k;
        ListNode[] res = new ListNode[k];
        Array.Fill(res,null);
        ListNode prev = null , curr = head;
        int x = 0;
        for(int i=0;i<q && curr!=null;i++)
        {
            res[x++]=curr;
            for(int j=0;j<=p&&curr!=null;j++)
            {
                prev = curr;
                curr = curr.next;
            }
            prev.next = null;
        }
        while(x<k && curr!=null)
        {
            res[x++]=curr;
            for(int j=0;j<p;j++)
            {
                prev = curr;
                curr = curr.next;
            }
            prev.next = null;
        }
        return res;
    }
}
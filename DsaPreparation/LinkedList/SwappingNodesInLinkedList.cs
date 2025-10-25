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
        ListNode temp = head;
        while(temp!=null)
        {
            res++;
            temp = temp.next;
        }
        return res;
    }
    public ListNode SwapNodes(ListNode head, int k) {
        ListNode firstKth = head;
        int n = Length(head);
        int p = 1;
        while(p<k)
        {
            firstKth = firstKth.next;
            p++;
        }
        p = 1;
        ListNode lastKth = head;
        while(p<(n-k+1))
        {
            lastKth = lastKth.next;
            p++;
        }
        int x = firstKth.val;
        firstKth.val = lastKth.val;
        lastKth.val = x;
        return head;
    }
}
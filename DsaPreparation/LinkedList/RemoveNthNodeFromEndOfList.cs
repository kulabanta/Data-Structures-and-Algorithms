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
            temp=temp.next;
        }
        return res;
    }
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int l = Length(head);
        if(n==l)
            return head.next;
        int p = 1;
        ListNode temp = head,prev = null;

        while(p<(l-n+1))
        {
            prev = temp;
            temp = temp.next;
            p++;
        }
        prev.next = temp.next;
        return head;

    }
}
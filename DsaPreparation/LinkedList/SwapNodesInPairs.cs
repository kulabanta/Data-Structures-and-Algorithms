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
    public ListNode SwapPairs(ListNode head) {
        if(head == null || head.next==null)
            return head;
        ListNode p = null,t1 = head,t2,t3;
        while(t1!=null && t1.next!=null)
        {
            t2 = t1.next;
            t3 = t2.next;
            t2.next = t1;
            t1.next = t3;
            if(p==null)
            {
                head = t2;
            }
            else{
                p.next = t2;
            }
            p=t1;
            t1 = t1.next;
        }
        return head;
    }
}
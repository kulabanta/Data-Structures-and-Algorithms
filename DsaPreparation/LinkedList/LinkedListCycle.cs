/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class SortColors {
    public bool HasCycle(ListNode head) {
        if(head == null)
            return false;
        ListNode slow = head,fast = head.next;
        while(fast!=null)
        {
            if(slow == fast)
                return true;
            slow = slow.next;
            fast = fast.next;
            if(fast!=null)
                fast=fast.next;
        }
        return false;
    }
}
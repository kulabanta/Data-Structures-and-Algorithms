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
    public ListNode OddEvenList(ListNode head) {
        if(head == null || head.next == null)
            return head;
        ListNode ot = head,pot = null ,et = head.next,eh = head.next;
        bool oddTurn = true;
        while(ot!=null && et!=null)
        {
            if(oddTurn)
            {
                pot = ot;
                ot.next = et.next;
                ot = ot.next;
            }   
            else{
                et.next = ot.next;
                et = et.next;
            }
            oddTurn = !oddTurn;
        }
        if(ot == null)
            pot.next = eh;
        else
            ot.next = eh;
        return head;
    }
}
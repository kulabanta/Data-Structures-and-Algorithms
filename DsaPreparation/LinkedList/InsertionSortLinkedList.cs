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
    public ListNode InsertionSortList(ListNode head) {
        if(head==null || head.next == null)
            return head;
        ListNode c,p,i,p1=null,x;
        i=head.next;
        p1=head;
        while(i!=null)
        {
            p = null;
            c = head;
            while(c!=i && c.val<=i.val)
            {
                p=c;
                c=c.next;
            }
            if(c==i)
            {
                p1=i;
                i=i.next;
                continue;
            }
            x=i.next;
            if(p==null)
            {
                p1.next = x;
                i.next = c;
                head = i;
            }
            else{
                p1.next = x;
                p.next = i;
                i.next = c;
            }
            i=x;
        }
        return head;
    }
}
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
    public int Length(ListNode head)
    {
        ListNode p = head;
        int res = 0;
        while(p!=null)
        {
            res++;
            p = p.next;
        }
        return res;
    }
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode p = null, x = null, t = head, t2;
        int n = Length(head);
        while(t!=null && n>=k)
        {
            p = null;
            ListNode t1 = t;
            int i = 1;
            while(i<=k && t!=null)
            {
                t2 =  t.next;
                t.next = p;
                p = t;
                t = t2;
                i++;
            }
            if(x==null)
            {
                head = p;
            }
            else{
                x.next = p;
            }
            x=t1;
            n-=k;
        }
        if(n>0 && x!=null)
            x.next = t;
        return head;
    }
}
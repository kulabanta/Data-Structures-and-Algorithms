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
    public ListNode Reverse(ListNode head)
    {
        ListNode p = null;
        ListNode curr = head;
        ListNode q = curr;

        while(curr!=null)
        {
            q = curr.next;
            curr.next = p;
            p=curr;
            curr = q;
        }
        return p;
    }
    int Length(ListNode head)
    {
        int res = 0;
        ListNode p = head;
        while(p!=null)
        {
            res++;
            p=p.next;
        }
        return res;
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1==null)
            return l2;
        if(l2==null)
            return l1;
        int c = 0;
        int n1 = Length(l1);
        int n2 = Length(l2);
        ListNode cl1,cl2,res,prev;
        if(n1>n2)
        {
            prev = l1;
            res = l1;
            cl1 = l1;
            cl2 = l2;
        }
        else{
            prev = l2;
            res = l2;
            cl1 = l2;
            cl2 = l1;
        }
        while(cl1!=null && cl2!=null)
        {
            int p = cl1.val+cl2.val+c;
            c = p/10;
            p=p%10;

            cl1.val = p;
            prev=cl1;
            cl1 = cl1.next;
            cl2 = cl2.next;

        }

        while(cl1!=null)
        {
            int p = cl1.val+c;
            c = p/10;
            p=p%10;
            cl1.val = p;
            prev = cl1;
            cl1 = cl1.next;
        }
        
        if(c>0)
        {
            prev.next = new ListNode(c);
        }
        return res;

    }
}
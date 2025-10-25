/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class SortColors {
    public int Length(ListNode head)
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
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int lengthA = Length(headA);
        int lengthB = Length(headB);
        ListNode tempA = headA , tempB = headB;

        if(lengthA > lengthB)
        {
            int x = lengthA-lengthB;
            while(x>0)
            {
                tempA = tempA.next;
                x--;
            }
        }
        else{
            int y = lengthB-lengthA;
            while(y>0)
            {
                tempB = tempB.next;
                y--;
            }
        }

        while(tempA!=tempB)
        {
            tempA=tempA.next;
            tempB=tempB.next;
        }
        return tempA;
    }
}
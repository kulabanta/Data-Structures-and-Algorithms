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
    private ListNode temp;
    public bool IsPalindromeRec(ListNode head)
    {
        if(head==null)
            return true;
        bool res = IsPalindromeRec(head.next);
        if(res && temp.val == head.val)
        {
            temp = temp.next;
            return true;
        }
        return false;
        
    }
    public bool IsPalindrome(ListNode head) {
        temp = head;
        return IsPalindromeRec(head);
    }
}
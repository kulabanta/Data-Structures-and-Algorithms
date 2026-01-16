namespace TwoPointers.SlowAndFastPointers.LinkedListsOperations
{
    internal class RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null)
                return head;
            int n = 0;
            ListNode tail = head, p = head;
            while (tail.next != null)
            {
                n++;
                tail = tail.next;
            }
            n++;
            k = k % n;
            if (k == 0)
                return head;
            k = n - k;
            while (k > 1)
            {
                p = p.next;
                k--;
            }
            ListNode x = p.next;
            tail.next = head;
            p.next = null;
            head = x;
            return head;
        }
    }
}

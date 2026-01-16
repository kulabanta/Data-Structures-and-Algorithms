namespace TwoPointers.SlowAndFastPointers.LinkedListsOperations
{
    internal class ReorderList
    {
        private ListNode FindMedian(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode p = head, q = head.next;
            while (q != null && q.next != null)
            {
                p = p.next;
                q = q.next;
                if (q != null)
                    q = q.next;
            }
            return p;
        }
        private ListNode Reverse(ListNode head)
        {
            ListNode x = null, q;
            while (head != null)
            {
                q = head.next;
                head.next = x;
                x = head;
                head = q;
            }
            return x;

        }
        public void Reorderlist(ListNode head)
        {
            if (head == null || head.next == null)
                return;
            ListNode p = FindMedian(head);
            ListNode q = p.next;
            p.next = null;
            q = Reverse(q);
            p = head;
            ListNode x, y;
            while (p != null && q != null)
            {
                x = p.next;
                y = q.next;
                p.next = q;
                q.next = x;
                p = x;
                q = y;
            }
        }
    }
}

namespace TwoPointers.SlowAndFastPointers.LinkedListsOperations
{
    internal class RemoveNthNodeFromEndOfList
    {
        private int curr;
        private bool elementRemoved;
        private ListNode RemoveRec(ListNode head, int n)
        {
            if (head == null)
            {
                return null;
            }
            ListNode p = RemoveRec(head.next, n);
            curr += 1;
            if (curr == n)
            {
                elementRemoved = true;
                head.next = p.next;
            }
            return head;
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            curr = -1;
            elementRemoved = false;
            head = RemoveRec(head, n);
            if (!elementRemoved)
            {
                ListNode p = head;
                head = head.next;
                p.next = null;
            }
            return head;
        }
    }
}

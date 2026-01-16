namespace TwoPointers.SlowAndFastPointers.LinkedListsOperations
{
    internal class LinkedListCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return null;
            ListNode slow = head, fast = head;
            do
            {
                slow = slow.next;
                fast = fast.next;
                if (fast != null)
                    fast = fast.next;
            } while (fast != null && slow != fast);
            if (fast == null)
                return null;
            fast = head;
            while (fast != slow)
            {
                fast = fast.next;
                slow = slow.next;
            }
            return slow;
        }
    }
}

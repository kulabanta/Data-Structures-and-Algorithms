namespace TwoPointers.SlowAndFastPointers.LinkedListsOperations
{
    internal class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;
            ListNode slow = head, fast = head.next;
            while (fast != null)
            {
                if (slow == fast)
                    return true;
                slow = slow.next;
                fast = fast.next;
                if (fast != null)
                    fast = fast.next;
            }
            return false;
        }
    }
}

namespace DsaPreparation.Heap
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            PriorityQueue<ListNode, int> pq = new();
            int n = lists.Length;
            for (int i = 0; i < n; i++)
            {
                if (lists[i] != null)
                {
                    pq.Enqueue(lists[i], lists[i].val);
                }
            }
            ListNode head = null;
            ListNode temp = head;
            while (pq.Count > 0)
            {
                ListNode p = pq.Dequeue();
                if (head == null)
                {
                    head = p;
                    temp = p;
                }
                else
                {
                    temp.next = p;
                    temp = p;
                }
                if (p.next != null)
                {
                    pq.Enqueue(p.next, p.next.val);
                }
            }
            return head;
        }
    }
}

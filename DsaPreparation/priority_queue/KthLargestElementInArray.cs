namespace DsaPreparation.priority_queue
{
    internal class KthLargestElementInArray
    {
        public int FindKthLargest(int[] nums, int k)
        {
            int n = nums.Length;
            PriorityQueue<int, int> pq = new(k);
            for (int i = 0; i < k; i++)
            {
                pq.Enqueue(nums[i], nums[i]);
            }
            for (int i = k; i < n; i++)
            {
                if (nums[i] > pq.Peek())
                {
                    pq.Dequeue();
                    pq.Enqueue(nums[i], nums[i]);
                }
            }
            return pq.Peek();
        }
    }
}

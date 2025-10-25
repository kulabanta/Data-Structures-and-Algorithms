namespace DsaPreparation.Heap
{
    public class TopKFrequestElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            int n = nums.Length;
            PriorityQueue<int, int> pq = new();
            Dictionary<int, int> dt = new();
            foreach (int p in nums)
            {
                if (!dt.ContainsKey(p))
                {
                    dt.Add(p, 1);
                }
                else
                {
                    dt[p]++;
                }
            }
            foreach (KeyValuePair<int, int> kv in dt)
            {
                pq.Enqueue(kv.Key, -kv.Value);
            }
            int[] res = new int[k];
            while (k > 0 && pq.Count > 0)
            {
                res[k - 1] = pq.Dequeue();
                k--;
            }
            return res;

        }

        public int[] TopKFrequentUsingBucketSort(int[] nums, int k)
        {
            int n = nums.Length;
            Dictionary<int, int> dt = new();
            foreach (int p in nums)
            {
                if (!dt.ContainsKey(p))
                {
                    dt.Add(p, 1);
                }
                else
                {
                    dt[p]++;
                }
            }
            List<List<int>> bucketList = new();
            for (int i = 0; i < n; i++)
            {
                bucketList.Add(new List<int>());
            }
            foreach (KeyValuePair<int, int> kv in dt)
            {
                bucketList[kv.Value].Add(kv.Key);
            }
            List<int> res = new();
            for (int i = n - 1; i >= 0; i--)
            {
                if (bucketList[i].Count > 0 && k > 0)
                {
                    for (int j = 0; j < bucketList[i].Count; j++)
                    {
                        res.Add(bucketList[i][j]);
                    }
                    k--;
                }
            }
            return res.ToArray();

        }
    }
}

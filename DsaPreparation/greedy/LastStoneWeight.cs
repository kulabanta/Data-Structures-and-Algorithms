public class SortColors {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> pq = new();
        int n = stones.Length;

        for(int i=0;i<n;i++)
        {
            pq.Enqueue(stones[i],-stones[i]);
        }

        while(pq.Count>1)
        {
            pq.TryDequeue(out int x1,out int p1);
            pq.TryDequeue(out int x2,out int p2);

            if(x1==x2)
            {
                continue;
            }
            else{
                int y = Math.Abs(x1-x2);
                pq.Enqueue(y,-y);
            }
        }
        if(pq.Count>0)
        {
            pq.TryDequeue(out int res , out int resp);
            return res;
        }
        return 0;
    }
}
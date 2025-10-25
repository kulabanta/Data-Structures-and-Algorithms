public class SortColors {
    private List<List<int>> ConstructAdj(int n ,int[][] graph)
    {
        List<List<int>> res = new();
        for(int i=0;i<n;i++)
            res.Add(new List<int>());
        foreach(int[] a in graph)
        {
            res[a[1]].Add(a[0]);
        }
        return res;
    }
    private int[] FindIndegree(int n ,int[][] pre)
    {
        int[] res = new int[n];
        Array.Fill(res,0);
        foreach(int[] p in pre)
        {
            res[p[0]]++;
        }
        return res;
    }
    public int[] FindOrder(int n, int[][] pre) {
        List<List<int>> adj = ConstructAdj(n,pre);
        List<int> res = new();
        Queue<int> q = new();
        int[] inDegree = FindIndegree(n,pre);
        for(int i=0;i<n;i++)
        {
            if(inDegree[i]==0)
                q.Enqueue(i);
        }

        while(q.Count>0)
        {
            int p = q.Dequeue();
            res.Add(p);
            foreach(int x in adj[p])
            {
                inDegree[x]--;

                if(inDegree[x]==0)
                    q.Enqueue(x);
            }
        }

        if(res.Count < n)
            return [];

        return res.ToArray();

    }
}
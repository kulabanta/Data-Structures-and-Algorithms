public class SortColors {
    int[] parent,rank;
    public int Find(int a)
    {
        if(parent[a]==a)
            return a;
        return Find(parent[a]);
    }
    public void Union(int x,int y)
    {
        if(x==y)    
            return;
        if(rank[x]==rank[y])
        {
            parent[y]=x;
            rank[x]++;
        }
        else if(rank[x]>rank[y])
        {
            parent[y]=x;
        }
        else
            parent[x]=y;
    }
    public int RemoveStones(int[][] stones) {
        int n = stones.Length;
        parent = new int[n];
        rank = new int[n];
        for(int i=0;i<n;i++)
        {
            parent[i]=i;
            rank[i]=0;
        }
        for(int i=0;i<n;i++)
        {
            
            for(int j=i+1;j<n;j++)
            {
                int x = Find(i);
                int y = Find(j);

                if(x!=y && stones[i][0]==stones[j][0] || stones[i][1]==stones[j][1])
                {
                    Union(x,y);
                }
            }
        }
        int res = 0;
        for(int i=0;i<n;i++)
        {
            if(parent[i]!=i)
                res++;
        }
        return res;
    }
}
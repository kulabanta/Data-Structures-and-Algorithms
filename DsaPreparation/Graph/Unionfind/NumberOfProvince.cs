public class SortColors {
    int[] parent;
    int[] rank;
    int res;
    int Find(int a)
    {
        if(parent[a]!=a)
            parent[a]=Find(parent[a]);
        return parent[a];
    }
    public void Union(int a,int b)
    {
        int x = Find(a);
        int y = Find(b);
        if(parent[x]==parent[y])
            return;
        res--;
        if(rank[x]<rank[y])
        {
            parent[x]=y;
        }
        else if(rank[y]<rank[x])
        {
            parent[y]=x;
        }
        else
        {
            parent[x]=y;
            rank[y]++;
        }
    }
    public int FindCircleNum(int[][] isConnected) {
        int n = isConnected.Length;
        res = n;
        parent = new int[n];
        rank = new int[n];
        for(int i=0;i<n;i++)
        {
            rank[i]=0;
            parent[i]=i;
        }
        for(int i=0;i<n;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                if(isConnected[i][j]==1)
                {
                   Union(i,j); 
                }
            }
        }
        return res;
    }
}
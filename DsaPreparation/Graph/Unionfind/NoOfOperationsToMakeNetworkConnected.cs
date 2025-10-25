public class UnionFind{
    public int[] parent;
    public int[] rank;
    public int count , extraconn;

    public UnionFind(int n)
    {
        count = n;
        extraconn = 0;
        parent = new int[n];
        rank = new int[n];
        for(int i=0;i<n;i++)
        {
            rank[i]=0;
            parent[i]=i;
        }
    }
    public int Find(int x)
    {
        if(parent[x]==x)
        {
           return x;
        }
        return Find(parent[x]);
    }
    public void Union(int x,int y)
    {
        int a = Find(x);
        int b = Find(y);

        if(a==b)
        {
            extraconn++;
            return ;
        }
            
        count--;
        if(rank[a]>rank[b])
        {
            parent[b]=a;
        }
        else if(rank[a]<rank[b])
        {
            parent[a]=b;
        }
        else{
            parent[a]=b;
            rank[a]++;
        }
    }
}
public class SortColors {
    public int MakeConnected(int n, int[][] connections) {
        UnionFind uf = new(n);
        foreach(int[] a in connections)
        {
            uf.Union(a[0],a[1]); 
        }
        if(uf.extraconn < uf.count-1)
            return -1;
        return uf.count-1;
    }
}
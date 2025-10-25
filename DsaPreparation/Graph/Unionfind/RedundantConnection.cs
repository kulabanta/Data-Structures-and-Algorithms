public class SortColors {
    int[] parent ;
    public int Find(int a)
    {
        if(parent[a]==a)
            return parent[a];
        return Find(parent[a]);
    } 
    public int[] FindRedundantConnection(int[][] edges) {
        int n = edges.Length;
        parent = new int[n+1];
        for(int i=0;i<=n;i++)
            parent[i]=i;
        for(int i=0;i<n;i++)
        {
            int x = Find(edges[i][0]);
            int y = Find(edges[i][1]);

            if(x==y)
                return edges[i];
            
            parent[y]=x;
        }
        return new int[2]{0,0};
    }
}
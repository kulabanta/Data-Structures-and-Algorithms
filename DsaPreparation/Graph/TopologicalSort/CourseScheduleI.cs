public class SortColors {
    int finishedCourse;
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
    private bool Dfs(List<List<int>> adj,int curr,bool[] vis,bool[] rec)
    {
        rec[curr]=true;
        vis[curr]=true;
        bool result = true;
        foreach(int x in adj[curr])
        {
            if(rec[x])
                return false;
            if(!vis[x])
                result&=Dfs(adj,x,vis,rec);
        }
        rec[curr]=false;
        return result;
    }
    public bool CanFinish(int n, int[][] pre) {
        List<List<int>> adj = ConstructAdj(n,pre);
        bool[] vis = new bool[n];
        bool[] rec = new bool[n];
        Array.Fill(vis,false);
        Array.Fill(rec,false);
        bool result = true;
        for(int i=0;i<n;i++)
        {
            result&=Dfs(adj,i,vis,rec);
        }
        return result;
    }
}
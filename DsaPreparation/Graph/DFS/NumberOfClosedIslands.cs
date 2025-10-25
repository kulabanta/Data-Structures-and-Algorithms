public class SortColors {
    private bool[][] vis;
    private bool Dfs(int[][] grid ,int i ,int j,int m ,int n)
    {
        if(i<0 || i>=m || j<0 || j>=n)
            return false;
        if(grid[i][j]==1 || vis[i][j])
            return true;
        vis[i][j]=true;
        bool p = Dfs(grid,i-1,j,m,n);
        bool q = Dfs(grid,i+1,j,m,n);
        bool r = Dfs(grid,i,j-1,m,n);
        bool s = Dfs(grid,i,j+1,m,n);
        bool x = p&q&r&s;
        return x;
    }
    public int ClosedIsland(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        vis = new bool[m][];
        for(int i=0;i<m;i++)
        {
            vis[i]= new bool[n];
            for(int j=0;j<n;j++)
                vis[i][j]=false;
        }
        int res = 0;
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j]==0 && 
                   !vis[i][j] && 
                   Dfs(grid,i,j,m,n))
                {
                    // Console.WriteLine($" i : {i}, j : {j} , {grid[i][j]}");
                    res++;
                }
            }
        }
        return res;
    }
}
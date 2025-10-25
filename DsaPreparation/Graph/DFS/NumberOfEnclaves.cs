public class SortColors {
    private int res ;
    private bool[][] vis;
    private void Dfs(int[][] grid , int x, int y , int m ,int n)
    {
        if(x<0 || x>=m || y<0 || y>=n)
            return;
        if(vis[x][y] || (grid[x][y]==0))
            return;
        vis[x][y]=true;
        res--;
        Dfs(grid,x-1,y,m,n);
        Dfs(grid,x+1,y,m,n);
        Dfs(grid,x,y-1,m,n);
        Dfs(grid,x,y+1,m,n);
    }
    public int NumEnclaves(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;

        vis = new bool[m][];
        for(int i=0;i<m;i++)
        {
            vis[i]=new bool[n];
            for(int j=0;j<n;j++)
            {
                vis[i][j]=false;
                if(grid[i][j]==1)
                    res++;
            }
        }

        //first row
        for(int i=0;i<n;i++)
        {
            Dfs(grid,0,i,m,n);
        }

        //last row
        for(int i=0;i<n;i++)
        {
            Dfs(grid,m-1,i,m,n);
        }

        //first column
        for(int i=0;i<m;i++)
        {
            Dfs(grid,i,0,m,n);
        }

        //last column
        for(int i=0;i<m;i++)
        {
            Dfs(grid,i,n-1,m,n);
        }

        return res;
        
    }
}
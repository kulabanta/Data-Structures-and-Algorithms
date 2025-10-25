public class SortColors {
    bool[][] vis;
    public int MaxArea(int[][] grid,int i,int j,int m,int n )
    {
        if(i<0 || i>=m || j<0 || j>=n)
            return 0;
        if(grid[i][j]==0 || vis[i][j])
            return 0;
        vis[i][j]=true;
        int area =1+MaxArea(grid,i-1,j,m,n)+MaxArea(grid,i+1,j,m,n)+
                    MaxArea(grid,i,j-1,m,n)+MaxArea(grid,i,j+1,m,n);
        return area;
    }
    public int MaxAreaOfIsland(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;

        vis = new bool[m][];
        for(int i=0;i<m;i++)
        {
            vis[i]=new bool[n];
            for(int j=0;j<n;j++)
                vis[i][j]=false;
        }
        int maxArea = 0;
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                int temp = MaxArea(grid,i,j,m,n);
                maxArea = Math.Max(maxArea,temp);
            }
        }
        return maxArea;
        
    }
}
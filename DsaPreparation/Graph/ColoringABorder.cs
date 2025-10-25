public class SortColors {
    private bool[][] vis;
    private bool ColorBorderRec(int[][] grid,bool[][] vis,int i,int j,int m,int n,int currColor,int color)
    {
        Console.WriteLine($"{i},{j}");
        if(i<0 || i>=m || j<0 || j>=n)
            return false;
        if(grid[i][j]!=currColor)
            return false;
        if(vis[i][j])
            return true;
        vis[i][j]=true;
        bool p1= ColorBorderRec(grid,vis,i-1,j,m,n,currColor,color);
        bool p2= ColorBorderRec(grid,vis,i+1,j,m,n,currColor,color);
        bool p3= ColorBorderRec(grid,vis,i,j-1,m,n,currColor,color);
        bool p4= ColorBorderRec(grid,vis,i,j+1,m,n,currColor,color);
        bool p = p1&p2&p3&p4;
        if(!p)
            grid[i][j]=color;
        return true;
    }
    private bool feasible(int i,int j,int m,int n)
    {
        if(i<0 || i>=m || j<0 || j>=n)
            return false;
        return true;
        
    }
    private bool checkBorder(int[][] grid,int i,int j,int m,int n)
    {
        int color = grid[i][j];

        if((!feasible(i-1,j,m,n) || (!vis[i-1][j] && grid[i-1][j]!=color)) ||
           (!feasible(i+1,j,m,n) || (!vis[i+1][j] && grid[i+1][j]!=color)) || 
           (!feasible(i,j-1,m,n) || (!vis[i][j-1] && grid[i][j-1]!=color)) || 
           (!feasible(i,j+1,m,n) || (!vis[i][j+1] && grid[i][j+1]!=color)))
            return true;
        return false;
    }
    public int[][] ColorBorder(int[][] grid, int row, int col, int color) {
        int m = grid.Length;
        int n = grid[0].Length;

        vis = new bool[m][];
        for(int i=0;i<m;i++)
        {
            vis[i]=new bool[n];
            Array.Fill(vis[i],false);
        }
        Queue<int[] > q = new();

        q.Enqueue(new int[]{row,col});
        vis[row][col]=true;
        int[] x = new int[]{-1,0,1,0};
        int[] y = new int[]{0,1,0,-1};
        int currColor = grid[row][col];
        while(q.Count>0)
        {
            int[] p = q.Dequeue();

            if(checkBorder(grid,p[0],p[1],m,n))
                grid[p[0]][p[1]]=color;
            for(int i=0;i<4;i++)
            {
                int x1 = p[0]+x[i];
                int y1 = p[1]+y[i];

                if(feasible(x1,y1,m,n) && grid[x1][y1]==currColor && !vis[x1][y1])
                {
                    vis[x1][y1]=true;
                    q.Enqueue(new int[]{x1,y1});
                }
            }
            
        }
        return grid;
    }
}
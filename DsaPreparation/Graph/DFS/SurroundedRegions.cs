public class SortColors {
    bool[][] vis;
    public void Dfs(char[][] board,int i ,int j,int m ,int n)
    {
        if(i<0 || i>=m || j<0 || j>=n)
            return ;
        if(vis[i][j] || board[i][j]=='X')
            return;
        Console.WriteLine($"i : {i} , j : {j}");
        vis[i][j]=true;
        Dfs(board,i-1,j,m,n);
        Dfs(board,i+1,j,m,n);
        Dfs(board,i,j-1,m,n);
        Dfs(board,i,j+1,m,n);
    }
    public void Solve(char[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        vis = new bool[m][];
        for(int i=0;i<m;i++)
        {
            vis[i]=new bool[n];
            for(int j=0;j<n;j++)
                vis[i][j]=false;
        }
        //first row
        for(int i=0;i<n;i++)
        {
            if(board[0][i]=='O' && !vis[0][i])
                Dfs(board,0,i,m,n);
        }
         //last row
        for(int i=0;i<n;i++)
        {
            if(board[m-1][i]=='O' && !vis[m-1][i])
                Dfs(board,m-1,i,m,n);
        }
         //first column
        for(int i=0;i<m;i++)
        {
            if(board[i][0]=='O' && !vis[i][0])
                Dfs(board,i,0,m,n);
        }
         //last column
        for(int i=0;i<m;i++)
        {
            if(board[i][n-1]=='O' && !vis[i][n-1])
                Dfs(board,i,n-1,m,n);
        }
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(!vis[i][j] && board[i][j]=='O')
                {
                    board[i][j]='X';
                }
            }
        }
    }
}
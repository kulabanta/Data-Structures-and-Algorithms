public class RottenOranges
{
    public bool Feasible(int x, int y, int m, int n)
    {
        if (x < 0 || x >= m || y < 0 || y >= n)
            return false;
        return true;
    }
    public int OrangesRotting(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int res = 0;
        Queue<List<int>> q = new();
        int fresh = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 2)
                    q.Enqueue(new List<int> { i, j });
                else if (grid[i][j] == 1)
                {
                    fresh++;
                }
            }
        }
        if (fresh == 0)
            return 0;
        int[] dx = new int[] { 0, -1, 0, 1 };
        int[] dy = new int[] { -1, 0, 1, 0 };
        while (q.Count() > 0)
        {
            int p = q.Count();
            bool first = true;
            for (int j = 0; j < p; j++)
            {
                List<int> l = q.Dequeue();
                for (int k = 0; k < 4; k++)
                {
                    int x = l[0] + dx[k];
                    int y = l[1] + dy[k];
                    if (Feasible(x, y, m, n) && grid[x][y] == 1)
                    {
                        if (first)
                        {
                            res++;
                            first = false;
                        }
                        grid[x][y] = 2;
                        q.Enqueue(new List<int> { x, y });
                        fresh--;
                    }
                }
            }
        }
        return fresh > 0 ? -1 : res;
    }
}
namespace DsaPreparation.Graph.BFS
{
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
            Queue<int[]> q = new();
            bool[][] vis = new bool[m][];
            int fresh = 0;
            for (int i = 0; i < m; i++)
            {
                vis[i] = new bool[n];
                for (int j = 0; j < n; j++)
                {
                    vis[i][j] = false;
                    if (grid[i][j] == 2)
                    {
                        q.Enqueue(new int[] { i, j, 0 });
                    }
                    else if (grid[i][j] == 1)
                        fresh++;
                }
            }
            int[] x = new int[] { -1, 0, 1, 0 };
            int[] y = new int[] { 0, 1, 0, -1 };
            int res = 0;
            while (q.Count > 0)
            {
                int[] p = q.Dequeue();
                if (res < p[2])
                    res = p[2];
                for (int i = 0; i < 4; i++)
                {
                    int px = p[0] + x[i];
                    int py = p[1] + y[i];

                    if (Feasible(px, py, m, n) && !vis[px][py] && grid[px][py] == 1)
                    {
                        fresh--;
                        vis[px][py] = true;
                        grid[px][py] = 2;
                        q.Enqueue(new int[] { px, py, p[2] + 1 });
                    }
                }
            }
            if (fresh > 0)
                return -1;
            return res;

        }
    }
}
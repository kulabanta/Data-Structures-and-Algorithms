namespace DsaPreparation.Graph.BFS
{
    public class AsFarFromLandAsPossible
    {
        public bool feasible(int x, int y, int m, int n)
        {
            if (x < 0 || x >= m || y < 0 || y >= n)
                return false;
            return true;
        }
        public int MaxDistance(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            bool[][] vis = new bool[m][];

            for (int i = 0; i < m; i++)
            {
                vis[i] = new bool[n];
                Array.Fill(vis[i], false);
            }
            Queue<int[]> q = new();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        vis[i][j] = true;
                        q.Enqueue(new int[] { i, j, 0 });
                    }
                }
            }
            if (q.Count == 0)
                return -1;
            int[] x = new int[] { -1, 0, 1, 0 };
            int[] y = new int[] { 0, 1, 0, -1 };
            int res = -1;
            while (q.Count > 0)
            {
                int[] p = q.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int px = p[0] + x[i];
                    int py = p[1] + y[i];

                    if (feasible(px, py, m, n) && !vis[px][py])
                    {
                        vis[px][py] = true;
                        int temp = p[2] + 1;
                        if (temp > res)
                            res = temp;
                        q.Enqueue(new int[] { px, py, temp });
                    }
                }

            }
            return res;
        }
    }
}
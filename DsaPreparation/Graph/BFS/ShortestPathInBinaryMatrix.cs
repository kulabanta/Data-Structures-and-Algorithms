namespace DsaPreparation.Graph.BFS
{
    public class ShortestPathInBinaryMatrix
    {
        public bool Feasible(int x, int y, int n)
        {
            if (x < 0 || x >= n || y < 0 || y >= n)
                return false;
            return true;
        }
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            int n = grid.Length;
            if (n < 1 || grid[0][0] == 1 || grid[n - 1][n - 1] == 1)
                return -1;
            bool[][] vis = new bool[n][];
            for (int i = 0; i < n; i++)
            {
                vis[i] = new bool[n];
                Array.Fill(vis[i], false);
            }
            Queue<int[]> q = new();
            q.Enqueue(new int[] { 0, 0, 1 });
            vis[0][0] = true;
            int[] x = new int[] { 0, -1, -1, -1, 0, 1, 1, 1 };
            int[] y = new int[] { -1, -1, 0, 1, 1, 1, 0, -1 };

            while (q.Count > 0)
            {
                int[] p = q.Dequeue();
                if (p[0] == n - 1 && p[1] == n - 1)
                    return p[2];
                for (int i = 0; i < 8; i++)
                {
                    int px = p[0] + x[i];
                    int py = p[1] + y[i];

                    if (Feasible(px, py, n) && !vis[px][py] && grid[px][py] == 0)
                    {
                        vis[px][py] = true;
                        q.Enqueue(new int[] { px, py, p[2] + 1 });
                    }
                }
            }
            return -1;
        }
    }
}
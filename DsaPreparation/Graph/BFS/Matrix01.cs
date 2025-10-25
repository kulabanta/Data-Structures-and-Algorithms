namespace DsaPreparation.Graph.BFS
{
    public class Matrix01
    {
        public bool feasible(int x, int y, int m, int n)
        {
            if (x < 0 || x >= m || y < 0 || y >= n)
                return false;
            return true;
        }
        public int[][] UpdateMatrix(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            Queue<int[]> q = new();
            bool[][] vis = new bool[m][];

            for (int i = 0; i < m; i++)
            {
                vis[i] = new bool[n];
                Array.Fill(vis[i], false);
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        q.Enqueue(new int[] { i, j });
                        vis[i][j] = true;
                    }
                }
            }
            int[] x = new int[] { -1, 0, 1, 0 };
            int[] y = new int[] { 0, 1, 0, -1 };
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
                        mat[px][py] = 1 + mat[p[0]][p[1]];
                        q.Enqueue(new int[] { px, py });
                    }
                }

            }
            return mat;
        }
    }
}
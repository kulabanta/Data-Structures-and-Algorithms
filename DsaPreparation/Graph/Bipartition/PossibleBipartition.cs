namespace DsaPreparation.Graph.Bipartition
{
    public class PossibleBipartition
    {
        public bool PossibleBipartition(int n, int[][] dislikes)
        {
            List<List<int>> adj = new();
            int[] color = new int[n + 1];
            Array.Fill(color, -1);
            for (int i = 0; i <= n; i++)
                adj.Add(new List<int>());
            foreach (int[] a in dislikes)
            {
                adj[a[0]].Add(a[1]);
                adj[a[1]].Add(a[0]);
            }
            Queue<int> q = new();
            for (int i = 1; i <= n; i++)
            {
                if (color[i] != -1)
                    continue;
                color[i] = 0;
                q.Enqueue(i);
                //start a new BFS
                while (q.Count > 0)
                {
                    int p = q.Dequeue();
                    foreach (int x in adj[p])
                    {
                        if (color[x] == color[p])
                            return false;
                        if (color[x] == -1)
                        {
                            color[x] = 1 - color[p];
                            q.Enqueue(x);
                        }
                    }
                }
            }
            return true;
        }
    }
}
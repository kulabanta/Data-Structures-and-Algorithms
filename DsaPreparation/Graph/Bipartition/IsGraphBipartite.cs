namespace DsaPreparation.Graph.Bipartition
{
    public class IsGraphBipartite
    {
        public bool IsBipartite(int[][] graph)
        {
            int n = graph.Length;
            int[] color = new int[n];
            Array.Fill(color, -1);

            Queue<int> q = new();

            for (int i = 0; i < n; i++)
            {
                if (color[i] > -1)
                    continue;
                color[i] = 0;
                q.Enqueue(i);

                while (q.Count > 0)
                {
                    int p = q.Dequeue();
                    foreach (int x in graph[p])
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
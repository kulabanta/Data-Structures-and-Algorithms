namespace DsaPreparation.Graph.DFS
{
    public class FindEventualSafeStates
    {
        bool[] vis, safeNode;
        bool Dfs(int[][] graph, int curr)
        {
            if (vis[curr])
                return safeNode[curr];
            vis[curr] = true;
            if (graph[curr].Length == 0)
            {
                safeNode[curr] = true;
                return safeNode[curr];
            }
            bool p = true;
            for (int i = 0; i < graph[curr].Length; i++)
            {
                p &= Dfs(graph, graph[curr][i]);
            }
            safeNode[curr] = p;
            return safeNode[curr];
        }
        public IList<int> EventualSafeNodes(int[][] graph)
        {
            int n = graph.Length;
            vis = new bool[n];
            safeNode = new bool[n];
            Array.Fill(vis, false);
            Array.Fill(safeNode, false);
            IList<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (Dfs(graph, i))
                    result.Add(i);
            }
            return result;
        }
    }
}
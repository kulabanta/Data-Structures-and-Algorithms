namespace DsaPreparation.Graph.DFS
{
    public class KeysAndRooms
    {
        private int visRooms;
        private void Dfs(IList<IList<int>> rooms, int curr, bool[] vis)
        {
            if (curr >= rooms.Count)
                return;
            if (vis[curr])
                return;
            vis[curr] = true;
            visRooms--;
            for (int i = 0; i < rooms[curr].Count; i++)
            {
                Dfs(rooms, rooms[curr][i], vis);
            }
        }
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            int n = rooms.Count;
            bool[] vis = new bool[n];
            Array.Fill(vis, false);
            visRooms = n;
            Dfs(rooms, 0, vis);
            return visRooms == 0;

        }
    }
}
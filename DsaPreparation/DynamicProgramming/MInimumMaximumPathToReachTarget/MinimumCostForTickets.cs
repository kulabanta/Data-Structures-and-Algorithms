namespace DsaPreparation.DynamicProgramming.MInimumMaximumPathToReachTarget
{
    public class MinimumCostForTickets
    {
        public int MincostTickets(int[] days, int[] costs)
        {
            int n = days.Length;
            int[] res = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                int p = i < n - 1 ? costs[0] + res[i + 1] : costs[0];
                int q = costs[1], r = costs[2];
                int x = i;
                while (x < n && days[x] <= days[i] + 6)
                    x++;
                if (x < n)
                    q += res[x];
                while (x < n && days[x] <= days[i] + 29)
                    x++;
                if (x < n)
                    r += res[x];
                res[i] = Math.Min(p, Math.Min(q, r));
            }
            return res[0];
        }
    }
}
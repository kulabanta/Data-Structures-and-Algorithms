namespace DsaPreparation.DynamicProgramming.MInimumMaximumPathToReachTarget
{
    public class MinCostClimblingStairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            int n = cost.Length;

            for (int i = 2; i < n; i++)
            {
                cost[i] += Math.Min(cost[i - 2], cost[i - 1]);
            }
            return Math.Min(cost[n - 1], cost[n - 2]);
        }
    }
}
namespace DsaPreparation.DynamicProgramming.MInimumMaximumPathToReachTarget
{
    public class CoinChange
    {
        public int CoinChanges(int[] coins, int amount)
        {
            int[] res = new int[amount + 1];
            Array.Fill(res, int.MaxValue);
            res[0] = 0;
            for (int amt = 1; amt <= amount; amt++)
            {
                foreach (int coin in coins)
                {
                    if (amt - coin >= 0 && res[amt - coin] != int.MaxValue)
                        res[amt] = Math.Min(res[amt], res[amt - coin] + 1);
                }
            }
            return res[amount] == int.MaxValue ? -1 : res[amount];
        }
    }
}
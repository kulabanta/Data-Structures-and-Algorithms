public class BestTimeToBuyAndSellStocks {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int res = 0;
        if(n<=1)
            return 0;
        int mx = prices[n-1];
        for(int i=n-2;i>=0;i--)
        {
            res = Math.Max(res,mx-prices[i]);
            mx = Math.Max(mx,prices[i]);
        }
        return res;
    }
}
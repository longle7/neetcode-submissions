public class Solution {
    public int MaxProfit(int[] prices) {
        int maxP = 0;
        int minBuy = prices[0];

        foreach (var p in prices)
        {
            maxP = Math.Max(maxP, p - minBuy);
            minBuy = Math.Min(p, minBuy);
        }
        return maxP;
    }
}

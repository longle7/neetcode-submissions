public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int maxP = 0;

        foreach (var p in prices)
        {
            minPrice = Math.Min(minPrice, p);
            maxP = Math.Max(maxP, p - minPrice);
        }
        return maxP;
    }
}

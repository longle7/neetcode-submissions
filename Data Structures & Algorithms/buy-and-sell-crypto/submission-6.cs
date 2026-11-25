public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int maxP = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            minPrice = Math.Min(minPrice, prices[i]);
            maxP = Math.Max(maxP, prices[i] - minPrice);
        }

        return maxP;
    }
}

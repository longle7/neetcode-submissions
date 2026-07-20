public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = prices[0];
        int maxPrice = 0;

        foreach (var p in prices)
        {
            minPrice = Math.Min(minPrice, p);
            maxPrice = Math.Max(maxPrice, p - minPrice);
        }

        return maxPrice;
    }
}

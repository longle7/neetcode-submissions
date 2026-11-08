public class Solution {
    public int MaxProfit(int[] prices) {
        int minPri = prices[0];
        int maxPro = 0;

        foreach (var p in prices)
        {
            minPri = Math.Min(minPri, p);
            maxPro = Math.Max(p - minPri, maxPro);
        }

        return maxPro;
    }
}

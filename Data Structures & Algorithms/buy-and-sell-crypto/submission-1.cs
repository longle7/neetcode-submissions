public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int left = 0;
        int right = left + 1;
        int result = 0;

        while (right < prices.Length)
        {
            if (prices[left] < prices[right])
            {
                result = Math.Max(result, prices[right] - prices[left]);
            }
            else
            {
                left = right;
            }
            right++;
        }
        return result;
    }
}

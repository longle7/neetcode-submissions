public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int minLen = int.MaxValue;
        int sum = 0;
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];

            while (sum >= target)
            {
                minLen = Math.Min(minLen, right - left + 1);
                sum -= nums[left++];
            }
        }

        return minLen == int.MaxValue ? 0 : minLen;
    }
}